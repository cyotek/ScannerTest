namespace Cyotek.Demo.ScannerTest
{
  partial class PropertiesDialog
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listView = new System.Windows.Forms.ListView();
      this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.idColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.minColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.maxColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.stepColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.valuesColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.closeButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listView
      // 
      this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.idColumnHeader,
            this.valueColumnHeader,
            this.minColumnHeader,
            this.maxColumnHeader,
            this.stepColumnHeader,
            this.valuesColumnHeader});
      this.listView.FullRowSelect = true;
      this.listView.Location = new System.Drawing.Point(12, 12);
      this.listView.Name = "listView";
      this.listView.Size = new System.Drawing.Size(760, 508);
      this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.listView.TabIndex = 0;
      this.listView.UseCompatibleStateImageBehavior = false;
      this.listView.View = System.Windows.Forms.View.Details;
      // 
      // nameColumnHeader
      // 
      this.nameColumnHeader.Text = "Name";
      this.nameColumnHeader.Width = 180;
      // 
      // idColumnHeader
      // 
      this.idColumnHeader.Text = "ID";
      this.idColumnHeader.Width = 90;
      // 
      // valueColumnHeader
      // 
      this.valueColumnHeader.Text = "Value";
      this.valueColumnHeader.Width = 120;
      // 
      // minColumnHeader
      // 
      this.minColumnHeader.Text = "Minimum";
      // 
      // maxColumnHeader
      // 
      this.maxColumnHeader.Text = "Maximum";
      // 
      // stepColumnHeader
      // 
      this.stepColumnHeader.Text = "Step";
      // 
      // valuesColumnHeader
      // 
      this.valuesColumnHeader.Text = "Values";
      this.valuesColumnHeader.Width = 120;
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.closeButton.Location = new System.Drawing.Point(697, 526);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 1;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // PropertiesDialog
      // 
      this.AcceptButton = this.closeButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.closeButton;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.listView);
      this.Name = "PropertiesDialog";
      this.Text = "Properties";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.ColumnHeader nameColumnHeader;
    private System.Windows.Forms.ColumnHeader valueColumnHeader;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.ColumnHeader idColumnHeader;
    private System.Windows.Forms.ColumnHeader minColumnHeader;
    private System.Windows.Forms.ColumnHeader maxColumnHeader;
    private System.Windows.Forms.ColumnHeader valuesColumnHeader;
    private System.Windows.Forms.ColumnHeader stepColumnHeader;
  }
}