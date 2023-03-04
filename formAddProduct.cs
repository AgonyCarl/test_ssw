using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace test_ssw
{
    public partial class formAddProduct : Form
    {
        public formAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 取消按钮
            formProduct product = new formProduct();
            this.Hide();
            product.ShowDialog();
            Application.ExitThread();
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

            String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=ccc.8992;allowuservariables=True;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                String sql = String.Format("insert into product(name, code, size, number) values('{0}', '{1}', '{2}', {3})",
    txtProductName.Text, txtProductCode.Text, txtProductSize.Text, int.Parse(txtProductNumber.Text));
                // MessageBox.Show(sql);
                /*MySqlDataAdapter mda = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "product");
                MySqlCommandBuilder scb = new MySqlCommandBuilder(mda);*/
                // update会报错但是插入成功 没有显示插入成功的框
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int count = cmd.ExecuteNonQuery();
                // int count = mda.Update(ds, "product");
                if (count > 0)
                {
                    DialogResult msg = MessageBox.Show("插入成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DialogResult msg = MessageBox.Show("插入失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void formAddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
