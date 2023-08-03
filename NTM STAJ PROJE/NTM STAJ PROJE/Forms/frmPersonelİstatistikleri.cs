using System;
using Wisej.Web;
using EntityLayer;
using DataAccessLayer;

namespace NTM_STAJ_PROJE.Forms
{
    public partial class frmPersonelİstatistikleri : Form
    {
        public frmPersonelİstatistikleri()
        {
            InitializeComponent();
        }

        private void frmPersonelİstatistikleri_Load(object sender, EventArgs e)
        {
            
            lblToplamPersonel.Text = DataAccessLayer.Personelİstatatisikleriİslemleri.ToplamPersonel().ToString();
            lblToplamDepartman.Text=DataAccessLayer.Personelİstatatisikleriİslemleri.ToplamDepartman().ToString();
        }
    }
}
