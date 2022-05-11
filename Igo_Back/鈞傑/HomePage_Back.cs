using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題.BackEnd
{
    public partial class HomePage_Back : Form
    {
        private int childFormNumber = 0;

        public HomePage_Back()
        {
            InitializeComponent();
        }

        private void btn_SupplierM_Click(object sender, EventArgs e)
        {
            Frm_SupplierData frm_sup = new Frm_SupplierData();
            frm_sup.MdiParent = this;
            frm_sup.Parent = this.splitContainer2.Panel2;
           
            frm_sup.Show();
        }
    }
}
