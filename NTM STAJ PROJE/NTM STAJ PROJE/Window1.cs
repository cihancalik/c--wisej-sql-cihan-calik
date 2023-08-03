
using System;
using Wisej.Web;
using DataAccessLayer;
using System.Linq;
using EntityLayer;
using NTM_STAJ_PROJE.Forms;

namespace NTM_STAJ_PROJE
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

        private void ribbonBar3_ItemClick(object sender, Wisej.Web.Ext.RibbonBar.RibbonBarItemEventArgs e)
        {
			if (e.Item!=null)
			{
				switch (e.Item.Name)
				{
					case "btnDepartmanListesi":
						(new Forms.frmDepartmanlar { MdiParent=this}).Show();
						break;
					case "btnPersonelListesi":
						(new Forms.frmPersonelListesi {MdiParent=this }).Show(); 
						break;
                    case "btnPersonelİstatistikleri":
                        (new Forms.frmPersonelİstatistikleri { MdiParent = this }).Show();
                        break;

                }
			}
        }

        private void Window1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
