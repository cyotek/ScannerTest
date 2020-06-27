namespace Cyotek.Demo.ScannerTest
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
      System.Windows.Forms.GroupBox printingGroupBox;
      System.Windows.Forms.GroupBox deviceGroupBox;
      System.Windows.Forms.GroupBox imageGroupBox;
      System.Windows.Forms.GroupBox itemsGroupBox;
      System.Windows.Forms.SplitContainer splitContainer;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label2 = new System.Windows.Forms.Label();
      this.showPhotoPrintingWizardButton = new System.Windows.Forms.Button();
      this.filesListBox = new System.Windows.Forms.ListBox();
      this.deviceItemPropertiesLinkLabel = new System.Windows.Forms.LinkLabel();
      this.showDevicePropertiesLinkLabel = new System.Windows.Forms.LinkLabel();
      this.deviceComboBox = new System.Windows.Forms.ComboBox();
      this.showSelectDeviceButton = new System.Windows.Forms.Button();
      this.showTransferSelectedButton = new System.Windows.Forms.Button();
      this.previewImageBox = new Cyotek.Windows.Forms.ImageBox();
      this.showAcquisitionWizardButton = new System.Windows.Forms.Button();
      this.showAquireImageButton = new System.Windows.Forms.Button();
      this.showTransferButton = new System.Windows.Forms.Button();
      this.itemPropertiesLinkLabel = new System.Windows.Forms.LinkLabel();
      this.showItemPropertiesButton = new System.Windows.Forms.Button();
      this.showSelectItemsButton = new System.Windows.Forms.Button();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deviceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.allDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.camerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.refreshDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.cyotekWebLinkToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      printingGroupBox = new System.Windows.Forms.GroupBox();
      deviceGroupBox = new System.Windows.Forms.GroupBox();
      imageGroupBox = new System.Windows.Forms.GroupBox();
      itemsGroupBox = new System.Windows.Forms.GroupBox();
      splitContainer = new System.Windows.Forms.SplitContainer();
      printingGroupBox.SuspendLayout();
      deviceGroupBox.SuspendLayout();
      imageGroupBox.SuspendLayout();
      itemsGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
      splitContainer.Panel1.SuspendLayout();
      splitContainer.Panel2.SuspendLayout();
      splitContainer.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // printingGroupBox
      // 
      printingGroupBox.Controls.Add(this.label2);
      printingGroupBox.Controls.Add(this.showPhotoPrintingWizardButton);
      printingGroupBox.Controls.Add(this.filesListBox);
      printingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      printingGroupBox.Location = new System.Drawing.Point(0, 184);
      printingGroupBox.Name = "printingGroupBox";
      printingGroupBox.Size = new System.Drawing.Size(384, 220);
      printingGroupBox.TabIndex = 2;
      printingGroupBox.TabStop = false;
      printingGroupBox.Text = "Printing";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(151, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Select one or more i&mage files:";
      // 
      // showPhotoPrintingWizardButton
      // 
      this.showPhotoPrintingWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.showPhotoPrintingWizardButton.Location = new System.Drawing.Point(6, 191);
      this.showPhotoPrintingWizardButton.Name = "showPhotoPrintingWizardButton";
      this.showPhotoPrintingWizardButton.Size = new System.Drawing.Size(219, 23);
      this.showPhotoPrintingWizardButton.TabIndex = 2;
      this.showPhotoPrintingWizardButton.Text = "&Photo Printing Wizard...";
      this.showPhotoPrintingWizardButton.UseVisualStyleBackColor = true;
      this.showPhotoPrintingWizardButton.Click += new System.EventHandler(this.ShowPhotoPrintingWizardButton_Click);
      // 
      // filesListBox
      // 
      this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.filesListBox.FormattingEnabled = true;
      this.filesListBox.HorizontalScrollbar = true;
      this.filesListBox.IntegralHeight = false;
      this.filesListBox.Location = new System.Drawing.Point(6, 32);
      this.filesListBox.Name = "filesListBox";
      this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.filesListBox.Size = new System.Drawing.Size(372, 153);
      this.filesListBox.TabIndex = 1;
      // 
      // deviceGroupBox
      // 
      deviceGroupBox.Controls.Add(this.deviceItemPropertiesLinkLabel);
      deviceGroupBox.Controls.Add(this.showDevicePropertiesLinkLabel);
      deviceGroupBox.Controls.Add(this.deviceComboBox);
      deviceGroupBox.Controls.Add(this.showSelectDeviceButton);
      deviceGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
      deviceGroupBox.Location = new System.Drawing.Point(0, 0);
      deviceGroupBox.Name = "deviceGroupBox";
      deviceGroupBox.Size = new System.Drawing.Size(384, 92);
      deviceGroupBox.TabIndex = 0;
      deviceGroupBox.TabStop = false;
      deviceGroupBox.Text = "&Device:";
      // 
      // deviceItemPropertiesLinkLabel
      // 
      this.deviceItemPropertiesLinkLabel.AutoSize = true;
      this.deviceItemPropertiesLinkLabel.Location = new System.Drawing.Point(3, 67);
      this.deviceItemPropertiesLinkLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
      this.deviceItemPropertiesLinkLabel.Name = "deviceItemPropertiesLinkLabel";
      this.deviceItemPropertiesLinkLabel.Size = new System.Drawing.Size(136, 13);
      this.deviceItemPropertiesLinkLabel.TabIndex = 3;
      this.deviceItemPropertiesLinkLabel.TabStop = true;
      this.deviceItemPropertiesLinkLabel.Text = "View device item properties";
      this.deviceItemPropertiesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeviceItemPropertiesLinkLabel_LinkClicked);
      // 
      // showDevicePropertiesLinkLabel
      // 
      this.showDevicePropertiesLinkLabel.AutoSize = true;
      this.showDevicePropertiesLinkLabel.Location = new System.Drawing.Point(3, 48);
      this.showDevicePropertiesLinkLabel.Name = "showDevicePropertiesLinkLabel";
      this.showDevicePropertiesLinkLabel.Size = new System.Drawing.Size(146, 13);
      this.showDevicePropertiesLinkLabel.TabIndex = 2;
      this.showDevicePropertiesLinkLabel.TabStop = true;
      this.showDevicePropertiesLinkLabel.Text = "View native device properties";
      this.showDevicePropertiesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowDevicePropertiesLinkLabel_LinkClicked);
      // 
      // deviceComboBox
      // 
      this.deviceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.deviceComboBox.FormattingEnabled = true;
      this.deviceComboBox.Location = new System.Drawing.Point(6, 21);
      this.deviceComboBox.Name = "deviceComboBox";
      this.deviceComboBox.Size = new System.Drawing.Size(291, 21);
      this.deviceComboBox.TabIndex = 0;
      this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceComboBox_SelectedIndexChanged);
      // 
      // showSelectDeviceButton
      // 
      this.showSelectDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.showSelectDeviceButton.Location = new System.Drawing.Point(303, 19);
      this.showSelectDeviceButton.Name = "showSelectDeviceButton";
      this.showSelectDeviceButton.Size = new System.Drawing.Size(75, 23);
      this.showSelectDeviceButton.TabIndex = 1;
      this.showSelectDeviceButton.Text = "&Browse...";
      this.showSelectDeviceButton.UseVisualStyleBackColor = true;
      this.showSelectDeviceButton.Click += new System.EventHandler(this.ShowSelectDeviceButton_Click);
      // 
      // imageGroupBox
      // 
      imageGroupBox.Controls.Add(this.showTransferSelectedButton);
      imageGroupBox.Controls.Add(this.previewImageBox);
      imageGroupBox.Controls.Add(this.showAcquisitionWizardButton);
      imageGroupBox.Controls.Add(this.showAquireImageButton);
      imageGroupBox.Controls.Add(this.showTransferButton);
      imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      imageGroupBox.Location = new System.Drawing.Point(0, 0);
      imageGroupBox.Name = "imageGroupBox";
      imageGroupBox.Size = new System.Drawing.Size(412, 404);
      imageGroupBox.TabIndex = 0;
      imageGroupBox.TabStop = false;
      imageGroupBox.Text = "Image Aquisition";
      // 
      // showTransferSelectedButton
      // 
      this.showTransferSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showTransferSelectedButton.Location = new System.Drawing.Point(206, 77);
      this.showTransferSelectedButton.Name = "showTransferSelectedButton";
      this.showTransferSelectedButton.Size = new System.Drawing.Size(175, 23);
      this.showTransferSelectedButton.TabIndex = 4;
      this.showTransferSelectedButton.Text = "Transfer (Selected Item)";
      this.showTransferSelectedButton.UseVisualStyleBackColor = true;
      this.showTransferSelectedButton.Click += new System.EventHandler(this.ShowTransferSelectedButton_Click);
      // 
      // previewImageBox
      // 
      this.previewImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.previewImageBox.Location = new System.Drawing.Point(9, 106);
      this.previewImageBox.Name = "previewImageBox";
      this.previewImageBox.Size = new System.Drawing.Size(394, 292);
      this.previewImageBox.TabIndex = 3;
      // 
      // showAcquisitionWizardButton
      // 
      this.showAcquisitionWizardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showAcquisitionWizardButton.Location = new System.Drawing.Point(6, 19);
      this.showAcquisitionWizardButton.Name = "showAcquisitionWizardButton";
      this.showAcquisitionWizardButton.Size = new System.Drawing.Size(400, 23);
      this.showAcquisitionWizardButton.TabIndex = 0;
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
      this.showAquireImageButton.Size = new System.Drawing.Size(400, 23);
      this.showAquireImageButton.TabIndex = 1;
      this.showAquireImageButton.Text = "Acquire &Image...";
      this.showAquireImageButton.UseVisualStyleBackColor = true;
      this.showAquireImageButton.Click += new System.EventHandler(this.ShowAquireImageButton_Click);
      // 
      // showTransferButton
      // 
      this.showTransferButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showTransferButton.Location = new System.Drawing.Point(6, 77);
      this.showTransferButton.Name = "showTransferButton";
      this.showTransferButton.Size = new System.Drawing.Size(175, 23);
      this.showTransferButton.TabIndex = 2;
      this.showTransferButton.Text = "&Transfer (Default)";
      this.showTransferButton.UseVisualStyleBackColor = true;
      this.showTransferButton.Click += new System.EventHandler(this.ShowTransferButton_Click);
      // 
      // itemsGroupBox
      // 
      itemsGroupBox.Controls.Add(this.itemPropertiesLinkLabel);
      itemsGroupBox.Controls.Add(this.showItemPropertiesButton);
      itemsGroupBox.Controls.Add(this.showSelectItemsButton);
      itemsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
      itemsGroupBox.Location = new System.Drawing.Point(0, 92);
      itemsGroupBox.Name = "itemsGroupBox";
      itemsGroupBox.Size = new System.Drawing.Size(384, 92);
      itemsGroupBox.TabIndex = 1;
      itemsGroupBox.TabStop = false;
      itemsGroupBox.Text = "Items";
      // 
      // itemPropertiesLinkLabel
      // 
      this.itemPropertiesLinkLabel.AutoSize = true;
      this.itemPropertiesLinkLabel.Location = new System.Drawing.Point(12, 51);
      this.itemPropertiesLinkLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
      this.itemPropertiesLinkLabel.Name = "itemPropertiesLinkLabel";
      this.itemPropertiesLinkLabel.Size = new System.Drawing.Size(101, 13);
      this.itemPropertiesLinkLabel.TabIndex = 4;
      this.itemPropertiesLinkLabel.TabStop = true;
      this.itemPropertiesLinkLabel.Text = "View item properties";
      this.itemPropertiesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ItemPropertiesLinkLabel_LinkClicked);
      // 
      // showItemPropertiesButton
      // 
      this.showItemPropertiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showItemPropertiesButton.Location = new System.Drawing.Point(106, 19);
      this.showItemPropertiesButton.Name = "showItemPropertiesButton";
      this.showItemPropertiesButton.Size = new System.Drawing.Size(88, 23);
      this.showItemPropertiesButton.TabIndex = 1;
      this.showItemPropertiesButton.Text = "Propert&ies...";
      this.showItemPropertiesButton.UseVisualStyleBackColor = true;
      this.showItemPropertiesButton.Click += new System.EventHandler(this.ShowItemPropertiesButton_Click);
      // 
      // showSelectItemsButton
      // 
      this.showSelectItemsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.showSelectItemsButton.Location = new System.Drawing.Point(12, 19);
      this.showSelectItemsButton.Name = "showSelectItemsButton";
      this.showSelectItemsButton.Size = new System.Drawing.Size(88, 23);
      this.showSelectItemsButton.TabIndex = 0;
      this.showSelectItemsButton.Text = "&Select Items...";
      this.showSelectItemsButton.UseVisualStyleBackColor = true;
      this.showSelectItemsButton.Click += new System.EventHandler(this.ShowSelectItemsButton_Click);
      // 
      // splitContainer
      // 
      splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      splitContainer.Location = new System.Drawing.Point(0, 24);
      splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      splitContainer.Panel1.Controls.Add(printingGroupBox);
      splitContainer.Panel1.Controls.Add(itemsGroupBox);
      splitContainer.Panel1.Controls.Add(deviceGroupBox);
      // 
      // splitContainer.Panel2
      // 
      splitContainer.Panel2.Controls.Add(imageGroupBox);
      splitContainer.Size = new System.Drawing.Size(800, 404);
      splitContainer.SplitterDistance = 384;
      splitContainer.TabIndex = 1;
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(800, 24);
      this.menuStrip.TabIndex = 0;
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceTypeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.refreshDevicesToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // deviceTypeToolStripMenuItem
      // 
      this.deviceTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDevicesToolStripMenuItem,
            this.scannersToolStripMenuItem,
            this.camerasToolStripMenuItem,
            this.videoToolStripMenuItem});
      this.deviceTypeToolStripMenuItem.Name = "deviceTypeToolStripMenuItem";
      this.deviceTypeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
      this.deviceTypeToolStripMenuItem.Text = "&Device Type";
      // 
      // allDevicesToolStripMenuItem
      // 
      this.allDevicesToolStripMenuItem.Name = "allDevicesToolStripMenuItem";
      this.allDevicesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.allDevicesToolStripMenuItem.Text = "&All";
      this.allDevicesToolStripMenuItem.Click += new System.EventHandler(this.AllDevicesToolStripMenuItem_Click);
      // 
      // scannersToolStripMenuItem
      // 
      this.scannersToolStripMenuItem.Name = "scannersToolStripMenuItem";
      this.scannersToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.scannersToolStripMenuItem.Text = "&Scanners";
      this.scannersToolStripMenuItem.Click += new System.EventHandler(this.ScannersToolStripMenuItem_Click);
      // 
      // camerasToolStripMenuItem
      // 
      this.camerasToolStripMenuItem.Name = "camerasToolStripMenuItem";
      this.camerasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.camerasToolStripMenuItem.Text = "&Cameras";
      this.camerasToolStripMenuItem.Click += new System.EventHandler(this.CamerasToolStripMenuItem_Click);
      // 
      // videoToolStripMenuItem
      // 
      this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
      this.videoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.videoToolStripMenuItem.Text = "&Video";
      this.videoToolStripMenuItem.Click += new System.EventHandler(this.VideoToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
      // 
      // refreshDevicesToolStripMenuItem
      // 
      this.refreshDevicesToolStripMenuItem.Name = "refreshDevicesToolStripMenuItem";
      this.refreshDevicesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
      this.refreshDevicesToolStripMenuItem.Text = "&Refresh Devices";
      this.refreshDevicesToolStripMenuItem.Click += new System.EventHandler(this.RefreshDevicesToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "&About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.cyotekWebLinkToolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 428);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(800, 22);
      this.statusStrip.TabIndex = 2;
      // 
      // statusToolStripStatusLabel
      // 
      this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
      this.statusToolStripStatusLabel.Size = new System.Drawing.Size(655, 17);
      this.statusToolStripStatusLabel.Spring = true;
      this.statusToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cyotekWebLinkToolStripStatusLabel
      // 
      this.cyotekWebLinkToolStripStatusLabel.IsLink = true;
      this.cyotekWebLinkToolStripStatusLabel.Name = "cyotekWebLinkToolStripStatusLabel";
      this.cyotekWebLinkToolStripStatusLabel.Size = new System.Drawing.Size(99, 17);
      this.cyotekWebLinkToolStripStatusLabel.Text = "www.cyotek.com";
      this.cyotekWebLinkToolStripStatusLabel.Click += new System.EventHandler(this.CyotekWebLinkToolStripStatusLabel_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(splitContainer);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.menuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip;
      this.MaximizeBox = true;
      this.MinimizeBox = true;
      this.Name = "MainForm";
      this.ShowIcon = true;
      this.ShowInTaskbar = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
      this.Text = "cyotek.com WIA Demonstration";
      printingGroupBox.ResumeLayout(false);
      printingGroupBox.PerformLayout();
      deviceGroupBox.ResumeLayout(false);
      deviceGroupBox.PerformLayout();
      imageGroupBox.ResumeLayout(false);
      itemsGroupBox.ResumeLayout(false);
      itemsGroupBox.PerformLayout();
      splitContainer.Panel1.ResumeLayout(false);
      splitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
      splitContainer.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    
    private System.Windows.Forms.ComboBox deviceComboBox;
    private System.Windows.Forms.Button showAcquisitionWizardButton;
    private System.Windows.Forms.Button showAquireImageButton;
    private System.Windows.Forms.Button showSelectDeviceButton;
    private System.Windows.Forms.Button showSelectItemsButton;
    private System.Windows.Forms.Button showItemPropertiesButton;
    private System.Windows.Forms.Button showTransferButton;
    private System.Windows.Forms.Button showPhotoPrintingWizardButton;
    private System.Windows.Forms.ListBox filesListBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem refreshDevicesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
    private System.Windows.Forms.ToolStripStatusLabel cyotekWebLinkToolStripStatusLabel;
    private System.Windows.Forms.LinkLabel showDevicePropertiesLinkLabel;
    private Cyotek.Windows.Forms.ImageBox previewImageBox;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem allDevicesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem scannersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem camerasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
    private System.Windows.Forms.LinkLabel deviceItemPropertiesLinkLabel;
    private System.Windows.Forms.ToolStripMenuItem deviceTypeToolStripMenuItem;
    private System.Windows.Forms.LinkLabel itemPropertiesLinkLabel;
    private System.Windows.Forms.Button showTransferSelectedButton;
  }
}

