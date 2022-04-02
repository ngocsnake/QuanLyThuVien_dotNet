using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThuVien.UI
{
    public partial class UC_NXB : UserControl
    {

        string ma;
        string ten;
        string nguoidaidien;
        string email;
        string diachi;

        public UC_NXB()
        {
            InitializeComponent();
        }

        public void display()
        {
            string query = "SELECT * FROM nhaxuatban";
            dgv.DataSource = Database.getData(query, false);
        }


        private void UC_Sach_Load(object sender, EventArgs e)
        {
            display();
        }

        int rowIndex;


        private void dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgv, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                 
                    ma = dgv.Rows[e.RowIndex].Cells["manhaxuatban"].Value.ToString();
                    ten = dgv.Rows[e.RowIndex].Cells["tennhaxuatban"].Value.ToString();
                    nguoidaidien = dgv.Rows[e.RowIndex].Cells["nguoidaidien"].Value.ToString();
                    email = dgv.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    diachi = dgv.Rows[e.RowIndex].Cells["diachi"].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            tenSua.Text = ten;
            tendaidienSua.Text = nguoidaidien;
            mailSua.Text = email;
            diachiSua.Text = diachi;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hành động này không thể hoàn tác?", "Xóa Nhà Xuất Bản",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string sQL = $"DELETE nhaxuatban from nhaxuatban where manhaxuatban = '{ma}'";

                Database.execQuery(sQL);

                tabControl1.SelectedIndex = 0;

                display();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tenSua.Text.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên nhà xuất bản");
                tenThem.Focus();
            }
            else
            {

                string sQL = $"UPDATE nhaxuatban set " +
                    $"tennhaxuatban = N'{tenSua.Text}', " +
                    $"diachi = N'{diachiSua.Text}', " +
                    $"email = N'{mailSua.Text}', " +
                    $"nguoidaidien = N'{tendaidienSua.Text}' " +
                    $"where manhaxuatban = '{ma}'";
               

                Database.execQuery(sQL);
                reset2();

                tabControl1.SelectedIndex = 0;

                display();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = maTim.Text;
            string ten = tenTim.Text;
            string nguoidaidien = tendaidienTim.Text;
            string email = mailTim.Text;
            string diachi = diachiTim.Text;

            string sQL =
                $"SELECT * FROM nhaxuatban " +
                $"WHERE manhaxuatban like '%{ma}%'" +
                $" AND tennhaxuatban like N'%{ten}%'" +
                $" AND diachi like N'%{diachi}%'" +
                $" AND email like N'%{email}%'" +
                $" AND nguoidaidien like N'%{nguoidaidien}%'";
            dgv.DataSource = Database.getData(sQL, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = tenThem.Text;
            string tendaidien = tendaidienThem.Text;
            string email = mailThem.Text;
            string diachi = diachiThem.Text;

            string sQL = $"Insert into nhaxuatban (tennhaxuatban, diachi, email, nguoidaidien) values (N'{ten}',N'{diachi}',N'{email}',N'{tendaidien}')";

            if (ten.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên nhà xuất bản");
                tenThem.Focus();
                return;
            }
            if (tendaidien.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên người đại diện");
                tendaidienThem.Focus();
                return;
            }
                Database.execQuery(sQL);

                tenThem.Text = ""; tenThem.Focus();
                tendaidienThem.Text = "";
                mailThem.Text = "";
                diachiThem.Text = "";

                display();
        }

        private void reset(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn reset?", "Reset Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                reset2();
            }
        }

        public void reset2()
        {
            tenThem.Text = "";
            diachiThem.Text = "";
            tendaidienThem.Text = "";
            mailThem.Text = "";
            tenTim.Text = "";
            mailTim.Text = "";
            tendaidienTim.Text = "";
            mailTim.Text = "";
            diachiTim.Text = "";
            tenSua.Text = "";
            mailSua.Text = "";
            tendaidienSua.Text = "";
            diachiSua.Text = "";
        }
    }
}
