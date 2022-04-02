using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        UI.UC_Sach uc_Sach;
        UI.UC_TacGia uc_TacGia;
        UI.UC_TheLoai uc_TheLoai;
        UI.UC_NXB uc_NXB;

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (uc_Sach == null)
            {
                uc_Sach = new UI.UC_Sach();
                uc_Sach.Dock = DockStyle.Fill;
                main.Controls.Add(uc_Sach);
                uc_Sach.BringToFront();
            }
            else
            {
                uc_Sach.display();
                uc_Sach.BringToFront();
            }
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (uc_TheLoai == null)
            {
                uc_TheLoai = new UI.UC_TheLoai();
                uc_TheLoai.Dock = DockStyle.Fill;
                main.Controls.Add(uc_TheLoai);
                uc_TheLoai.BringToFront();
            }
            else
            {
                uc_TheLoai.BringToFront();
            }
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (uc_TacGia == null)
            {
                uc_TacGia = new UI.UC_TacGia();
                uc_TacGia.Dock = DockStyle.Fill;
                main.Controls.Add(uc_TacGia);
                uc_TacGia.BringToFront();
            }
            else
            {
                uc_TacGia.BringToFront();
            }
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (uc_NXB == null)
            {
                uc_NXB = new UI.UC_NXB();
                uc_NXB.Dock = DockStyle.Fill;
                main.Controls.Add(uc_NXB);
                uc_NXB.BringToFront();
            }
            else
            {
                uc_NXB.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Application Start");
            this.accordionControlElement7_Click(sender, e);
        }
    }
}
