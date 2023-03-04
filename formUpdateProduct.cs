using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_ssw
{
    public partial class formUpdateProduct : Form
    {
        private Product product;
        public formUpdateProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void formUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductName.Text = product.Name;
            txtProductCode.Text = product.Code;
            txtProductSize.Text = product.Size;
            txtProductNumber.Text = product.Number.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("产品名称不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (String.IsNullOrEmpty(txtProductCode.Text))
            {
                MessageBox.Show("产品编码不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (String.IsNullOrEmpty(txtProductSize.Text))
            {
                MessageBox.Show("产品规格不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (String.IsNullOrEmpty(txtProductNumber.Text))
            {
                MessageBox.Show("产品数量不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(txtProductNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("产品数量必须为>0的数字！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=yourpwd;allowuservariables=True;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                String sqlForSelect = String.Format("select id from product where name = '{0}'", product.Name);
                MySqlCommand cmd = new MySqlCommand(sqlForSelect, conn);
                int id = int.Parse(cmd.ExecuteScalar().ToString());
                String sqlForUpdate = String.Format("update product set name = '{0}', code = '{1}', size = '{2}', number = {3} where id = {4}",
    txtProductName.Text, txtProductCode.Text, txtProductSize.Text, int.Parse(txtProductNumber.Text), id);
                cmd = new MySqlCommand(sqlForUpdate, conn);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    DialogResult msg = MessageBox.Show("更新成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (msg == DialogResult.OK)
                    {
                        formProduct product = new formProduct();
                        this.Hide();
                        product.ShowDialog();
                        Application.ExitThread();
                    }
                }
                else
                {
                    DialogResult msg = MessageBox.Show("更新失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 取消按钮
            formProduct product = new formProduct();
            this.Hide();
            product.ShowDialog();
            Application.ExitThread();
        }
    }
}
