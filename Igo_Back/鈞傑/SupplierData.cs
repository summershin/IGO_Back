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
            bd_spl1();


        }

        IGOEntities IgoContext = new IGOEntities();


        private void Loadcmb()
        {
            var q = from spl in IgoContext.Suppliers
                    orderby spl.SupplierID ascending
                    select spl.SupplierID;

            var q2 = from spl in IgoContext.Suppliers
                     orderby spl.SupplierID ascending
                     select spl.SupplierID;

            cmb_splID.DataSource = q.ToList();
            cmb_SupplierID.DataSource = q2.ToList();
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

        private void bd_spl1()
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

            dgv_Upate_Delete.DataSource = bindingSource1;
        }


        private void reSetDataGvd()

        {

            this.dgv_Search.DataSource = null;
            this.dgv_Search.DataSource = this.IgoContext.Suppliers.ToList();
            dgv_Upate_Delete.DataSource = this.IgoContext.Suppliers.ToList();


        }

        //==Create===============================================================


        private void btn_ADD_Click(object sender, EventArgs e)
        {
           

            //Supplier supplier = new Supplier()
            //{

            //    CompanyName = txt_CRUD_SName.Text,
            //    Phone = txt_CRUD_SPhone.Text,
            //    Address = txt_CRUD_SAddress.Text

            //};

            //IgoContext.Suppliers.Add(supplier);
            //IgoContext.SaveChanges();
            //var q = this.IgoContext.Suppliers.AsEnumerable().ToList().LastOrDefault();


            //dgv_PreviewAdd.DataSource = q;


            //reSetDataGvd();
            


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


                dgv_PreviewAdd.DataSource = IgoContext.Suppliers.ToList();

                reSetDataGvd();
            }

            catch (Exception)
            {
                MessageBox.Show("新增資料失敗");
            }

            Loadcmb();
            

        }


        //==Read===============================================================


        private void btn_ReadAll_Click(object sender, EventArgs e)
        {
            this.dgv_Search.DataSource = IgoContext.Suppliers.ToList();
        }

        

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                dgv_Upate_Delete.CurrentCell = dgv_Upate_Delete.Rows[cmb_SupplierID.SelectedIndex].Cells[0];
                dgv_Upate_Delete.Rows[cmb_SupplierID.SelectedIndex].Selected = true;

        }

        private void btn_Search_ID_Click(object sender, EventArgs e)
        {

            this.dgv_Search.DataSource = IgoContext.Suppliers.ToList();
            dgv_Search.CurrentCell = dgv_Search.Rows[cmb_splID.SelectedIndex].Cells[0];
            dgv_Search.Rows[cmb_splID.SelectedIndex].Selected = true;


        }

        private void btn_Search_F_SplName_Click(object sender, EventArgs e)
        {
            this.dgv_Search.DataSource = IgoContext.Suppliers.ToList();
            dgv_Search.CurrentCell = dgv_Search.Rows[cmb_SupplierName.SelectedIndex].Cells[0];
            dgv_Search.Rows[cmb_SupplierName.SelectedIndex].Selected = true;
        }






        //==UpDate===============================================================

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string sn = txt_CRUD_SName.Text;
            string sp = txt_CRUD_SPhone.Text;
            string sa = txt_CRUD_SAddress.Text;

            try
            {
                var q = this.IgoContext.Suppliers.AsEnumerable().
                                Where(spl => spl.SupplierID == int.Parse(cmb_SupplierID.Text)).LastOrDefault();

                if (q == null)
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                else if(sn==null ||sp ==null || sa==null)
                {
                    MessageBox.Show("修改失敗 ! 請勿空白欄位");
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
            //dgv_Search.DataSource = null;
           

        }
        private void btn_txtsearchName_Click(object sender, EventArgs e)
        {
            string splName = txt_searchName.Text;
            var q = from n in IgoContext.Suppliers
                    where n.CompanyName.Contains(splName)
                    select n;

            dgv_Search.DataSource = q.ToList();
        }
        private void btn_Search_F_Address_Click(object sender, EventArgs e)
        {
            
         

            string address = txt_address.Text;
            var q = from a in IgoContext.Suppliers
                    where a.Address.Contains(address)
                    select a;

            dgv_Search.DataSource = q.ToList();
            

        }

        private void Frm_SupplierData_Load(object sender, EventArgs e)
        {



        }

        private void btn_Del_Click(object sender, EventArgs e)
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
    }
}
