using IGO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

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

            this.splitContainer2.Panel2.Controls.Clear();
            Frm_SupplierData f = new Frm_SupplierData();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;

            f.Show();
        }

        private void btn_MemberM_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            UserManagement fu = new UserManagement();
            fu.MdiParent = this;
            fu.Parent = this.splitContainer2.Panel2;
            fu.Show();

        }

        private void btn_FeedBackM_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Comment_Management fc = new Comment_Management();
            fc.MdiParent = this;
            fc.Parent = this.splitContainer2.Panel2;

            fc.Show();
        }


            private void btn_ProductM_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Product_Management fp = new Product_Management();
            fp.MdiParent = this;
            fp.Parent = this.splitContainer2.Panel2;
            fp.Show();


        }

        private void btn_OrdersM_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Order_Management fp = new Order_Management();
            fp.MdiParent = this;
            fp.Parent = this.splitContainer2.Panel2;
            fp.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
