namespace ScannerTest
{
  partial class MainForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.deviceComboBox = new System.Windows.Forms.ComboBox();
      this.showAcquisitionWizardButton = new System.Windows.Forms.Button();
      this.showAquireImageButton = new System.Windows.Forms.Button();
      this.showSelectDeviceButton = new System.Windows.Forms.Button();
      this.showSelectItemsButton = new System.Windows.Forms.Button();
      this.showDevicePropertiesButton = new System.Windows.Forms.Button();
      this.showItemPropertiesButton = new System.Windows.Forms.Button();
      this.showTransferButton = new System.Windows.Forms.Button();
      this.showPhotoPrintingWizardButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // deviceComboBox
      // 
      this.deviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.deviceComboBox.FormattingEnabled = true;
      this.deviceComboBox.Location = new System.Drawing.Point(32, 56);
      this.deviceComboBox.Name = "deviceComboBox";
      this.deviceComboBox.Size = new System.Drawing.Size(198, 21);
      this.deviceComboBox.TabIndex = 1;
      // 
      // showAcquisitionWizardButton
      // 
      this.showAcquisitionWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showAcquisitionWizardButton.Location = new System.Drawing.Point(6, 19);
      this.showAcquisitionWizardButton.Name = "showAcquisitionWizardButton";
      this.showAcquisitionWizardButton.Size = new System.Drawing.Size(219, 23);
      this.showAcquisitionWizardButton.TabIndex = 2;
      this.showAcquisitionWizardButton.Text = "Acquisition &Wizard...";
      this.showAcquisitionWizardButton.UseVisualStyleBackColor = true;
      this.showAcquisitionWizardButton.Click += new System.EventHandler(this.ShowAcquisitionWizardButton_Click);
      // 
      // showAquireImageButton
      // 
      this.showAquireImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showAquireImageButton.Location = new System.Drawing.Point(6, 48);
      this.showAquireImageButton.Name = "showAquireImageButton";
      this.showAquireImageButton.Size = new System.Drawing.Size(219, 23);
      this.showAquireImageButton.TabIndex = 3;
      this.showAquireImageButton.Text = "Acquire &Image...";
      this.showAquireImageButton.UseVisualStyleBackColor = true;
      this.showAquireImageButton.Click += new System.EventHandler(this.ShowAquireImageButton_Click);
      // 
      // showSelectDeviceButton
      // 
      this.showSelectDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showSelectDeviceButton.Location = new System.Drawing.Point(6, 77);
      this.showSelectDeviceButton.Name = "showSelectDeviceButton";
      this.showSelectDeviceButton.Size = new System.Drawing.Size(219, 23);
      this.showSelectDeviceButton.TabIndex = 4;
      this.showSelectDeviceButton.Text = "Select &Device...";
      this.showSelectDeviceButton.UseVisualStyleBackColor = true;
      this.showSelectDeviceButton.Click += new System.EventHandler(this.ShowSelectDeviceButton_Click);
      // 
      // showSelectItemsButton
      // 
      this.showSelectItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showSelectItemsButton.Location = new System.Drawing.Point(6, 164);
      this.showSelectItemsButton.Name = "showSelectItemsButton";
      this.showSelectItemsButton.Size = new System.Drawing.Size(219, 23);
      this.showSelectItemsButton.TabIndex = 5;
      this.showSelectItemsButton.Text = "&Select Items...";
      this.showSelectItemsButton.UseVisualStyleBackColor = true;
      this.showSelectItemsButton.Click += new System.EventHandler(this.ShowSelectItemsButton_Click);
      // 
      // showDevicePropertiesButton
      // 
      this.showDevicePropertiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showDevicePropertiesButton.Location = new System.Drawing.Point(6, 106);
      this.showDevicePropertiesButton.Name = "showDevicePropertiesButton";
      this.showDevicePropertiesButton.Size = new System.Drawing.Size(219, 23);
      this.showDevicePropertiesButton.TabIndex = 6;
      this.showDevicePropertiesButton.Text = "Device &Properties...";
      this.showDevicePropertiesButton.UseVisualStyleBackColor = true;
      this.showDevicePropertiesButton.Click += new System.EventHandler(this.ShowDevicePropertiesButton_Click);
      // 
      // showItemPropertiesButton
      // 
      this.showItemPropertiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showItemPropertiesButton.Location = new System.Drawing.Point(6, 135);
      this.showItemPropertiesButton.Name = "showItemPropertiesButton";
      this.showItemPropertiesButton.Size = new System.Drawing.Size(219, 23);
      this.showItemPropertiesButton.TabIndex = 7;
      this.showItemPropertiesButton.Text = "&Item Properties...";
      this.showItemPropertiesButton.UseVisualStyleBackColor = true;
      this.showItemPropertiesButton.Click += new System.EventHandler(this.ShowItemPropertiesButton_Click);
      // 
      // showTransferButton
      // 
      this.showTransferButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showTransferButton.Location = new System.Drawing.Point(6, 193);
      this.showTransferButton.Name = "showTransferButton";
      this.showTransferButton.Size = new System.Drawing.Size(219, 23);
      this.showTransferButton.TabIndex = 8;
      this.showTransferButton.Text = "&Transfer";
      this.showTransferButton.UseVisualStyleBackColor = true;
      this.showTransferButton.Click += new System.EventHandler(this.ShowTransferButton_Click);
      // 
      // showPhotoPrintingWizardButton
      // 
      this.showPhotoPrintingWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showPhotoPrintingWizardButton.Location = new System.Drawing.Point(6, 222);
      this.showPhotoPrintingWizardButton.Name = "showPhotoPrintingWizardButton";
      this.showPhotoPrintingWizardButton.Size = new System.Drawing.Size(219, 23);
      this.showPhotoPrintingWizardButton.TabIndex = 9;
      this.showPhotoPrintingWizardButton.Text = "P&hoto Printing Wizard...";
      this.showPhotoPrintingWizardButton.UseVisualStyleBackColor = true;
      this.showPhotoPrintingWizardButton.Click += new System.EventHandler(this.ShowPhotoPrintingWizardButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.showAcquisitionWizardButton);
      this.groupBox1.Controls.Add(this.showPhotoPrintingWizardButton);
      this.groupBox1.Controls.Add(this.showAquireImageButton);
      this.groupBox1.Controls.Add(this.showTransferButton);
      this.groupBox1.Controls.Add(this.showSelectDeviceButton);
      this.groupBox1.Controls.Add(this.showItemPropertiesButton);
      this.groupBox1.Controls.Add(this.showSelectItemsButton);
      this.groupBox1.Controls.Add(this.showDevicePropertiesButton);
      this.groupBox1.Location = new System.Drawing.Point(161, 115);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(231, 280);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Operations";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.deviceComboBox);
      this.Controls.Add(this.label1);
      this.Name = "MainForm";
      this.Text = "cyotek.com WIA Demonstration";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox deviceComboBox;
    private System.Windows.Forms.Button showAcquisitionWizardButton;
    private System.Windows.Forms.Button showAquireImageButton;
    private System.Windows.Forms.Button showSelectDeviceButton;
    private System.Windows.Forms.Button showSelectItemsButton;
    private System.Windows.Forms.Button showDevicePropertiesButton;
    private System.Windows.Forms.Button showItemPropertiesButton;
    private System.Windows.Forms.Button showTransferButton;
    private System.Windows.Forms.Button showPhotoPrintingWizardButton;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

