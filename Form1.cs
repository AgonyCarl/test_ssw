using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace test_ssw
{
    public partial class formProduct : Form
    {

        Product product = new Product();

        public formProduct()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始加载所有数据
            String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=yourpwd;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String sql = "select name as '产品名称', code as '产品编码', size as '产品规格', number as '产品库存数量', createtime as '创建时间' from product;";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            mda.Fill(ds, "product");
            productData.DataSource = ds.Tables["product"];
            conn.Close();
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductId_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 条件查询 sql拼接
            String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=yourpwd;allowuservariables=True;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                StringBuilder sbSql = new StringBuilder(500);

                sbSql.Append("select name as '产品名称', code as '产品编码', size as '产品规格', number as '产品库存数量', createtime as '创建时间' from product where 1 = 1 ");

                if (!String.IsNullOrEmpty(txtProductName.Text))
                {
                    sbSql.Append(String.Format(" and name like '{0}'", "%" + txtProductName.Text + "%"));
                }
                if (!String.IsNullOrEmpty(txtProductCode.Text))
                {
                    sbSql.Append(String.Format(" and code like '{0}'", txtProductCode.Text));
                }
                if (!String.IsNullOrEmpty(txtProductSize.Text))
                {
                    sbSql.Append(String.Format(" and size like '{0}'", txtProductSize.Text));
                }
                MySqlDataAdapter mda = new MySqlDataAdapter(sbSql.ToString(), conn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "product");
                productData.DataSource = ds.Tables["product"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 清空txtBox的值
            txtProductName.Text = "";
            txtProductCode.Text = "";
            txtProductSize.Text = "";
            Form1_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 跳转到添加界面
            formAddProduct addProduct = new formAddProduct();
            this.Hide();
            addProduct.ShowDialog();
            Application.ExitThread();
        }

        private void formProdut_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 关闭程序
            Application.Exit();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 获得选中行数据
            String[] str = new String[5];
            for (int i = 0; i < productData.RowCount; i++)
            {
                if (productData.Rows[i].Selected == true)
                {
                    for (int j = 0; j < productData.ColumnCount; j++)
                    {
                        str[j] = productData.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            product.Name = str[0];
            product.Code = str[1];
            product.Size = str[2];
            product.Number = int.Parse(str[3]);
            // 跳转到修改界面
            formUpdateProduct updateProduct = new formUpdateProduct(product);
            this.Hide();
            updateProduct.ShowDialog();
            Application.ExitThread();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            String productName = "";
            for (int i = 0; i < productData.RowCount; i++)
            {
                if (productData.Rows[i].Selected == true)
                {
                    productName = productData.Rows[i].Cells[0].Value.ToString();
                }
            }

            DialogResult result = MessageBox.Show("确定删除该产品吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=yourpwd;allowuservariables=True;";
                MySqlConnection conn = new MySqlConnection(connectStr);
                try
                {
                    conn.Open();
                    String sql = String.Format("delete from product where name = '{0}'", productName);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int count = cmd.ExecuteNonQuery();
                    // int count = mda.Update(ds, "product");
                    if (count > 0)
                    {
                        DialogResult msg = MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Form1_Load(sender, e);
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
            else
            {
                
            }


        }
    }
}