using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThuVien.UI
{
    public partial class UC_TacGia : UserControl
    {
        public UC_TacGia()
        {
            InitializeComponent();
        }

        public void display()
        {
            string query = "SELECT * FROM tacgia";
            dgv.DataSource = Database.getData(query, false);
        }

        private void themTacGia(object sender, EventArgs e)
        {
            string hoTen = tenTacGia.Text;
            string email = emailTacGia.Text;
            string gioiTinh = gTinhNu.Checked ? "Nữ" : "Nam";
            string mota = moTa.Text;

            string sQL = $"Insert into tacgia(tentacgia, email, gioitinh, mota) values (N'{hoTen}',N'{email}',N'{gioiTinh}',N'{mota}')";

            if (hoTen.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên tác giả");
                tenTacGia.Focus();
            }
            else
            {
                tenTacGia.BorderStyle = BorderStyle.FixedSingle;
                Database.execQuery(sQL);

                tenTacGia.Text = ""; tenTacGia.Focus();
                emailTacGia.Text = "";
                rd.Checked = true;
                moTa.Text = "";

                display();
            }
        }

        private void UC_Sach_Load(object sender, EventArgs e)
        {
            display();
        }

        int rowIndex;
        string maTacGiaSua;
        string tentgSua;
        string emailtgSua;
        string gttgSua;
        string motatgSua;

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

                    maTacGiaSua = dgv.Rows[e.RowIndex].Cells["matacgia"].Value.ToString();
                    tentgSua = dgv.Rows[e.RowIndex].Cells["tentacgia"].Value.ToString();
                    emailtgSua = dgv.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    gttgSua = dgv.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString();
                    motatgSua = dgv.Rows[e.RowIndex].Cells["mota"].Value.ToString();
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
            tenSua.Text = tentgSua;
            emailSua.Text = emailtgSua;
            moTaSua.Text = motatgSua;

            if (gttgSua == "Nam")
            {
                namGtSua.Checked = true;
            }
            else
            {
                gtNuSua.Checked = true;
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hành động này không thể hoàn tác?", "Xóa Tác Giả",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string sQL = $"DELETE tacgia from tacgia where matacgia = '{maTacGiaSua}'";


                Database.execQuery(sQL);

                tabControl1.SelectedIndex = 0;

                display();
            }

        }

        //UPDATE TAC GIA
        private void button2_Click(object sender, EventArgs e)
        {
            if (tenSua.Text.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên tác giả");
                tenTacGia.Focus();
            }
            else
            {
                string hoTen = tenSua.Text;
                string email = emailSua.Text;
                string gioiTinh = namGtSua.Checked ? "Nam" : "Nữ";
                string mota = moTaSua.Text;

                string sQL = $"UPDATE tacgia set tentacgia = N'{hoTen}', email = N'{email}', gioitinh = N'{gioiTinh}', mota = N'{mota}' where matacgia = '{maTacGiaSua}'";


                tenSua.Text = "";
                emailSua.Text = "";
                moTaSua.Text = "";

                Database.execQuery(sQL);

                tabControl1.SelectedIndex = 0;

                display();
            }
        }

        //TIM TAC GIA
        private void button3_Click(object sender, EventArgs e)
        {
            string matacgia = matacgiatim.Text;
            string hoTen = tentacgiatim.Text;
            string email = emailtacgiatim.Text;
            string gioiTinh = gioitinhnamtim.Checked ? "Nam" : gioitinhnutim.Checked ? "Nữ" : "";

            string sQL =
                $"SELECT * FROM tacgia " +
                $"WHERE matacgia like '%{matacgia}%'" +
                $" AND tentacgia like N'%{hoTen}%'" +
                $" AND email like N'%{email}%'" +
                $" AND gioitinh like N'%{gioiTinh}%'";

            dgv.DataSource = Database.getData(sQL, false);
        }

        private void reset(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn reset?", "Reset Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                tenTacGia.Text = "";
                moTa.Text = "";
                emailTacGia.Text = "";
                moTaSua.Text = "";
                emailSua.Text = "";
                tenSua.Text = "";
                tentacgiatim.Text = "";
                matacgiatim.Text = "";
                emailtacgiatim.Text = "";
            }
        }
    }
}
