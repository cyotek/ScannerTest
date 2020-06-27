using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WIA;
using CommonDialog = WIA.CommonDialog;
using FileInfo = Cyotek.Demo.ExifOrientation.FileInfo;

namespace Cyotek.Demo.ScannerTest
{
  internal partial class MainForm : BaseForm
  {
    #region Private Fields

    private readonly string[] _photoMasks = { "*.bmp", "*.gif", "*.jpg", "*.png", "*.tif", "*.tiff" };

    private DeviceManager _deviceManager;

    private WiaDeviceType _deviceType;

    private Bitmap _image;

    private Items _items;

    #endregion Private Fields

    #region Public Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Private Properties

    private string SamplesPath
    {
      get { return Path.Combine(Application.StartupPath, "samples"); }
    }

    #endregion Private Properties

    #region Protected Methods

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      this.SetDeviceType(WiaDeviceType.UnspecifiedDeviceType);
      this.LoadSamples();
    }

    #endregion Protected Methods

    #region Private Methods

    private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void AllDevicesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SetDeviceType(WiaDeviceType.UnspecifiedDeviceType);
    }

    private void CamerasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SetDeviceType(WiaDeviceType.CameraDeviceType);
    }

    private void CyotekWebLinkToolStripStatusLabel_Click(object sender, EventArgs e)
    {
      AboutDialog.OpenCyotekHomePage();
    }

    private void DeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      _items = null;
    }

    private void DeviceItemPropertiesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.PerformDeviceAction(device => PropertiesDialog.ShowPropertiesDialog(device.Properties));
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private Device GetSelectedDevice()
    {
      DeviceInfo deviceInfo;

      deviceInfo = this.GetSelectedDeviceInfo();

      return deviceInfo?.Connect();
    }

    private DeviceInfo GetSelectedDeviceInfo()
    {
      return deviceComboBox.SelectedItem is DeviceListBoxItem deviceListBoxItem
        ? _deviceManager.DeviceInfos[deviceListBoxItem.DeviceId]
        : null;
    }

    private void ItemPropertiesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (_items?.Count > 0)
      {
        PropertiesDialog.ShowPropertiesDialog(_items[1].Properties);
      }
      else
      {
        MessageBox.Show("No items have been selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void LoadDevices()
    {
      DeviceInfos devices;

      _deviceManager = new DeviceManager();

      devices = _deviceManager.DeviceInfos;

      deviceComboBox.BeginUpdate();
      deviceComboBox.Items.Clear();

      for (int i = 1; i <= devices.Count; i++)
      {
        DeviceInfo device;

        device = devices[i];

        if (_deviceType == WiaDeviceType.UnspecifiedDeviceType || device.Type == _deviceType)
        {
          deviceComboBox.Items.Add(new DeviceListBoxItem(device));
        }
      }

      if (deviceComboBox.Items.Count != 0)
      {
        deviceComboBox.Sorted = true;
        deviceComboBox.Sorted = false;
        deviceComboBox.SelectedIndex = 0;
      }

      deviceComboBox.EndUpdate();
    }

    private void LoadSamples()
    {
      filesListBox.BeginUpdate();
      filesListBox.Items.Clear();

      for (int i = 0; i < _photoMasks.Length; i++)
      {
        this.LoadSamples(_photoMasks[i]);
      }

      if (filesListBox.Items.Count != 0)
      {
        filesListBox.Sorted = true;
        filesListBox.Sorted = false;
        filesListBox.SelectedIndex = 0;
      }

      filesListBox.EndUpdate();
    }

    private void LoadSamples(string pattern)
    {
      foreach (string fileName in Directory.EnumerateFiles(this.SamplesPath, pattern))
      {
        filesListBox.Items.Add(new FileInfo(fileName));
      }
    }

    private void PerformDeviceAction(Action<Device> action)
    {
      Device device;

      device = this.GetSelectedDevice();

      if (device != null)
      {
        action(device);
      }
      else
      {
        MessageBox.Show("No device selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void PerformDialogAtion(Action<Device, CommonDialog> action, bool allowNullDevice = false)
    {
      Device device;

      device = this.GetSelectedDevice();

      if (device != null || allowNullDevice)
      {
        CommonDialog dialog;

        dialog = new CommonDialog();

        action(device, dialog);
      }
      else
      {
        MessageBox.Show("No device selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void ProcessImage(ImageFile image)
    {
      previewImageBox.Image = null;
      _image?.Dispose();

      if (image != null)
      {
        _image = image.ToBitmap();

        previewImageBox.Image = _image;
        previewImageBox.ZoomToFit();
      }
      else
      {
        _image = null;
      }
    }

    private void RefreshDevicesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LoadDevices();
    }

    private void ScannersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SetDeviceType(WiaDeviceType.ScannerDeviceType);
    }

    private void SetDevice(string deviceId)
    {
      for (int i = 0; i < deviceComboBox.Items.Count; i++)
      {
        if (deviceComboBox.Items[i] is DeviceListBoxItem item && string.Equals(item.DeviceId, deviceId, StringComparison.OrdinalIgnoreCase))
        {
          deviceComboBox.SelectedIndex = i;
          break;
        }
      }
    }

    private void SetDeviceType(WiaDeviceType deviceType)
    {
      _deviceType = deviceType;

      allDevicesToolStripMenuItem.Checked = (deviceType == WiaDeviceType.UnspecifiedDeviceType);
      scannersToolStripMenuItem.Checked = (deviceType == WiaDeviceType.ScannerDeviceType);
      camerasToolStripMenuItem.Checked = (deviceType == WiaDeviceType.CameraDeviceType);
      videoToolStripMenuItem.Checked = (deviceType == WiaDeviceType.VideoDeviceType);

      this.LoadDevices();
    }

    private void ShowAcquisitionWizardButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) => dialog.ShowAcquisitionWizard(device));
    }

    private void ShowAquireImageButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((_, dialog) => this.ProcessImage(dialog.ShowAcquireImage()));
    }

    private void ShowDevicePropertiesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.PerformDialogAtion((device, dialog) => dialog.ShowDeviceProperties(device));
    }

    private void ShowItemPropertiesButton_Click(object sender, EventArgs e)
    {
      if (_items?.Count > 0)
      {
        this.PerformDialogAtion((device, dialog) => dialog.ShowItemProperties(_items[1]));
      }
      else
      {
        MessageBox.Show("No items have been selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void ShowPhotoPrintingWizardButton_Click(object sender, EventArgs e)
    {
      if (filesListBox.SelectedItems.Count == 0)
      {
        MessageBox.Show("Select one or more image files to print.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        Vector files;

        files = new Vector();

        for (int i = 0; i < filesListBox.SelectedItems.Count; i++)
        {
          files.Add(((FileInfo)filesListBox.SelectedItems[i]).FullPath);
        }

        this.PerformDialogAtion((_, dialog) => dialog.ShowPhotoPrintingWizard(files), allowNullDevice: true);
      }
    }

    private void ShowSelectDeviceButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((_, dialog) =>
      {
        Device selection;

        try
        {
          selection = dialog.ShowSelectDevice(AlwaysSelectDevice: true);
        }
        catch (COMException ex) when (ex.ErrorCode == NativeConstants.WIA_S_NO_DEVICE_AVAILABLE)
        {
          MessageBox.Show("No devices are available. Please plug in a device such as a Scanner or Camera and try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          selection = null;
        }

        if (selection != null)
        {
          this.SetDevice(selection.DeviceID);
        }
      }, allowNullDevice: true);
    }

    private void ShowSelectItemsButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        _items = dialog.ShowSelectItems(device, SingleSelect: false);
      });
    }

    private void ShowTransferButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) => this.ProcessImage(dialog.ShowTransfer(device.Items[1])));
    }

    private void ShowTransferSelectedButton_Click(object sender, EventArgs e)
    {
      if (_items?.Count > 0)
      {
        this.PerformDialogAtion((_, dialog) => this.ProcessImage(dialog.ShowTransfer(_items[1])));
      }
      else
      {
        MessageBox.Show("No items have been selected.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void VideoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SetDeviceType(WiaDeviceType.VideoDeviceType);
    }

    #endregion Private Methods
  }
}