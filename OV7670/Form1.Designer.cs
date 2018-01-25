namespace OV7670
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.gbPicture = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.gbSerialConfig = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.lblCheckBits = new System.Windows.Forms.Label();
            this.cbbCheckBits = new System.Windows.Forms.ComboBox();
            this.lblBundRate = new System.Windows.Forms.Label();
            this.cbbBundRate = new System.Windows.Forms.ComboBox();
            this.lblSerialID = new System.Windows.Forms.Label();
            this.cbbSerialID = new System.Windows.Forms.ComboBox();
            this.gbPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbSerialConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPicture
            // 
            this.gbPicture.Controls.Add(this.pbImage);
            this.gbPicture.Location = new System.Drawing.Point(12, 12);
            this.gbPicture.Name = "gbPicture";
            this.gbPicture.Size = new System.Drawing.Size(572, 552);
            this.gbPicture.TabIndex = 0;
            this.gbPicture.TabStop = false;
            this.gbPicture.Text = "图像显示";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(15, 22);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(551, 521);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // gbSerialConfig
            // 
            this.gbSerialConfig.Controls.Add(this.btnOpen);
            this.gbSerialConfig.Controls.Add(this.btnSave);
            this.gbSerialConfig.Controls.Add(this.lblDataBits);
            this.gbSerialConfig.Controls.Add(this.cbbDataBits);
            this.gbSerialConfig.Controls.Add(this.lblStopBits);
            this.gbSerialConfig.Controls.Add(this.cbbStopBits);
            this.gbSerialConfig.Controls.Add(this.lblCheckBits);
            this.gbSerialConfig.Controls.Add(this.cbbCheckBits);
            this.gbSerialConfig.Controls.Add(this.lblBundRate);
            this.gbSerialConfig.Controls.Add(this.cbbBundRate);
            this.gbSerialConfig.Controls.Add(this.lblSerialID);
            this.gbSerialConfig.Controls.Add(this.cbbSerialID);
            this.gbSerialConfig.Location = new System.Drawing.Point(590, 12);
            this.gbSerialConfig.Name = "gbSerialConfig";
            this.gbSerialConfig.Size = new System.Drawing.Size(333, 552);
            this.gbSerialConfig.TabIndex = 1;
            this.gbSerialConfig.TabStop = false;
            this.gbSerialConfig.Text = "串口配置";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(24, 303);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 25);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存图像";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(21, 191);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(67, 15);
            this.lblDataBits.TabIndex = 10;
            this.lblDataBits.Text = "数据位：";
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.Location = new System.Drawing.Point(116, 188);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(121, 23);
            this.cbbDataBits.TabIndex = 9;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(21, 149);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(67, 15);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "停止位：";
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Location = new System.Drawing.Point(116, 146);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(121, 23);
            this.cbbStopBits.TabIndex = 7;
            // 
            // lblCheckBits
            // 
            this.lblCheckBits.AutoSize = true;
            this.lblCheckBits.Location = new System.Drawing.Point(21, 108);
            this.lblCheckBits.Name = "lblCheckBits";
            this.lblCheckBits.Size = new System.Drawing.Size(82, 15);
            this.lblCheckBits.TabIndex = 6;
            this.lblCheckBits.Text = "奇偶校验：";
            // 
            // cbbCheckBits
            // 
            this.cbbCheckBits.FormattingEnabled = true;
            this.cbbCheckBits.Location = new System.Drawing.Point(116, 105);
            this.cbbCheckBits.Name = "cbbCheckBits";
            this.cbbCheckBits.Size = new System.Drawing.Size(121, 23);
            this.cbbCheckBits.TabIndex = 5;
            // 
            // lblBundRate
            // 
            this.lblBundRate.AutoSize = true;
            this.lblBundRate.Location = new System.Drawing.Point(21, 68);
            this.lblBundRate.Name = "lblBundRate";
            this.lblBundRate.Size = new System.Drawing.Size(67, 15);
            this.lblBundRate.TabIndex = 4;
            this.lblBundRate.Text = "波特率：";
            // 
            // cbbBundRate
            // 
            this.cbbBundRate.FormattingEnabled = true;
            this.cbbBundRate.Location = new System.Drawing.Point(116, 65);
            this.cbbBundRate.Name = "cbbBundRate";
            this.cbbBundRate.Size = new System.Drawing.Size(121, 23);
            this.cbbBundRate.TabIndex = 3;
            // 
            // lblSerialID
            // 
            this.lblSerialID.AutoSize = true;
            this.lblSerialID.Location = new System.Drawing.Point(21, 29);
            this.lblSerialID.Name = "lblSerialID";
            this.lblSerialID.Size = new System.Drawing.Size(67, 15);
            this.lblSerialID.TabIndex = 2;
            this.lblSerialID.Text = "串口号：";
            // 
            // cbbSerialID
            // 
            this.cbbSerialID.FormattingEnabled = true;
            this.cbbSerialID.Location = new System.Drawing.Point(116, 26);
            this.cbbSerialID.Name = "cbbSerialID";
            this.cbbSerialID.Size = new System.Drawing.Size(121, 23);
            this.cbbSerialID.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 573);
            this.Controls.Add(this.gbSerialConfig);
            this.Controls.Add(this.gbPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "OV7670图像显示上位机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.gbPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbSerialConfig.ResumeLayout(false);
            this.gbSerialConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPicture;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox gbSerialConfig;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label lblCheckBits;
        private System.Windows.Forms.ComboBox cbbCheckBits;
        private System.Windows.Forms.Label lblBundRate;
        private System.Windows.Forms.ComboBox cbbBundRate;
        private System.Windows.Forms.Label lblSerialID;
        private System.Windows.Forms.ComboBox cbbSerialID;
    }
}

