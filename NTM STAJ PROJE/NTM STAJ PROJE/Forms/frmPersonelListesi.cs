using System;
using System.Web.Caching;
using Wisej.Web;
using DataAccessLayer;
using EntityLayer;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NTM_STAJ_PROJE.Forms
{
    public partial class frmPersonelListesi : Form
    {
        
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            
            cmbxDepartmanAdı.DataSource = (from x in Personelİslemler.cmbxverigetir()
                                           select new
                                           {
                                               x.ID,
                                               x.Ad
                                           }).ToList();
            cmbxDepartmanAdı.DisplayMember = "Ad";
            cmbxDepartmanAdı.ValueMember = "ID";
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=Personelİslemler.Listele().ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel x = new Personel();
            x.Ad = txtAdı.Text;
            x.Soyad=txtSoyadı.Text;
            x.Mail=txtMail.Text;
            x.Telefon=txtTelefon.Text;
            x.Gorsel=txtGorsel.Text;
            x.DepartmanID = int.Parse(cmbxDepartmanAdı.SelectedValue.ToString());












            dataGridView1.DataSource = Personelİslemler.Ekle(x);
            dataGridView1.DataSource = Personelİslemler.Listele().ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personel x = new Personel();
            x.ID = Convert.ToInt32(txtPersonelID.Text);
            dataGridView1.DataSource = Personelİslemler.Sil(x);
            dataGridView1.DataSource = Personelİslemler.Listele().ToList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
           Personel x = new Personel();
            x.Ad=txtAdı.Text;
            x.Soyad = txtSoyadı.Text;
            x.Mail=txtMail.Text;
            x.Telefon = txtTelefon.Text;
            x.Gorsel = txtGorsel.Text;
            x.DepartmanID = int.Parse(cmbxDepartmanAdı.SelectedValue.ToString());

            x.ID = Convert.ToInt32(txtPersonelID.Text);
            dataGridView1.DataSource = Personelİslemler.Guncelle(x);
            dataGridView1.DataSource = Personelİslemler.Listele().ToList();
        }
    }

       
    
}
