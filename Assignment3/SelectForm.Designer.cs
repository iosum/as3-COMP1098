namespace Assignment3
{
    partial class SelectForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productContext = new Assignment3.ProductContext();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Assignment3.ProductContextTableAdapters.ProductsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webCamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.selectionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Computer Hardware Lists";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.mFGDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.lCDSizeDataGridViewTextBoxColumn,
            this.cPUBrandDataGridViewTextBoxColumn,
            this.cPUTypeDataGridViewTextBoxColumn,
            this.cPUNumberDataGridViewTextBoxColumn,
            this.cPUSpeedDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.hDDDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.webCamDataGridViewTextBoxColumn});
            this.productDataGridView.DataSource = this.productsBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(47, 82);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 31;
            this.productDataGridView.Size = new System.Drawing.Size(800, 400);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            this.productDataGridView.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // productContext
            // 
            this.productContext.DataSetName = "ProductContext";
            this.productContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productContext;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 63;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 83;
            // 
            // mFGDataGridViewTextBoxColumn
            // 
            this.mFGDataGridViewTextBoxColumn.DataPropertyName = "MFG";
            this.mFGDataGridViewTextBoxColumn.HeaderText = "MFG";
            this.mFGDataGridViewTextBoxColumn.Name = "mFGDataGridViewTextBoxColumn";
            this.mFGDataGridViewTextBoxColumn.Width = 85;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 94;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.Width = 109;
            // 
            // lCDSizeDataGridViewTextBoxColumn
            // 
            this.lCDSizeDataGridViewTextBoxColumn.DataPropertyName = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.HeaderText = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.Name = "lCDSizeDataGridViewTextBoxColumn";
            this.lCDSizeDataGridViewTextBoxColumn.Width = 116;
            // 
            // cPUBrandDataGridViewTextBoxColumn
            // 
            this.cPUBrandDataGridViewTextBoxColumn.DataPropertyName = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.HeaderText = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.Name = "cPUBrandDataGridViewTextBoxColumn";
            this.cPUBrandDataGridViewTextBoxColumn.Width = 132;
            // 
            // cPUTypeDataGridViewTextBoxColumn
            // 
            this.cPUTypeDataGridViewTextBoxColumn.DataPropertyName = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.HeaderText = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.Name = "cPUTypeDataGridViewTextBoxColumn";
            this.cPUTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUNumberDataGridViewTextBoxColumn
            // 
            this.cPUNumberDataGridViewTextBoxColumn.DataPropertyName = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.HeaderText = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.Name = "cPUNumberDataGridViewTextBoxColumn";
            this.cPUNumberDataGridViewTextBoxColumn.Width = 147;
            // 
            // cPUSpeedDataGridViewTextBoxColumn
            // 
            this.cPUSpeedDataGridViewTextBoxColumn.DataPropertyName = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.HeaderText = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.Name = "cPUSpeedDataGridViewTextBoxColumn";
            this.cPUSpeedDataGridViewTextBoxColumn.Width = 136;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.Width = 122;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.Width = 112;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.Width = 72;
            // 
            // hDDDataGridViewTextBoxColumn
            // 
            this.hDDDataGridViewTextBoxColumn.DataPropertyName = "HDD";
            this.hDDDataGridViewTextBoxColumn.HeaderText = "HDD";
            this.hDDDataGridViewTextBoxColumn.Name = "hDDDataGridViewTextBoxColumn";
            this.hDDDataGridViewTextBoxColumn.Width = 85;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.Width = 126;
            // 
            // webCamDataGridViewTextBoxColumn
            // 
            this.webCamDataGridViewTextBoxColumn.DataPropertyName = "WebCam";
            this.webCamDataGridViewTextBoxColumn.HeaderText = "WebCam";
            this.webCamDataGridViewTextBoxColumn.Name = "webCamDataGridViewTextBoxColumn";
            this.webCamDataGridViewTextBoxColumn.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Selection";
            // 
            // selectionTextBox
            // 
            this.selectionTextBox.Location = new System.Drawing.Point(218, 545);
            this.selectionTextBox.Name = "selectionTextBox";
            this.selectionTextBox.ReadOnly = true;
            this.selectionTextBox.Size = new System.Drawing.Size(629, 28);
            this.selectionTextBox.TabIndex = 3;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1074, 605);
            this.Controls.Add(this.selectionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private ProductContext productContext;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductContextTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webCamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectionTextBox;
    }
}