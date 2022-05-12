using Igo_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {

            InitializeComponent();

            inputdata();
        }

        void inputdata()
        {
            var q = dbcontext.Customers.Select(n => new
            {
                n.CustumerID,
                n.Phone,
                n.Password,
                n.LastName,
                n.FirstName,
                n.Email,
                n.Birth,
                n.Address,
                n.Gender,
                n.Photo
            });


            bs.DataSource = q.ToList();
            dataGridView1.DataSource = bs;

            txt_Phone.DataBindings.Add("Text", bs, "Phone");
            txt_Password.DataBindings.Add("Text", bs, "Password");
            txt_LastName.DataBindings.Add("Text", bs, "LastName");
            txt_FirstName.DataBindings.Add("Text", bs, "FirstName");
            txt_Email.DataBindings.Add("Text", bs, "Email");
            dtp_Birth.DataBindings.Add("Value", bs, "Birth");
            txt_Address.DataBindings.Add("Text", bs, "Address");
            cbx_Gender.DataBindings.Add("Text", bs, "Gender");
            pic_Photo.DataBindings.Add("Image", bs, "Photo", true);
            dtp_Birth.DataBindings.Clear();
        }

        BindingSource bs = new BindingSource();
        IGOEntities dbcontext = new IGOEntities();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Phone.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("*為必填欄位!");
                return;
            }

            var q2 = dbcontext.Customers.AsEnumerable().Where(n => n.Phone == txt_Phone.Text&&n.CustumerID!=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (q2.ToList().Count != 0) 
            {
                MessageBox.Show("此號碼已有使用者!");
                return;
            }

            string password = txt_Password.Text;
            password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            var q = dbcontext.Customers.AsEnumerable().Where(n => n.Phone == dataGridView1.CurrentRow.Cells[1].Value.ToString());

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pic_Photo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byt = (byte[])ms.GetBuffer();

            foreach (var change in q)
            {
                change.Phone = txt_Phone.Text;
                change.Password = password;
                change.LastName = txt_LastName.Text;
                change.FirstName = txt_FirstName.Text;
                change.Email = txt_Email.Text;
                change.Birth = dtp_Birth.Value;
                change.Address = txt_Address.Text;
                change.Gender = cbx_Gender.Text;
                change.Photo = byt;

            }
            dbcontext.SaveChanges();

            var q1 = dbcontext.Customers.AsEnumerable().Where(n => n.CustumerID == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).Select(n => new
            {
                n.CustumerID,
                n.Phone,
                n.Password,
                n.LastName,
                n.FirstName,
                n.Email,
                n.Birth,
                n.Address,
                n.Gender,
                n.Photo
            });

            dataGridView2.DataSource = q1.ToList();

        }

        private void btn_Browses_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Photo.Image = Image.FromFile(ofd.FileName);
            }

        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Customers.AsEnumerable().Where(n => n.Phone == txt_Search.Text);
            bs.DataSource = q.ToList();
            //dataGridView1.DataSource = bs.DataSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            dtp_Birth.DataBindings.Add("Value", bs, "Birth");
            }
            catch
            {
                dtp_Birth.Value = dtp_Birth.Value;
            }
            dtp_Birth.DataBindings.Clear();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Phone.DataBindings.Clear();
            txt_Password.DataBindings.Clear();
            txt_LastName.DataBindings.Clear();
            txt_FirstName.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            dtp_Birth.DataBindings.Clear();
            txt_Address.DataBindings.Clear();
            cbx_Gender.DataBindings.Clear();
            pic_Photo.DataBindings.Clear();

            inputdata();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Customers.AsEnumerable().Where(n => n.Phone == dataGridView1.CurrentRow.Cells[1].Value.ToString());

            dbcontext.Customers.Remove(q.First());
            dbcontext.SaveChanges();
        }
        

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            if (!int.TryParse(txt_Phone.Text, out a))
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            if (!txt_Phone.Text.StartsWith("09"))
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            if (txt_Phone.Text.Length != 10)
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            else
            {
                lb_Phone.Text = "*格式正確!";
                lb_Phone.ForeColor = Color.Green;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text.Contains("@") && txt_Email.Text.Contains(".com"))
            {
                lb_email.Text = "*格式正確!";
                lb_email.ForeColor = Color.Green;
            }
            else
            {
                lb_email.Text = "**輸入格式不正確!!";
                lb_email.ForeColor = Color.Red;
                return;
            }
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
