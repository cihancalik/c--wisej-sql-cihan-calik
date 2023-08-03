using System;
using System.Linq;
using DataAccessLayer;
using Wisej.Web;
using EntityLayer;

namespace NTM_STAJ_PROJE.Forms
{
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= Departmanlarİslemler.Listele().ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar x = new Departmanlar();
            x.Ad = TxtDepartmanAdı.Text;
            dataGridView1.DataSource= Departmanlarİslemler.Ekle(x);
            dataGridView1.DataSource = Departmanlarİslemler.Listele().ToList();



        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            Departmanlar x = new Departmanlar();
            x.ID = Convert.ToInt32(txtID.Text);
            dataGridView1.DataSource = Departmanlarİslemler.Sil(x);
            dataGridView1.DataSource = Departmanlarİslemler.Listele().ToList();




        }
        // Seçtiğimiz satırın bilgilerini text kutularına getiriyoruz
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            int indexRow =e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            txtID.Text = row.Cells[0].Value.ToString();
            TxtDepartmanAdı.Text = row.Cells[1].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Departmanlar x = new Departmanlar();
            x.Ad = TxtDepartmanAdı.Text;
            x.ID = Convert.ToInt32(txtID.Text);
            dataGridView1.DataSource = Departmanlarİslemler.Guncelle(x);
            dataGridView1.DataSource = Departmanlarİslemler.Listele().ToList();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
