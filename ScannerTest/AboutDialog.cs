using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cyotek.Demo.ScannerTest
{
  internal partial class AboutDialog : BaseForm
  {
    #region Public Constructors

    public AboutDialog()
    {
      this.InitializeComponent();
    }

    #endregion Public Constructors

    #region Public Methods

    public static DialogResult ShowAboutDialog()
    {
      using (AboutDialog dialog = new AboutDialog())
      {
        return dialog.ShowDialog();
      }
    }

    #endregion Public Methods

    #region Internal Methods

    internal static void OpenCyotekHomePage()
    {
      try
      {
        Process.Start("https://www.cyotek.com");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().Message, "Open Internet Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion Internal Methods

    #region Protected Methods

    protected override void OnFontChanged(EventArgs e)
    {
      base.OnFontChanged(e);

      nameLabel.Font = new Font(this.Font, FontStyle.Bold);
    }

    protected override void OnLoad(EventArgs e)
    {
      FileVersionInfo versionInfo;
      int x;

      if (!this.DesignMode)
      {
        this.Font = SystemFonts.DialogFont;
      }

      versionInfo = FileVersionInfo.GetVersionInfo(typeof(MainForm).Assembly.Location);
      nameLabel.Text = versionInfo.ProductName;
      versionLabel.Text = "Version " + versionInfo.ProductVersion;
      copyrightLabel.Text = versionInfo.LegalCopyright;

      iconPictureBox.Size = SystemInformation.IconSize;
      iconPictureBox.Image = Application.OpenForms.Cast<Form>().Single(f => f.GetType() == typeof(MainForm)).Icon.ToBitmap();

      x = iconPictureBox.Right + iconPictureBox.Margin.Right + nameLabel.Margin.Left;

      nameLabel.Left = x;
      copyrightLabel.Left = x;

      base.OnLoad(e);
    }

    #endregion Protected Methods

    #region Private Methods

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void webLinkLabel_LinkClicked(object sender, EventArgs e)
    {
      OpenCyotekHomePage();
    }

    #endregion Private Methods
  }
}