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
            // ��ʼ������������
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
            String sql = "select name as '��Ʒ����', code as '��Ʒ����', size as '��Ʒ���', number as '��Ʒ�������', createtime as '����ʱ��' from product;";
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
            // ������ѯ sqlƴ��
            String connectStr = "server=localhost;port=3306;database=ssw;user=root;password=yourpwd;allowuservariables=True;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
                StringBuilder sbSql = new StringBuilder(500);

                sbSql.Append("select name as '��Ʒ����', code as '��Ʒ����', size as '��Ʒ���', number as '��Ʒ�������', createtime as '����ʱ��' from product where 1 = 1 ");

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
            // ���txtBox��ֵ
            txtProductName.Text = "";
            txtProductCode.Text = "";
            txtProductSize.Text = "";
            Form1_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ��ת����ӽ���
            formAddProduct addProduct = new formAddProduct();
            this.Hide();
            addProduct.ShowDialog();
            Application.ExitThread();
        }

        private void formProdut_FormClosed(object sender, FormClosedEventArgs e)
        {
            // �رճ���
            Application.Exit();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // ���ѡ��������
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
            // ��ת���޸Ľ���
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

            DialogResult result = MessageBox.Show("ȷ��ɾ���ò�Ʒ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                        DialogResult msg = MessageBox.Show("ɾ���ɹ���", "��ܰ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Form1_Load(sender, e);
                    }
                    else
                    {
                        DialogResult msg = MessageBox.Show("����ʧ�ܣ�", "��ܰ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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