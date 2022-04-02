using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace ThuVien.UI
{
    public partial class UC_Sach : UserControl
    {
        public UC_Sach()
        {
            InitializeComponent();
        }

        public void display()
        {
            try
            {
                string query = "SELECT * FROM DATA";
                dgvSach.DataSource = Database.getData(query, true);

                string nhaxuatban = "select * from nhaxuatban";
                nxbcb.ValueMember = "manhaxuatban";
                nxbcb.DisplayMember = "tennhaxuatban";
                nxbcb.DataSource = Database.getData(nhaxuatban, false);
                nxbcb.SelectedIndex = -1;

                string theloai = "select * from theloai";
                theloaicb.ValueMember = "matheloai";
                theloaicb.DisplayMember = "tentheloai";
                theloaicb.DataSource = Database.getData(theloai, false);
                theloaicb.SelectedIndex = -1;

                string tacgia = "select * from tacgia";
                tacgiacb.ValueMember = "matacgia";
                tacgiacb.DisplayMember = "tentacgia";
                tacgiacb.DataSource = Database.getData(tacgia, false);
                tacgiacb.SelectedIndex = -1;



                string nhaxuatban2 = "select * from nhaxuatban";
                xuatbancb.ValueMember = "manhaxuatban";
                xuatbancb.DisplayMember = "tennhaxuatban";
                xuatbancb.DataSource = Database.getData(nhaxuatban2, false);
                xuatbancb.SelectedIndex = -1;

                string theloai2 = "select * from theloai";
                tlcb.ValueMember = "matheloai";
                tlcb.DisplayMember = "tentheloai";
                tlcb.DataSource = Database.getData(theloai2, false);
                tlcb.SelectedIndex = -1;

                string tacgia2 = "select * from tacgia";
                tgcb.ValueMember = "matacgia";
                tgcb.DisplayMember = "tentacgia";
                tgcb.DataSource = Database.getData(tacgia2, false);
                tgcb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Err: " + ex);
            }
        }

        private void UC_Sach_Load(object sender, EventArgs e)
        {
            preview.ImageLocation = @"img\default-book.png";
            display();
        }

        string pathInput = @"img\default-book.png";
        string fileName = "default-book.png";

        private void openFileDialog(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathInput = dlg.FileName;
                fileName = Path.GetFileName(pathInput);
                preview.ImageLocation = pathInput;
            }
        }

        private void openFileDialogSua(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathInput = dlg.FileName;
                fileName = Path.GetFileName(pathInput);
                hinhsua.ImageLocation = pathInput;
            }
        }

        public Boolean validate()
        {
            if (tenthem.Text == "")
            {
                tenthem.Focus();
                MessageBox.Show("Yêu cầu nhập tên sách!");
                return true;
            }
            if (tacgiacb.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn tác giả!");
                return true;
            }
            if (nxbcb.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn nhà xuất bản!");
                return true;
            }
            if (theloaicb.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn thể loại!");
                return true;
            }
            return false;
        }
                
        //THEM SACH
        private void button1_Click(object sender, EventArgs e)
        {
            string root = @"C:\Pano Ltd\Library";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            try
            {
                if (validate()) return;
                string ten = tenthem.Text;
                string matacgia = tacgiacb.SelectedValue.ToString();
                string matheloai = theloaicb.SelectedValue.ToString();
                string manxb = nxbcb.SelectedValue.ToString();
                string nam = namthem.Text;
                

                string pathOutput = @"C:\Pano Ltd\Library\" + fileName;
                if (File.Exists(pathOutput))
                {
                    File.Delete(pathOutput);
                }
                File.Copy(pathInput, pathOutput);
                string sQL = $"INSERT INTO sach (tensach,matacgia,matheloai,manhaxuatban,namxuatban,hinhanh) " +
                    $"values (N'{ten}',N'{matacgia}',N'{matheloai}',N'{manxb}',N'{nam}',N'{pathOutput}')";
                Database.execQuery(sQL);

                resett();
                display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        int rowIndex;
        string masach;
        string tensachSua;
        string tacgiaSua;
        string theloaiSua;
        string nxbSua;
        string namxuatbanSua;
        string hinhanhSua;

        private void dgvSach_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgvSach.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgvSach.CurrentCell = dgvSach.Rows[e.RowIndex].Cells[1];
                    contextMenuStrip1.Show(dgvSach, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);

                    masach = dgvSach.Rows[e.RowIndex].Cells["dcmnguvcl"].Value.ToString();
                    tensachSua = dgvSach.Rows[e.RowIndex].Cells["idiotwinform"].Value.ToString();
                    tacgiaSua = dgvSach.Rows[e.RowIndex].Cells["tentacgia"].Value.ToString();
                    theloaiSua = dgvSach.Rows[e.RowIndex].Cells["tentheloai"].Value.ToString();
                    nxbSua = dgvSach.Rows[e.RowIndex].Cells["tennhaxuatban"].Value.ToString();
                    namxuatbanSua = dgvSach.Rows[e.RowIndex].Cells["namxuatban"].Value.ToString();
                    hinhanhSua = dgvSach.Rows[e.RowIndex].Cells["ha"].Value.ToString();
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

            string nhaxuatban = "select * from nhaxuatban";
            nxbsua.ValueMember = "manhaxuatban";
            nxbsua.DisplayMember = "tennhaxuatban";
            nxbsua.DataSource = Database.getData(nhaxuatban, false);
            nxbsua.SelectedIndex = nxbsua.FindStringExact(nxbSua);

            string theloai = "select * from theloai";
            theloaisua.ValueMember = "matheloai";
            theloaisua.DisplayMember = "tentheloai";
            theloaisua.DataSource = Database.getData(theloai, false);
            theloaisua.SelectedIndex = theloaisua.FindStringExact(theloaiSua);

            string tacgia = "select * from tacgia";
            tacgiasua.ValueMember = "matacgia";
            tacgiasua.DisplayMember = "tentacgia";
            tacgiasua.DataSource = Database.getData(tacgia, false);
            tacgiasua.SelectedIndex = tacgiasua.FindStringExact(tacgiaSua);

            hinhsua.ImageLocation = hinhanhSua;

            tenSua.Text = tensachSua;
            namsua.Text = namxuatbanSua;
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hành động này không thể hoàn tác?", "Xóa Sách",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string sQL = $"DELETE sach from sach where masach = '{masach}'";


                File.Delete(hinhanhSua);
                Database.execQuery(sQL);
                tabControl1.SelectedIndex = 0;
                display();
            }
        }

        private void reset(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn reset?", "Reset Form",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                resett();
            }

        }

        private void resett()
        {
            tenthem.Text = "";
            namthem.Text = "";
            tacgiacb.SelectedIndex = -1;
            nxbcb.SelectedIndex = -1;
            theloaicb.SelectedIndex = -1;
            preview.ImageLocation = @"img\default-book.png";

            tenSua.Text = "";
            hinhsua.ImageLocation = @"img\default-book.png";
            nxbsua.SelectedIndex = -1;
            theloaisua.SelectedIndex = -1;
            tacgiasua.SelectedIndex = -1;
            namsua.Text = "";

            tentim.Text = "";
            matim.Text = "";
            namtim.Text = "";
            tgcb.SelectedIndex = -1;
            tlcb.SelectedIndex = -1;
            xuatbancb.SelectedIndex = -1;
        }
        //SUA SACH
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(tenSua.Text == "")
                {
                    tenSua.Focus();
                    MessageBox.Show("Yêu cầu nhập tên sách!");
                    return;
                }

                string ten = tenSua.Text;
                string matacgia = tacgiasua.SelectedValue.ToString();
                string matheloai = theloaisua.SelectedValue.ToString();
                string manxb = nxbsua.SelectedValue.ToString();
                string nam = namsua.Text;

                pathInput = hinhsua.ImageLocation;
                fileName = Path.GetFileName(pathInput);


                string pathOutput = @"C:\Pano Ltd\Library\" + fileName;
                string sQL = $"UPDATE sach SET " +
                    $"tensach = N'{ten}'," +
                    $"matacgia = N'{matacgia}'," +
                    $"matheloai = N'{matheloai}'," +
                    $"manhaxuatban = N'{manxb}'," +
                    $"namxuatban = N'{nam}'," +
                    $"hinhanh = N'{pathOutput}'";

                if (!(hinhanhSua == pathOutput))
                {
                    File.Delete(hinhanhSua);
                    File.Copy(pathInput, pathOutput);
                }
                Database.execQuery(sQL);

                Console.WriteLine(sQL);

                resett();
                display();


                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


            tabControl1.SelectedIndex = 0;

            display();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ma = matim.Text;
            string ten = tentim.Text;
            string nam = namtim.Text;

            string tacgia = tgcb.SelectedIndex == -1 ? "" : tgcb.SelectedValue.ToString();
            string theloai = tlcb.SelectedIndex == -1 ? "" : tlcb.SelectedValue.ToString();
            string nhaxuatban = xuatbancb.SelectedIndex == -1 ? "" : xuatbancb.SelectedValue.ToString();

            string sQL =
                $"SELECT * FROM data " +
                $"WHERE masach like '%{ma}%'" +
                $" AND tensach like N'%{ten}%'" +
                $" AND namxuatban like N'%{nam}%'" +
                $" AND matacgia like N'%{tacgia}%'" +
                $" AND matheloai like N'%{theloai}%'" +
                $" AND manhaxuatban like N'%{nhaxuatban}%'";
            dgvSach.DataSource = Database.getData(sQL, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Sách";
                // storing header part in Excel  
                for (int i = 1; i < dgvSach.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvSach.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvSach.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSach.Columns.Count - 1; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvSach.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(saveDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
            }
        }
    }
}