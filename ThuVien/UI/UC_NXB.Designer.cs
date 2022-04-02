namespace ThuVien.UI
{
    partial class UC_NXB
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.diachiThem = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailThem = new System.Windows.Forms.TextBox();
            this.tendaidienThem = new System.Windows.Forms.TextBox();
            this.tenThem = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.diachiTim = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mailTim = new System.Windows.Forms.TextBox();
            this.tendaidienTim = new System.Windows.Forms.TextBox();
            this.tenTim = new System.Windows.Forms.TextBox();
            this.maTim = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.diachiSua = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mailSua = new System.Windows.Forms.TextBox();
            this.tendaidienSua = new System.Windows.Forms.TextBox();
            this.tenSua = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 206);
            this.tabControl1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label15);
            this.tab1.Controls.Add(this.label14);
            this.tab1.Controls.Add(this.diachiThem);
            this.tab1.Controls.Add(this.button4);
            this.tab1.Controls.Add(this.button1);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.mailThem);
            this.tab1.Controls.Add(this.tendaidienThem);
            this.tab1.Controls.Add(this.tenThem);
            this.tab1.Location = new System.Drawing.Point(4, 29);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(880, 173);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Thêm NXB";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // diachiThem
            // 
            this.diachiThem.Location = new System.Drawing.Point(512, 18);
            this.diachiThem.Name = "diachiThem";
            this.diachiThem.Size = new System.Drawing.Size(220, 133);
            this.diachiThem.TabIndex = 3;
            this.diachiThem.Text = "";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(799, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.reset);
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(799, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(433, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người Đại Diện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên NXB";
            // 
            // mailThem
            // 
            this.mailThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailThem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mailThem.Location = new System.Drawing.Point(155, 125);
            this.mailThem.Name = "mailThem";
            this.mailThem.Size = new System.Drawing.Size(172, 26);
            this.mailThem.TabIndex = 2;
            // 
            // tendaidienThem
            // 
            this.tendaidienThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tendaidienThem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tendaidienThem.Location = new System.Drawing.Point(155, 73);
            this.tendaidienThem.Name = "tendaidienThem";
            this.tendaidienThem.Size = new System.Drawing.Size(172, 26);
            this.tendaidienThem.TabIndex = 1;
            // 
            // tenThem
            // 
            this.tenThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenThem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tenThem.Location = new System.Drawing.Point(155, 18);
            this.tenThem.Name = "tenThem";
            this.tenThem.Size = new System.Drawing.Size(172, 26);
            this.tenThem.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.diachiTim);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.mailTim);
            this.tabPage2.Controls.Add(this.tendaidienTim);
            this.tabPage2.Controls.Add(this.tenTim);
            this.tabPage2.Controls.Add(this.maTim);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm Kiếm NXB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // diachiTim
            // 
            this.diachiTim.Location = new System.Drawing.Point(513, 72);
            this.diachiTim.Name = "diachiTim";
            this.diachiTim.Size = new System.Drawing.Size(220, 78);
            this.diachiTim.TabIndex = 5;
            this.diachiTim.Text = "";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(800, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reset);
            // 
            // button5
            // 
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(800, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 14;
            this.button5.Text = "Tìm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(431, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(389, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Người Đại Diện";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(32, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tên NXB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(32, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mã NXB";
            // 
            // mailTim
            // 
            this.mailTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mailTim.Location = new System.Drawing.Point(156, 124);
            this.mailTim.Name = "mailTim";
            this.mailTim.Size = new System.Drawing.Size(172, 26);
            this.mailTim.TabIndex = 3;
            // 
            // tendaidienTim
            // 
            this.tendaidienTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tendaidienTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tendaidienTim.Location = new System.Drawing.Point(513, 18);
            this.tendaidienTim.Name = "tendaidienTim";
            this.tendaidienTim.Size = new System.Drawing.Size(220, 26);
            this.tendaidienTim.TabIndex = 4;
            // 
            // tenTim
            // 
            this.tenTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tenTim.Location = new System.Drawing.Point(156, 72);
            this.tenTim.Name = "tenTim";
            this.tenTim.Size = new System.Drawing.Size(172, 26);
            this.tenTim.TabIndex = 2;
            // 
            // maTim
            // 
            this.maTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maTim.ForeColor = System.Drawing.SystemColors.MenuText;
            this.maTim.Location = new System.Drawing.Point(156, 17);
            this.maTim.Name = "maTim";
            this.maTim.Size = new System.Drawing.Size(172, 26);
            this.maTim.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.diachiSua);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.mailSua);
            this.tabPage1.Controls.Add(this.tendaidienSua);
            this.tabPage1.Controls.Add(this.tenSua);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(880, 173);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sửa Thông Tin NXB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // diachiSua
            // 
            this.diachiSua.Location = new System.Drawing.Point(513, 15);
            this.diachiSua.Name = "diachiSua";
            this.diachiSua.Size = new System.Drawing.Size(220, 133);
            this.diachiSua.TabIndex = 4;
            this.diachiSua.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(800, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.reset);
            // 
            // button6
            // 
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Location = new System.Drawing.Point(800, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 14;
            this.button6.Text = "Lưu Lại";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(434, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(32, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(32, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Người Đại Diện";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(32, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tên NXB";
            // 
            // mailSua
            // 
            this.mailSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mailSua.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mailSua.Location = new System.Drawing.Point(156, 122);
            this.mailSua.Name = "mailSua";
            this.mailSua.Size = new System.Drawing.Size(172, 26);
            this.mailSua.TabIndex = 3;
            // 
            // tendaidienSua
            // 
            this.tendaidienSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tendaidienSua.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tendaidienSua.Location = new System.Drawing.Point(156, 70);
            this.tendaidienSua.Name = "tendaidienSua";
            this.tendaidienSua.Size = new System.Drawing.Size(172, 26);
            this.tendaidienSua.TabIndex = 2;
            // 
            // tenSua
            // 
            this.tenSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenSua.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tenSua.Location = new System.Drawing.Point(156, 15);
            this.tenSua.Name = "tenSua";
            this.tenSua.Size = new System.Drawing.Size(172, 26);
            this.tenSua.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 212);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 30;
            this.dgv.Size = new System.Drawing.Size(888, 506);
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(333, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(333, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "*";
            // 
            // UC_NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv);
            this.Name = "UC_NXB";
            this.Size = new System.Drawing.Size(888, 718);
            this.Load += new System.EventHandler(this.UC_Sach_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailThem;
        private System.Windows.Forms.TextBox tendaidienThem;
        private System.Windows.Forms.RichTextBox diachiThem;
        private System.Windows.Forms.RichTextBox diachiTim;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox mailTim;
        private System.Windows.Forms.TextBox tenTim;
        private System.Windows.Forms.TextBox maTim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tendaidienTim;
        private System.Windows.Forms.RichTextBox diachiSua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox mailSua;
        private System.Windows.Forms.TextBox tendaidienSua;
        private System.Windows.Forms.TextBox tenSua;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
