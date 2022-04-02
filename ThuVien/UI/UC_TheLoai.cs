using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThuVien.UI
{
    public partial class UC_TheLoai : UserControl
    {
        public UC_TheLoai()
        {
            InitializeComponent();
        }

        public void display()
        {
            string query = "SELECT * FROM theloai";
            dgv.DataSource = Database.getData(query, false);
        }


        private void UC_Sach_Load(object sender, EventArgs e)
        {
            display();
        }

        int rowIndex;
        string matheloaiSua;
        string tentheloaiSua;
        string motaSua;

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

                    matheloaiSua = dgv.Rows[e.RowIndex].Cells["matheloai"].Value.ToString();
                    tentheloaiSua = dgv.Rows[e.RowIndex].Cells["tentheloai"].Value.ToString();
                    motaSua = dgv.Rows[e.RowIndex].Cells["mota"].Value.ToString();
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
            tenSua.Text = tentheloaiSua;
            moTaSua.Text = motaSua;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hành động này không thể hoàn tác?", "Xóa Thể Loại",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string sQL = $"DELETE theloai from theloai where matheloai = '{matheloaiSua}'";


                Database.execQuery(sQL);

                tabControl1.SelectedIndex = 0;

                display();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tenSua.Text.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên tác giả");
                tenTheLoai.Focus();
            }
            else
            {
                string ten = tenSua.Text;
                string mota = moTaSua.Text;

                string sQL = $"UPDATE theloai set tentheloai = N'{ten}', mota = N'{mota}' where matheloai = '{matheloaiSua}'";

                tenSua.Text = ""; moTaSua.Text = "";

                Database.execQuery(sQL);

                tabControl1.SelectedIndex = 0;

                display();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = matim.Text;
            string ten = tentim.Text;
            string mota = motatim.Text;

            string sQL =
                $"SELECT * FROM theloai " +
                $"WHERE matheloai like '%{ma}%'" +
                $" AND tentheloai like N'%{ten}%'" +
                $" AND mota like N'%{mota}%'";

            dgv.DataSource = Database.getData(sQL, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theloai = tenTheLoai.Text;
            string mota = moTa.Text;

            string sQL = $"Insert into theloai(tentheloai, mota) values (N'{theloai}',N'{mota}')";

            if (theloai.Trim() == "")
            {
                MessageBox.Show("Yêu cầu nhập tên thể loại");
                tenTheLoai.Focus();
            }
            else
            {
                tenTheLoai.BorderStyle = BorderStyle.FixedSingle;
                Database.execQuery(sQL);

                tenTheLoai.Text = ""; tenTheLoai.Focus();
                moTa.Text = "";

                display();
            }
        }

        private void reset(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn reset?", "Reset Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                tenTheLoai.Text = "";
                moTa.Text = "";
                moTaSua.Text = "";
                tenSua.Text = "";
                tentim.Text = "";
                matim.Text = "";
                motatim.Text = "";
            }
        }
    }
}
