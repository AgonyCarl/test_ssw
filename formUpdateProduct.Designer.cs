namespace test_ssw
{
    partial class formUpdateProduct
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
            lblProductCode = new Label();
            lblProductSize = new Label();
            lblProductNumber = new Label();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtProductSize = new TextBox();
            txtProductNumber = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(74, 73);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(69, 20);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "产品名称";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(332, 73);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(69, 20);
            lblProductCode.TabIndex = 1;
            lblProductCode.Text = "产品编码";
            // 
            // lblProductSize
            // 
            lblProductSize.AutoSize = true;
            lblProductSize.Location = new Point(74, 159);
            lblProductSize.Name = "lblProductSize";
            lblProductSize.Size = new Size(69, 20);
            lblProductSize.TabIndex = 2;
            lblProductSize.Text = "产品规格";
            // 
            // lblProductNumber
            // 
            lblProductNumber.AutoSize = true;
            lblProductNumber.Location = new Point(333, 160);
            lblProductNumber.Name = "lblProductNumber";
            lblProductNumber.Size = new Size(69, 20);
            lblProductNumber.TabIndex = 3;
            lblProductNumber.Text = "产品数量";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(149, 70);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 4;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(407, 70);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(125, 27);
            txtProductCode.TabIndex = 5;
            // 
            // txtProductSize
            // 
            txtProductSize.Location = new Point(150, 157);
            txtProductSize.Name = "txtProductSize";
            txtProductSize.Size = new Size(125, 27);
            txtProductSize.TabIndex = 6;
            // 
            // txtProductNumber
            // 
            txtProductNumber.Location = new Point(407, 157);
            txtProductNumber.Name = "txtProductNumber";
            txtProductNumber.Size = new Size(125, 27);
            txtProductNumber.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Location = new Point(150, 254);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 52);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "确定";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(386, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 52);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // formUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 349);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtProductNumber);
            Controls.Add(txtProductSize);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(lblProductNumber);
            Controls.Add(lblProductSize);
            Controls.Add(lblProductCode);
            Controls.Add(lblProductName);
            Name = "formUpdateProduct";
            Text = "formUpdateProduct";
            Load += formUpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblProductCode;
        private Label lblProductSize;
        private Label lblProductNumber;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtProductSize;
        private TextBox txtProductNumber;
        private Button btnSubmit;
        private Button btnCancel;
    }
}