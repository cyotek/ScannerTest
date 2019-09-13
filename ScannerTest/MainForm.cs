using Cyotek.QuickScan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using CommonDialog = WIA.CommonDialog;

namespace ScannerTest
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private IDeviceManager _deviceManager;

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      this.LoadDevices();
    }

    private void LoadDevices()
    {
      IDeviceInfos devices;

      _deviceManager = new DeviceManager();

      devices = _deviceManager.DeviceInfos;

      deviceComboBox.Items.Clear();

      for (int i = 0; i < devices.Count; i++)
      {
        IDeviceInfo device;

        device = devices[i + 1];

        if (device.Type == WiaDeviceType.ScannerDeviceType)
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
    }
    private DeviceInfo GetSelectedDeviceInfo()
    {
      DeviceInfo deviceInfo;

      if (deviceComboBox.SelectedItem is DeviceListBoxItem deviceListBoxItem)
      {
        deviceInfo = _deviceManager.DeviceInfos[deviceListBoxItem.DeviceId];
      }
      else
      {
        deviceInfo = null;
      }

      return deviceInfo;
    }
    private Device GetSelectedDevice()
    {
      Device result;
      DeviceInfo deviceInfo;

      deviceInfo = this.GetSelectedDeviceInfo();

      if (deviceInfo != null)
      {
        result = deviceInfo.Connect();
      }
      else
      {
        result = null;
      }

      return result;
    }

    private void PerformDialogAtion(Action<Device, ICommonDialog> action)
    {
      Device device;

      device = this.GetSelectedDevice();

      if (device != null)
      {
        ICommonDialog dialog;

        dialog = new CommonDialog();

        action(device, dialog);
      }
      else
      {
        MessageBox.Show("No device selected.", "Device Properties", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        MessageBox.Show("No device selected.", "Device Properties", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void ShowAcquisitionWizardButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        dialog.ShowAcquisitionWizard(device);
      });
    }

    private void ShowAquireImageButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((_, dialog) =>
      {
        dialog.ShowAcquireImage();
      });
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


    private void ShowSelectDeviceButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((_, dialog) =>
      {
        Device selection;

        selection = dialog.ShowSelectDevice();

        if (selection != null)
        {
          this.SetDevice(selection.DeviceID);
        }
      });
    }

    private void ShowDevicePropertiesButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        dialog.ShowDeviceProperties(device);
      });
    }

    private void ShowItemPropertiesButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        dialog.ShowItemProperties(device.Items[1]);
      });
    }

    private void ShowSelectItemsButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        var x = dialog.ShowSelectItems(device)[1];
      });
    }

    private void ShowTransferButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((device, dialog) =>
      {
        dialog.ShowTransfer(device.Items[1]);
      });
    }

    private void ShowPhotoPrintingWizardButton_Click(object sender, EventArgs e)
    {
      this.PerformDialogAtion((_, dialog) =>
      {
        string[] files;

        files = new[]
        {
          @"D:\Checkout\trunk\cyotek\source\demo\ScannerTest\res\tower-bridge-at-night.jpg",
          @"D:\Checkout\trunk\cyotek\source\demo\ScannerTest\res\tower-of-london.jpg"
        };

        dialog.ShowPhotoPrintingWizard(@"D:\Checkout\trunk\cyotek\source\demo\ScannerTest\res\tower-of-london.jpg");
      });
    }
  }
}
