using Igo_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Automation;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class Frm_SupplierData : Form
    {
        public Frm_SupplierData()
        {
            InitializeComponent();
            Loadcmb();


        }

        IGOEntities IgoContext = new IGOEntities();


        private void Loadcmb()
        {

            //===================================================================

            //var q_city = from c in IgoContext.Cities
            //             orderby c.CityID ascending
            //             select new { CityID = c.CityID, CityName = c.City1 };

            //cmb_City.DataSource = q_city.ToList();
            //cmb_City.ValueMember = "CityID";
            //cmb_City.DisplayMember = "CityName";


            //===================================================================


            var q_SplN = from spl in IgoContext.Suppliers
                         orderby spl.SupplierID ascending
                         select new { SupplierID = spl.SupplierID, CompanyName = spl.CompanyName };


            cmb_SupplierName.DataSource = q_SplN.ToList();
            cmb_SupplierName.ValueMember = "SupplierID";
            cmb_SupplierName.DisplayMember = "CompanyName";

        }

        private void loadCmbID()
        {
            var q = from spl in IgoContext.Suppliers
                    orderby spl.SupplierID ascending
                    select spl.SupplierID;

            cmb_SupplierID.DataSource = q.ToList();
        }

        private void LoadCmbToDvg()
        {
            var q = from spl in IgoContext.Suppliers
                    select new
                    {
                        spl.SupplierID,
                        spl.CompanyName,
                        spl.Phone,
                        spl.Address,
                        spl.Products
                    };

            bindingSource1.DataSource = q.ToList();


            cmb_SupplierID.DataBindings.Add("Text", bindingSource1, "SupplierID");
            txt_CRUD_SName.DataBindings.Add("Text", bindingSource1, "CompanyName");
            txt_CRUD_SPhone.DataBindings.Add("Text", bindingSource1, "Phone");
            txt_CRUD_SAddress.DataBindings.Add("Text", bindingSource1, "Address");

        }


        private void reSetDataGvd()

        {
            this.IgoContext.SaveChanges();
            this.dgv_Search.DataSource = null;
            this.dgv_Search.DataSource = this.IgoContext.Suppliers.ToList();

        }

        //==Create===============================================================


        private void btn_ADD_Click(object sender, EventArgs e)
        {


            Supplier supplier = new Supplier()
            {

                CompanyName = txt_CRUD_SName.Text,
                Phone = txt_CRUD_SPhone.Text,
                Address = txt_CRUD_SAddress.Text

            };

            IgoContext.Suppliers.Add(supplier);
            dgv_Search.DataSource = this.IgoContext.Suppliers.ToList();


            reSetDataGvd();


        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier()
                {

                    CompanyName = txt_CRUD_SName.Text,
                    Phone = txt_CRUD_SPhone.Text,
                    Address = txt_CRUD_SAddress.Text

                };

                IgoContext.Suppliers.Add(supplier);
                IgoContext.SaveChanges();

                MessageBox.Show("已成功新增資料");
                dgv_Upate_Delete.DataSource = this.IgoContext.Suppliers.ToList();

            }

            catch (Exception)
            {
                MessageBox.Show("新增資料失敗");
            }

            Loadcmb();
            reSetDataGvd();

        }


        //==Read===============================================================


        private void btn_ReadAll_Click(object sender, EventArgs e)
        {
            this.dgv_Search.DataSource = IgoContext.Suppliers.ToList();


        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_SupplierID.SelectedItem == null)
            {
                loadCmbID();
                LoadCmbToDvg();
                dgv_Upate_Delete.DataSource = bindingSource1;
            }

            else
            {
                dgv_Upate_Delete.CurrentCell = dgv_Upate_Delete.Rows[cmb_SupplierID.SelectedIndex].Cells[0];
                dgv_Upate_Delete.Rows[cmb_SupplierID.SelectedIndex].Selected = true;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //LoadCmbToDvg();
            this.dgv_Search.DataSource = IgoContext.Suppliers.ToList();
            dgv_Search.CurrentCell = dgv_Search.Rows[cmb_SupplierName.SelectedIndex].Cells[0];
            dgv_Search.Rows[cmb_SupplierName.SelectedIndex].Selected = true;
        }



        //==UpDate===============================================================

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                var q = this.IgoContext.Suppliers.AsEnumerable().
                                Where(spl => spl.SupplierID == int.Parse(cmb_SupplierID.Text)).LastOrDefault();

                if (q == null)
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                else
                {

                    q.CompanyName = txt_CRUD_SName.Text;
                    q.Phone = txt_CRUD_SPhone.Text;
                    q.Address = txt_CRUD_SAddress.Text;


                    IgoContext.SaveChanges();
                    MessageBox.Show("修改成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reSetDataGvd();

        }


        //==Delete===============================================================


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                var q = this.IgoContext.Suppliers.AsEnumerable().
                               Where(spl => spl.SupplierID == int.Parse(cmb_SupplierID.Text)).LastOrDefault();

                if (q == null)
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
                else
                {
                    IgoContext.Suppliers.Remove(q);
                    IgoContext.SaveChanges();
                    MessageBox.Show("刪除成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reSetDataGvd();
            Loadcmb();

        }



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CRUD_SAddress.Text = null;
            txt_CRUD_SName.Text = null;
            txt_CRUD_SPhone.Text = null;
            dgv_Search.DataSource = null;
            dgv_Upate_Delete.DataSource = null;

        }

        private void btn_Search_F_Address_Click(object sender, EventArgs e)
        {
            
         

            string address = textBox1.Text;
            var q = from p in IgoContext.Suppliers
                    where p.Address.Contains(address)
                    select p;

            dgv_Search.DataSource = q.ToList();
            

        }

    }
}
