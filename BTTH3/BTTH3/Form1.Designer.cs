namespace BTTH3
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrBoxNhapFile = new System.Windows.Forms.GroupBox();
            this.btnDocFileDe = new System.Windows.Forms.Button();
            this.txtTenFileDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuongDanFileDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrBoxKetQua = new System.Windows.Forms.GroupBox();
            this.btnXemDapAn = new System.Windows.Forms.Button();
            this.txtSoCauSai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoCauDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtBangGhi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GirdTbl = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDocFileDA = new System.Windows.Forms.Button();
            this.txtTenFileDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuongDanFileDA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrBoxNhapFile.SuspendLayout();
            this.GrBoxKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirdTbl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBoxNhapFile
            // 
            this.GrBoxNhapFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GrBoxNhapFile.Controls.Add(this.btnDocFileDe);
            this.GrBoxNhapFile.Controls.Add(this.txtTenFileDe);
            this.GrBoxNhapFile.Controls.Add(this.label2);
            this.GrBoxNhapFile.Controls.Add(this.txtDuongDanFileDe);
            this.GrBoxNhapFile.Controls.Add(this.label1);
            this.GrBoxNhapFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBoxNhapFile.Location = new System.Drawing.Point(1, 28);
            this.GrBoxNhapFile.Name = "GrBoxNhapFile";
            this.GrBoxNhapFile.Size = new System.Drawing.Size(337, 127);
            this.GrBoxNhapFile.TabIndex = 0;
            this.GrBoxNhapFile.TabStop = false;
            this.GrBoxNhapFile.Text = "Nhập Đề ";
            // 
            // btnDocFileDe
            // 
            this.btnDocFileDe.Location = new System.Drawing.Point(148, 87);
            this.btnDocFileDe.Name = "btnDocFileDe";
            this.btnDocFileDe.Size = new System.Drawing.Size(91, 23);
            this.btnDocFileDe.TabIndex = 4;
            this.btnDocFileDe.Text = "Đọc File Đề";
            this.btnDocFileDe.UseVisualStyleBackColor = true;
            this.btnDocFileDe.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // txtTenFileDe
            // 
            this.txtTenFileDe.Location = new System.Drawing.Point(127, 59);
            this.txtTenFileDe.Name = "txtTenFileDe";
            this.txtTenFileDe.Size = new System.Drawing.Size(146, 22);
            this.txtTenFileDe.TabIndex = 3;
            this.txtTenFileDe.Text = "de.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên File";
            // 
            // txtDuongDanFileDe
            // 
            this.txtDuongDanFileDe.Location = new System.Drawing.Point(127, 25);
            this.txtDuongDanFileDe.Name = "txtDuongDanFileDe";
            this.txtDuongDanFileDe.Size = new System.Drawing.Size(146, 22);
            this.txtDuongDanFileDe.TabIndex = 1;
            this.txtDuongDanFileDe.Text = "D:\\\\ThuMucTest\\\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường Dẫn File";
            // 
            // GrBoxKetQua
            // 
            this.GrBoxKetQua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GrBoxKetQua.Controls.Add(this.btnXemDapAn);
            this.GrBoxKetQua.Controls.Add(this.txtSoCauSai);
            this.GrBoxKetQua.Controls.Add(this.label3);
            this.GrBoxKetQua.Controls.Add(this.txtSoCauDung);
            this.GrBoxKetQua.Controls.Add(this.label4);
            this.GrBoxKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrBoxKetQua.Location = new System.Drawing.Point(1, 294);
            this.GrBoxKetQua.Name = "GrBoxKetQua";
            this.GrBoxKetQua.Size = new System.Drawing.Size(337, 155);
            this.GrBoxKetQua.TabIndex = 1;
            this.GrBoxKetQua.TabStop = false;
            this.GrBoxKetQua.Text = "Kết Quả";
            // 
            // btnXemDapAn
            // 
            this.btnXemDapAn.Location = new System.Drawing.Point(149, 116);
            this.btnXemDapAn.Name = "btnXemDapAn";
            this.btnXemDapAn.Size = new System.Drawing.Size(91, 23);
            this.btnXemDapAn.TabIndex = 4;
            this.btnXemDapAn.Text = "Xem Đáp Án";
            this.btnXemDapAn.UseVisualStyleBackColor = true;
            this.btnXemDapAn.Click += new System.EventHandler(this.btnXemDapAn_Click);
            // 
            // txtSoCauSai
            // 
            this.txtSoCauSai.Enabled = false;
            this.txtSoCauSai.Location = new System.Drawing.Point(127, 77);
            this.txtSoCauSai.Name = "txtSoCauSai";
            this.txtSoCauSai.Size = new System.Drawing.Size(146, 22);
            this.txtSoCauSai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Câu Sai";
            // 
            // txtSoCauDung
            // 
            this.txtSoCauDung.Enabled = false;
            this.txtSoCauDung.Location = new System.Drawing.Point(127, 37);
            this.txtSoCauDung.Name = "txtSoCauDung";
            this.txtSoCauDung.Size = new System.Drawing.Size(146, 22);
            this.txtSoCauDung.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Câu Đúng";
            // 
            // rtxtBangGhi
            // 
            this.rtxtBangGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtBangGhi.Location = new System.Drawing.Point(344, 28);
            this.rtxtBangGhi.Name = "rtxtBangGhi";
            this.rtxtBangGhi.Size = new System.Drawing.Size(611, 851);
            this.rtxtBangGhi.TabIndex = 2;
            this.rtxtBangGhi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(341, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bảng Ghi";
            // 
            // GirdTbl
            // 
            this.GirdTbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GirdTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirdTbl.Location = new System.Drawing.Point(1, 455);
            this.GirdTbl.Name = "GirdTbl";
            this.GirdTbl.Size = new System.Drawing.Size(337, 424);
            this.GirdTbl.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.btnDocFileDA);
            this.groupBox1.Controls.Add(this.txtTenFileDA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDuongDanFileDA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 127);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đáp Án";
            // 
            // btnDocFileDA
            // 
            this.btnDocFileDA.Location = new System.Drawing.Point(137, 87);
            this.btnDocFileDA.Name = "btnDocFileDA";
            this.btnDocFileDA.Size = new System.Drawing.Size(112, 23);
            this.btnDocFileDA.TabIndex = 4;
            this.btnDocFileDA.Text = "Đọc File Đáp Án";
            this.btnDocFileDA.UseVisualStyleBackColor = true;
            this.btnDocFileDA.Click += new System.EventHandler(this.btnDocFileDA_Click);
            // 
            // txtTenFileDA
            // 
            this.txtTenFileDA.Location = new System.Drawing.Point(127, 59);
            this.txtTenFileDA.Name = "txtTenFileDA";
            this.txtTenFileDA.Size = new System.Drawing.Size(146, 22);
            this.txtTenFileDA.TabIndex = 3;
            this.txtTenFileDA.Text = "da.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên File";
            // 
            // txtDuongDanFileDA
            // 
            this.txtDuongDanFileDA.Location = new System.Drawing.Point(127, 25);
            this.txtDuongDanFileDA.Name = "txtDuongDanFileDA";
            this.txtDuongDanFileDA.Size = new System.Drawing.Size(146, 22);
            this.txtDuongDanFileDA.TabIndex = 1;
            this.txtDuongDanFileDA.Text = "D:\\\\ThuMucTest\\\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đường Dẫn File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 880);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GirdTbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtBangGhi);
            this.Controls.Add(this.GrBoxKetQua);
            this.Controls.Add(this.GrBoxNhapFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrBoxNhapFile.ResumeLayout(false);
            this.GrBoxNhapFile.PerformLayout();
            this.GrBoxKetQua.ResumeLayout(false);
            this.GrBoxKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirdTbl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBoxNhapFile;
        private System.Windows.Forms.Button btnDocFileDe;
        private System.Windows.Forms.TextBox txtTenFileDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuongDanFileDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrBoxKetQua;
        private System.Windows.Forms.Button btnXemDapAn;
        private System.Windows.Forms.TextBox txtSoCauSai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoCauDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtBangGhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GirdTbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDocFileDA;
        private System.Windows.Forms.TextBox txtTenFileDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuongDanFileDA;
        private System.Windows.Forms.Label label7;
    }
}

