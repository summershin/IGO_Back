using Igo_Back;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO
{
    public partial class Product_Management : Form
    {
        public Product_Management()
        {
            InitializeComponent();
            dataGridView1.DataSource = dbContext.Products.ToList();
            dataGridView2.DataSource = dbContext.TicketTypes.ToList();
            loadComoboxItem();
            loadComoboxItem1();
            loadComoboxItem2();
        }
        private void loadComoboxItem()
        {
            var q = from o in dbContext.Cities

                    select o.CityID;
            foreach (var item in q.Distinct())
            {
                comboxCity.Items.Add(item);
            }
            comboxCity.SelectedIndex = 0;
        }

        private void loadComoboxItem1()
        {
            var q = from o in dbContext.Suppliers

                    select o.SupplierID;
            foreach (var item in q.Distinct())
            {
                comboBoxSupplierID.Items.Add(item);
            }
            comboBoxSupplierID.SelectedIndex = 0;
        }

        private void loadComoboxItem2()
        {
            var q = from o in dbContext.SubCategories

                    select o.SubCategoryID;
            foreach (var item in q.Distinct())
            {
                comboBoxSubCategoryID.Items.Add(item);
            }
            comboBoxSubCategoryID.SelectedIndex = 0;
        }
        IGOEntities dbContext = new IGOEntities();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product { ProductName = txtProductName.Text, Quantity = Int32.Parse(txtQuantity.Text), Address= txtAddress.Text,
                CityID = int.Parse(comboxCity.Text),
                SupplierID = Int32.Parse(comboBoxSupplierID.Text),
                SubCategoryID = Int32.Parse(comboBoxSubCategoryID.Text),
                StartTime = Convert.ToDateTime(StartTime.Text), EndTime = Convert.ToDateTime(EndTime.Text) };
            this.dbContext.Products.Add(product);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();

        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.Products.ToList();

        }
        ArrayList x = new ArrayList();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var product = (from p in this.dbContext.Products.AsEnumerable()
                          where p.ProductID == (int)dataGridView1.CurrentRow.Cells[0].Value
                           select p).FirstOrDefault();

            
            if (product == null) return;

            this.dbContext.Products.Remove(product);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = (from p in this.dbContext.Products.AsEnumerable()
                           where p.ProductID == (int)dataGridView1.CurrentRow.Cells[0].Value
                           select p).FirstOrDefault();

            if (product == null) return; //exit method

            product.ProductName = txtProductName.Text;
            product.Quantity = Int32.Parse(txtQuantity.Text);
            product.Address = txtAddress.Text;
            product.CityID = int.Parse(comboxCity.Text);
            product.SupplierID = Int32.Parse(comboBoxSupplierID.Text);
            product.SubCategoryID = Int32.Parse(comboBoxSubCategoryID.Text);
            product.StartTime = Convert.ToDateTime(StartTime.Text);
            product.EndTime = Convert.ToDateTime(EndTime.Text);

            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicketType Ticket = new TicketType
           {
             TicketName=txtTicketName.Text
            };
            this.dbContext.TicketTypes.Add(Ticket);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView1();
        }
        void Read_RefreshDataGridView1()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = this.dbContext.TicketTypes.ToList();

        }
        private void button2_Click(object sender, EventArgs e)
        {

            var ticket = (from p in this.dbContext.TicketTypes.AsEnumerable()
                          where p.TicketID == (int)dataGridView2.CurrentRow.Cells[0].Value
                          select p).FirstOrDefault();


            if (ticket == null) return;
            
            this.dbContext.TicketTypes.Remove(ticket);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView1();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var ticket = (from p in this.dbContext.TicketTypes.AsEnumerable()
                          where p.TicketID == (int)dataGridView2.CurrentRow.Cells[0].Value
                          select p).FirstOrDefault();

            if (ticket == null) return; //exit method

            ticket.TicketName = txtTicketName.Text;

            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView1();
        }

        private void txtTicketName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products
                    where p.ProductName== textBox1.Text
                    select p;
            //var q = this.dbContext.Products.Where(p => p.ProductName == textBox1.Text);

            dataGridView1.DataSource = q.ToList();
            //this.dbContext.SaveChanges();

            //this.Read_RefreshDataGridView();
        }
        public void fileToMS(string fileName, PictureBox pb) {
        
        
        }

        private void InsertPhoto_Click(object sender, EventArgs e)
        {
            ProdunctPhoto f = new ProdunctPhoto();
           
            f.Show();

        }
        BindingSource bs = new BindingSource();
        private void Product_Management_Load(object sender, EventArgs e)
        {
            //var q = from p in dbContext.Products
            //        select new
            //        {
            //            p.ProductID,
            //            p.ProductName,
            //            p.SupplierID,
            //            p.CityID,
            //            p.Address,
            //            p.Quantity,
            //            p.StartTime,
            //            p.EndTime,
            //            p.SubCategoryID



            //        };




            //bs.DataSource = q.ToList();

            //dataGridView1.DataSource = bs;

            //txtProductName.DataBindings.Add("Text", bs, "ProductName");
            //txtQuantity.DataBindings.Add("Text", bs, "Quantity");
            //txtAddress.DataBindings.Add("Text", bs, "Address");
            //comboxCity.DataBindings.Add("Text", bs, "CityID");
            //StartTime.DataBindings.Add("Text", bs, "StartTime");
            //EndTime.DataBindings.Add("Text", bs, "EndTime");
            //comboBoxSubCategoryID.DataBindings.Add("Text", bs, "SubCategoryID");
            //comboBoxSupplierID.DataBindings.Add("Text", bs, "SupplierID");


        }

        private void comboBoxSubCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

