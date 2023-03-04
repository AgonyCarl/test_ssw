namespace test_ssw
{
    partial class formAddProduct
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
            lblProductName = new Label();
            btnCancel = new Button();
            lblProductCode = new Label();
            lblProductSize = new Label();
            lblProductNumber = new Label();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtProductSize = new TextBox();
            txtProductNumber = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(64, 57);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(69, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "产品名称";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(350, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 47);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(334, 54);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(69, 20);
            lblProductCode.TabIndex = 2;
            lblProductCode.Text = "产品编号";
            // 
            // lblProductSize
            // 
            lblProductSize.AutoSize = true;
            lblProductSize.Location = new Point(64, 134);
            lblProductSize.Name = "lblProductSize";
            lblProductSize.Size = new Size(69, 20);
            lblProductSize.TabIndex = 3;
            lblProductSize.Text = "产品规格";
            // 
            // lblProductNumber
            // 
            lblProductNumber.AutoSize = true;
            lblProductNumber.Location = new Point(334, 134);
            lblProductNumber.Name = "lblProductNumber";
            lblProductNumber.Size = new Size(69, 20);
            lblProductNumber.TabIndex = 4;
            lblProductNumber.Text = "产品数量";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(139, 54);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 5;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(409, 54);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(125, 27);
            txtProductCode.TabIndex = 6;
            // 
            // txtProductSize
            // 
            txtProductSize.Location = new Point(139, 131);
            txtProductSize.Name = "txtProductSize";
            txtProductSize.Size = new Size(125, 27);
            txtProductSize.TabIndex = 7;
            // 
            // txtProductNumber
            // 
            txtProductNumber.Location = new Point(409, 131);
            txtProductNumber.Name = "txtProductNumber";
            txtProductNumber.Size = new Size(125, 27);
            txtProductNumber.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Location = new Point(174, 215);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 47);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "确定";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // formAddProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 305);
            Controls.Add(btnSubmit);
            Controls.Add(txtProductNumber);
            Controls.Add(txtProductSize);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(lblProductNumber);
            Controls.Add(lblProductSize);
            Controls.Add(lblProductCode);
            Controls.Add(btnCancel);
            Controls.Add(lblProductName);
            Location = new Point(100, 300);
            Name = "formAddProduct";
            Text = "formAddProduct";
            Load += formAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Button btnCancel;
        private Label lblProductCode;
        private Label lblProductSize;
        private Label lblProductNumber;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtProductSize;
        private TextBox txtProductNumber;
        private Button btnSubmit;
    }
}