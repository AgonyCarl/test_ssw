namespace test_ssw
{
    partial class formProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtProductSize = new TextBox();
            btnSearch = new Button();
            productData = new DataGridView();
            btnReset = new Button();
            lblProductName = new Label();
            lblProductCode = new Label();
            lblProductSize = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBoxLeft = new GroupBox();
            groupBoxTop = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            groupBoxLeft.SuspendLayout();
            groupBoxTop.SuspendLayout();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(87, 36);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "请输入产品名称";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(303, 36);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PlaceholderText = "请输入产品编号";
            txtProductCode.Size = new Size(125, 27);
            txtProductCode.TabIndex = 6;
            // 
            // txtProductSize
            // 
            txtProductSize.Location = new Point(519, 36);
            txtProductSize.Name = "txtProductSize";
            txtProductSize.PlaceholderText = "请输入产品规格";
            txtProductSize.Size = new Size(125, 27);
            txtProductSize.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.Desktop;
            btnSearch.Location = new Point(677, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 45);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // productData
            // 
            productData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productData.Location = new Point(12, 118);
            productData.Name = "productData";
            productData.RowHeadersWidth = 51;
            productData.RowTemplate.Height = 29;
            productData.Size = new Size(701, 394);
            productData.TabIndex = 9;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(802, 26);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 45);
            btnReset.TabIndex = 10;
            btnReset.Text = "重置";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 40);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(69, 20);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "产品名称";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(228, 40);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(69, 20);
            lblProductCode.TabIndex = 12;
            lblProductCode.Text = "产品编号";
            // 
            // lblProductSize
            // 
            lblProductSize.AutoSize = true;
            lblProductSize.Location = new Point(444, 40);
            lblProductSize.Name = "lblProductSize";
            lblProductSize.Size = new Size(69, 20);
            lblProductSize.TabIndex = 13;
            lblProductSize.Text = "产品规格";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.Desktop;
            btnAdd.Location = new Point(39, 49);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 45);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Desktop;
            btnDelete.Location = new Point(39, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Desktop;
            btnUpdate.Location = new Point(39, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 45);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "修改";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBoxLeft
            // 
            groupBoxLeft.Controls.Add(btnAdd);
            groupBoxLeft.Controls.Add(btnDelete);
            groupBoxLeft.Controls.Add(btnUpdate);
            groupBoxLeft.Location = new Point(736, 142);
            groupBoxLeft.Name = "groupBoxLeft";
            groupBoxLeft.Size = new Size(182, 325);
            groupBoxLeft.TabIndex = 17;
            groupBoxLeft.TabStop = false;
            groupBoxLeft.Text = "操作栏";
            // 
            // groupBoxTop
            // 
            groupBoxTop.Controls.Add(btnSearch);
            groupBoxTop.Controls.Add(txtProductName);
            groupBoxTop.Controls.Add(lblProductSize);
            groupBoxTop.Controls.Add(txtProductCode);
            groupBoxTop.Controls.Add(lblProductCode);
            groupBoxTop.Controls.Add(txtProductSize);
            groupBoxTop.Controls.Add(lblProductName);
            groupBoxTop.Controls.Add(btnReset);
            groupBoxTop.Location = new Point(12, 12);
            groupBoxTop.Name = "groupBoxTop";
            groupBoxTop.Size = new Size(922, 84);
            groupBoxTop.TabIndex = 18;
            groupBoxTop.TabStop = false;
            groupBoxTop.Text = "搜索栏";
            // 
            // formProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 522);
            Controls.Add(groupBoxTop);
            Controls.Add(groupBoxLeft);
            Controls.Add(productData);
            Name = "formProduct";
            Text = "产品管理";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productData).EndInit();
            groupBoxLeft.ResumeLayout(false);
            groupBoxTop.ResumeLayout(false);
            groupBoxTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtProductSize;
        private Button btnSearch;
        private DataGridView productData;
        private Button btnReset;
        private Label lblProductName;
        private Label lblProductCode;
        private Label lblProductSize;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBoxLeft;
        private GroupBox groupBoxTop;
    }
}