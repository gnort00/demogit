using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _21110701
{
    public partial class Form1 : Form
    {
        
        private SqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
        }
        string strconnec = @"Data Source=.;Initial Catalog=QLTHUOC;User ID=sa;Password=19012003";
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLTHUOC;User ID=sa;Password=19012003");
        private void KetNoiCSDL()
        {
            conn.Open();
            string sql = "Select * From THUOC"; 
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult notice;
            notice = (MessageBox.Show("Bạn có muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (notice == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }
        int DeleteRow(string txt_ma)
        {
            using (SqlConnection connection = new SqlConnection(strconnec))
            {
                connection.Open();

                // Tên bảng mà bạn muốn xóa hàng
                string tableName = "THUOC";

                // Tên cột là khóa chính
                string primaryKeyColumnName = "MATHUOC";

                // Truy vấn SQL để xóa hàng dựa trên khóa chính
                string query = $"DELETE FROM {tableName} WHERE {primaryKeyColumnName} = @PrimaryKeyValue";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrimaryKeyValue", txt_ma);
                    command.ExecuteNonQuery();
                    return 1;

                }
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string i = txt_MaThuoc.Text;
            int j = DeleteRow(i);
            if (j > 0)
            {
                MessageBox.Show("Xóa thành công");
                KetNoiCSDL();
            }
            else MessageBox.Show("Lỗi");

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
