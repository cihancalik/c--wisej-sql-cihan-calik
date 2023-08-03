namespace NTM_STAJ_PROJE.Forms
{
    partial class frmDepartmanlar
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
            this.backgroundWorker1 = new Wisej.Web.BackgroundWorker();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.txtID = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.TxtDepartmanAdı = new Wisej.Web.TextBox();
            this.btnListele = new Wisej.Web.Button();
            this.btnEkle = new Wisej.Web.Button();
            this.btnSil = new Wisej.Web.Button();
            this.btnGüncelle = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departman Adı:";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = Wisej.Web.CharacterCasing.Capitalize;
            this.txtID.Location = new System.Drawing.Point(767, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 22);
            this.txtID.TabIndex = 3;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
            // 
            // contextMenu3
            // 
            this.contextMenu3.Name = "contextMenu3";
            // 
            // TxtDepartmanAdı
            // 
            this.TxtDepartmanAdı.Location = new System.Drawing.Point(767, 82);
            this.TxtDepartmanAdı.Name = "TxtDepartmanAdı";
            this.TxtDepartmanAdı.Size = new System.Drawing.Size(164, 22);
            this.TxtDepartmanAdı.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.ImageSource = "window-icon";
            this.btnListele.Location = new System.Drawing.Point(767, 150);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 27);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageSource = "window-maximize";
            this.btnEkle.Location = new System.Drawing.Point(767, 206);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 27);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageSource = "window-minimize";
            this.btnSil.Location = new System.Drawing.Point(767, 262);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 27);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ImageSource = "icon-undo";
            this.btnGüncelle.Location = new System.Drawing.Point(767, 313);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 27);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // frmDepartmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 456);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.TxtDepartmanAdı);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDepartmanlar";
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.frmDepartmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.BackgroundWorker backgroundWorker1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox txtID;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.ContextMenu contextMenu3;
        private Wisej.Web.TextBox TxtDepartmanAdı;
        private Wisej.Web.Button btnListele;
        private Wisej.Web.Button btnEkle;
        private Wisej.Web.Button btnSil;
        private Wisej.Web.Button btnGüncelle;
    }
}