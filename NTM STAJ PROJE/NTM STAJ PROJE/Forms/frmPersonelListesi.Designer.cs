namespace NTM_STAJ_PROJE.Forms
{
    partial class frmPersonelListesi
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.label6 = new Wisej.Web.Label();
            this.btnGüncelle = new Wisej.Web.Button();
            this.btnSil = new Wisej.Web.Button();
            this.btnEkle = new Wisej.Web.Button();
            this.btnListele = new Wisej.Web.Button();
            this.txtPersonelID = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.txtAdı = new Wisej.Web.TextBox();
            this.txtMail = new Wisej.Web.TextBox();
            this.txtSoyadı = new Wisej.Web.TextBox();
            this.txtGorsel = new Wisej.Web.TextBox();
            this.cmbxDepartmanAdı = new Wisej.Web.ComboBox();
            this.label7 = new Wisej.Web.Label();
            this.txtTelefon = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Görsel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Departman Adı:";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageSource = "icon-undo";
            this.btnGüncelle.Location = new System.Drawing.Point(725, 341);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(210, 27);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageSource = "window-minimize";
            this.btnSil.Location = new System.Drawing.Point(725, 308);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(210, 27);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageSource = "window-maximize";
            this.btnEkle.Location = new System.Drawing.Point(725, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(210, 27);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.ImageSource = "window-icon";
            this.btnListele.Location = new System.Drawing.Point(725, 242);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(210, 27);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(725, 9);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(210, 22);
            this.txtPersonelID.TabIndex = 13;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
            // 
            // txtAdı
            // 
            this.txtAdı.Location = new System.Drawing.Point(725, 44);
            this.txtAdı.Name = "txtAdı";
            this.txtAdı.Size = new System.Drawing.Size(210, 22);
            this.txtAdı.TabIndex = 14;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(725, 111);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(210, 22);
            this.txtMail.TabIndex = 16;
            // 
            // txtSoyadı
            // 
            this.txtSoyadı.Location = new System.Drawing.Point(725, 83);
            this.txtSoyadı.Name = "txtSoyadı";
            this.txtSoyadı.Size = new System.Drawing.Size(210, 22);
            this.txtSoyadı.TabIndex = 15;
            // 
            // txtGorsel
            // 
            this.txtGorsel.Location = new System.Drawing.Point(725, 175);
            this.txtGorsel.Name = "txtGorsel";
            this.txtGorsel.Size = new System.Drawing.Size(210, 22);
            this.txtGorsel.TabIndex = 15;
            // 
            // cmbxDepartmanAdı
            // 
            this.cmbxDepartmanAdı.Location = new System.Drawing.Point(725, 204);
            this.cmbxDepartmanAdı.Name = "cmbxDepartmanAdı";
            this.cmbxDepartmanAdı.Size = new System.Drawing.Size(210, 22);
            this.cmbxDepartmanAdı.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(725, 140);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(210, 22);
            this.txtTelefon.TabIndex = 19;
            // 
            // frmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 424);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbxDepartmanAdı);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtGorsel);
            this.Controls.Add(this.txtSoyadı);
            this.Controls.Add(this.txtAdı);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPersonelListesi";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.frmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Label label5;
        private Wisej.Web.Label label6;
        private Wisej.Web.Button btnGüncelle;
        private Wisej.Web.Button btnSil;
        private Wisej.Web.Button btnEkle;
        private Wisej.Web.Button btnListele;
        private Wisej.Web.TextBox txtPersonelID;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.TextBox txtAdı;
        private Wisej.Web.TextBox txtMail;
        private Wisej.Web.TextBox txtSoyadı;
        private Wisej.Web.TextBox txtGorsel;
        private Wisej.Web.ComboBox cmbxDepartmanAdı;
        private Wisej.Web.Label label7;
        private Wisej.Web.TextBox txtTelefon;
    }
}