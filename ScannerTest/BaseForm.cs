using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Cyotek.Demo.ScannerTest
{
  internal class BaseForm : System.Windows.Forms.Form
  {
    #region Protected Constructors

    protected BaseForm()
    {
      base.MaximizeBox = false;
      base.MinimizeBox = false;
      base.ShowIcon = false;
      base.ShowInTaskbar = false;
      base.StartPosition = FormStartPosition.CenterParent;
      base.FormBorderStyle = FormBorderStyle.FixedDialog;
    }

    #endregion Protected Constructors

    #region Public Properties

    [DefaultValue(typeof(FormBorderStyle), "FixedDialog")]
    public new FormBorderStyle FormBorderStyle
    {
      get { return base.FormBorderStyle; }
      set { base.FormBorderStyle = value; }
    }

    [DefaultValue(false)]
    public new bool MaximizeBox
    {
      get { return base.MaximizeBox; }
      set { base.MaximizeBox = value; }
    }

    [DefaultValue(false)]
    public new bool MinimizeBox
    {
      get { return base.MinimizeBox; }
      set { base.MinimizeBox = value; }
    }

    [DefaultValue(false)]
    public new bool ShowIcon
    {
      get { return base.ShowIcon; }
      set { base.ShowIcon = value; }
    }

    [DefaultValue(false)]
    public new bool ShowInTaskbar
    {
      get { return base.ShowInTaskbar; }
      set { base.ShowInTaskbar = value; }
    }

    [DefaultValue(typeof(FormStartPosition), "CenterParent")]
    public new FormStartPosition StartPosition
    {
      get { return base.StartPosition; }
      set { base.StartPosition = value; }
    }

    #endregion Public Properties

    #region Protected Methods

    protected override void OnLoad(EventArgs e)
    {
      if (!this.DesignMode)
      {
        this.Font = SystemFonts.MessageBoxFont;
      }

      base.OnLoad(e);
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);

      Cursor.Current = Cursors.Default;
    }

    #endregion Protected Methods
  }
}