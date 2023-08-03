namespace NTM_STAJ_PROJE
{
	partial class Window1
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
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.ribbonBar1 = new Wisej.Web.Ext.RibbonBar.RibbonBar();
            this.ribbonBar2 = new Wisej.Web.Ext.RibbonBar.RibbonBar();
            this.ribbonBar3 = new Wisej.Web.Ext.RibbonBar.RibbonBar();
            this.Anasayfa = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.Departmanlar = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.ribbonBarGroup1 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.btnDepartmanListesi = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.Personeller = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.ribbonBarGroup2 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.btnPersonelListesi = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.ribbonBarGroup3 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
            this.btnPersonelİstatistikleri = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
            this.Firmalar = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.Görevler = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
            this.SuspendLayout();
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
            // ribbonBar1
            // 
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(988, 1);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.Location = new System.Drawing.Point(0, 1);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(988, 1);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.Location = new System.Drawing.Point(0, 2);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Pages.Add(this.Anasayfa);
            this.ribbonBar3.Pages.Add(this.Departmanlar);
            this.ribbonBar3.Pages.Add(this.Personeller);
            this.ribbonBar3.Pages.Add(this.Firmalar);
            this.ribbonBar3.Pages.Add(this.Görevler);
            this.ribbonBar3.Size = new System.Drawing.Size(988, 108);
            this.ribbonBar3.ItemClick += new Wisej.Web.Ext.RibbonBar.RibbonBarItemEventHandler(this.ribbonBar3_ItemClick);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Text = "Anasayfa";
            // 
            // Departmanlar
            // 
            this.Departmanlar.Groups.Add(this.ribbonBarGroup1);
            this.Departmanlar.Name = "Departmanlar";
            this.Departmanlar.Text = "Departmanlar";
            // 
            // ribbonBarGroup1
            // 
            this.ribbonBarGroup1.Items.Add(this.btnDepartmanListesi);
            this.ribbonBarGroup1.Name = "ribbonBarGroup1";
            this.ribbonBarGroup1.Text = "              ";
            // 
            // btnDepartmanListesi
            // 
            this.btnDepartmanListesi.ImageSource = "icon-calendar";
            this.btnDepartmanListesi.Name = "btnDepartmanListesi";
            this.btnDepartmanListesi.Text = "Departman Listesi";
            // 
            // Personeller
            // 
            this.Personeller.Groups.Add(this.ribbonBarGroup2);
            this.Personeller.Groups.Add(this.ribbonBarGroup3);
            this.Personeller.Name = "Personeller";
            this.Personeller.Text = "Personeller";
            // 
            // ribbonBarGroup2
            // 
            this.ribbonBarGroup2.Items.Add(this.btnPersonelListesi);
            this.ribbonBarGroup2.Name = "ribbonBarGroup2";
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.ImageSource = "icon-calendar";
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Text = "Personel Listesi";
            // 
            // ribbonBarGroup3
            // 
            this.ribbonBarGroup3.Items.Add(this.btnPersonelİstatistikleri);
            this.ribbonBarGroup3.Name = "ribbonBarGroup3";
            // 
            // btnPersonelİstatistikleri
            // 
            this.btnPersonelİstatistikleri.ImageSource = "icon-justify-fill";
            this.btnPersonelİstatistikleri.Name = "btnPersonelİstatistikleri";
            this.btnPersonelİstatistikleri.Text = "Personel İstatistikleri";
            // 
            // Firmalar
            // 
            this.Firmalar.Name = "Firmalar";
            this.Firmalar.Text = "Firmalar";
            // 
            // Görevler
            // 
            this.Görevler.Name = "Görevler";
            this.Görevler.Text = "Görevler";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 556);
            this.Controls.Add(this.ribbonBar3);
            this.Controls.Add(this.ribbonBar2);
            this.Controls.Add(this.ribbonBar1);
            this.IsMdiContainer = true;
            this.Name = "Window1";
            this.Text = "Window1";
            this.Load += new System.EventHandler(this.Window1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.ContextMenu contextMenu3;
        private Wisej.Web.Ext.RibbonBar.RibbonBar ribbonBar1;
        private Wisej.Web.Ext.RibbonBar.RibbonBar ribbonBar2;
        private Wisej.Web.Ext.RibbonBar.RibbonBar ribbonBar3;
        private Wisej.Web.Ext.RibbonBar.RibbonBarPage Anasayfa;
        private Wisej.Web.Ext.RibbonBar.RibbonBarPage Departmanlar;
        private Wisej.Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup1;
        private Wisej.Web.Ext.RibbonBar.RibbonBarItemButton btnDepartmanListesi;
        private Wisej.Web.Ext.RibbonBar.RibbonBarPage Personeller;
        private Wisej.Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup2;
        private Wisej.Web.Ext.RibbonBar.RibbonBarItemButton btnPersonelListesi;
        private Wisej.Web.Ext.RibbonBar.RibbonBarPage Firmalar;
        private Wisej.Web.Ext.RibbonBar.RibbonBarPage Görevler;
        private Wisej.Web.Ext.RibbonBar.RibbonBarGroup ribbonBarGroup3;
        private Wisej.Web.Ext.RibbonBar.RibbonBarItemButton btnPersonelİstatistikleri;
    }
}

