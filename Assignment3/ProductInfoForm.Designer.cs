namespace Assignment3
{
    partial class ProductInfoForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.productInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.lcdSizeTextBox = new System.Windows.Forms.TextBox();
            this.cpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpuTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.webCamTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.selectAnotherProductButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.productInfoFormMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // productInfoFormMenuStrip
            // 
            this.productInfoFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.productInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.productInfoFormMenuStrip.Name = "productInfoFormMenuStrip";
            this.productInfoFormMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.productInfoFormMenuStrip.Size = new System.Drawing.Size(959, 30);
            this.productInfoFormMenuStrip.TabIndex = 0;
            this.productInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(178, 73);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 28);
            this.productIdTextBox.TabIndex = 4;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(418, 73);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(100, 28);
            this.conditionTextBox.TabIndex = 5;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(645, 73);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 28);
            this.costTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modelTextBox);
            this.groupBox1.Controls.Add(this.osTextBox);
            this.groupBox1.Controls.Add(this.manufacturerTextBox);
            this.groupBox1.Controls.Add(this.platformTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(58, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Platform";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "OS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Model";
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(150, 48);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(100, 28);
            this.platformTextBox.TabIndex = 4;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(150, 82);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(100, 28);
            this.manufacturerTextBox.TabIndex = 5;
            // 
            // osTextBox
            // 
            this.osTextBox.Location = new System.Drawing.Point(398, 48);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(289, 28);
            this.osTextBox.TabIndex = 6;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(398, 85);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(289, 28);
            this.modelTextBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webCamTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.gpuTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.hddTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cpuSpeedTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cpuTypeTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cpuNumberTextBox);
            this.groupBox2.Controls.Add(this.lcdSizeTextBox);
            this.groupBox2.Controls.Add(this.cpuBrandTextBox);
            this.groupBox2.Controls.Add(this.memoryTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(58, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Info";
            // 
            // cpuNumberTextBox
            // 
            this.cpuNumberTextBox.Location = new System.Drawing.Point(420, 85);
            this.cpuNumberTextBox.Name = "cpuNumberTextBox";
            this.cpuNumberTextBox.Size = new System.Drawing.Size(100, 28);
            this.cpuNumberTextBox.TabIndex = 7;
            // 
            // lcdSizeTextBox
            // 
            this.lcdSizeTextBox.Location = new System.Drawing.Point(420, 48);
            this.lcdSizeTextBox.Name = "lcdSizeTextBox";
            this.lcdSizeTextBox.Size = new System.Drawing.Size(100, 28);
            this.lcdSizeTextBox.TabIndex = 6;
            // 
            // cpuBrandTextBox
            // 
            this.cpuBrandTextBox.Location = new System.Drawing.Point(150, 82);
            this.cpuBrandTextBox.Name = "cpuBrandTextBox";
            this.cpuBrandTextBox.Size = new System.Drawing.Size(100, 28);
            this.cpuBrandTextBox.TabIndex = 5;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.Location = new System.Drawing.Point(150, 48);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(100, 28);
            this.memoryTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "CPU Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "LCD Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPU Brand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Memory";
            // 
            // cpuTypeTextBox
            // 
            this.cpuTypeTextBox.Location = new System.Drawing.Point(150, 122);
            this.cpuTypeTextBox.Name = "cpuTypeTextBox";
            this.cpuTypeTextBox.Size = new System.Drawing.Size(100, 28);
            this.cpuTypeTextBox.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "CPU Type";
            // 
            // cpuSpeedTextBox
            // 
            this.cpuSpeedTextBox.Location = new System.Drawing.Point(420, 122);
            this.cpuSpeedTextBox.Name = "cpuSpeedTextBox";
            this.cpuSpeedTextBox.Size = new System.Drawing.Size(100, 28);
            this.cpuSpeedTextBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "CPU Speed";
            // 
            // hddTextBox
            // 
            this.hddTextBox.Location = new System.Drawing.Point(656, 42);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(100, 28);
            this.hddTextBox.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(549, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "HDD";
            // 
            // gpuTextBox
            // 
            this.gpuTextBox.Location = new System.Drawing.Point(656, 78);
            this.gpuTextBox.Name = "gpuTextBox";
            this.gpuTextBox.Size = new System.Drawing.Size(100, 28);
            this.gpuTextBox.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(549, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 14;
            this.label15.Text = "GPU Type";
            // 
            // webCamTextBox
            // 
            this.webCamTextBox.Location = new System.Drawing.Point(656, 116);
            this.webCamTextBox.Name = "webCamTextBox";
            this.webCamTextBox.Size = new System.Drawing.Size(100, 28);
            this.webCamTextBox.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(549, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 22);
            this.label16.TabIndex = 16;
            this.label16.Text = "WebCam";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(693, 504);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 50);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Tag = "Cancel";
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ProductInfoForm_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(818, 504);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(107, 50);
            this.nextButton.TabIndex = 10;
            this.nextButton.Tag = "Next";
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.ProductInfoForm_Click);
            // 
            // selectAnotherProductButton
            // 
            this.selectAnotherProductButton.Location = new System.Drawing.Point(394, 504);
            this.selectAnotherProductButton.Name = "selectAnotherProductButton";
            this.selectAnotherProductButton.Size = new System.Drawing.Size(283, 50);
            this.selectAnotherProductButton.TabIndex = 11;
            this.selectAnotherProductButton.Tag = "Another";
            this.selectAnotherProductButton.Text = "Select Another Product";
            this.selectAnotherProductButton.UseVisualStyleBackColor = true;
            this.selectAnotherProductButton.Click += new System.EventHandler(this.ProductInfoForm_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 518);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 22);
            this.label17.TabIndex = 12;
            this.label17.Text = "Click Next to Confirm Your Selection";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Product.txt";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 583);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.selectAnotherProductButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productInfoFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.productInfoFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Click += new System.EventHandler(this.ProductInfoForm_Click);
            this.productInfoFormMenuStrip.ResumeLayout(false);
            this.productInfoFormMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip productInfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox webCamTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox gpuTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cpuSpeedTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cpuTypeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cpuNumberTextBox;
        private System.Windows.Forms.TextBox lcdSizeTextBox;
        private System.Windows.Forms.TextBox cpuBrandTextBox;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button selectAnotherProductButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}