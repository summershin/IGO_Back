using Igo_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO
{
    public partial class ProdunctPhoto : Form
    {
        public ProdunctPhoto()
        {
            InitializeComponent();
            dataGridView1.DataSource = dbContext.ProductsPhotoes.ToList();
            loadComoboxItem();
        }

        private void loadComoboxItem()
        {
            var q = from o in dbContext.Products

                    select o.ProductID;
            foreach (var item in q.Distinct())
            {
                comboxProductID.Items.Add(item);
            }
            comboxProductID.SelectedIndex = 0;
        }
        Bitmap apple;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //宣告openFileDialog1

            openFileDialog1.Filter = "All Files|*.*";
            //設定可以開啟的檔案格式

            openFileDialog1.ShowDialog(); //SHOW出圖片囉
            apple = new Bitmap(openFileDialog1.FileName);
            //讓蘋果得到秀出圖片的資訊

            this.pictureBox1.Image = apple;
            //顯示apple在pictureBox1的框架內
        }
        IGOEntities dbContext = new IGOEntities();
        String strCn = "Data Source=localhost;integrated security=sspi;initial catalog=mydata";
        private void button3_Click(object sender, EventArgs e)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (pictureBox1.Image == null) 
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byt = (byte[])ms.GetBuffer();

            ProductsPhoto photo = new ProductsPhoto
            {
                ProductID = int.Parse(comboxProductID.Text),
                Photo = byt
                

            };
            this.dbContext.ProductsPhotoes.Add(photo);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbContext.ProductsPhotoes.ToList();

        }

        private void comboxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var photo = (from p in this.dbContext.ProductsPhotoes.AsEnumerable()
                          where p.PhotoID == (int)dataGridView1.CurrentRow.Cells[0].Value
                          select p).FirstOrDefault();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byt = (byte[])ms.GetBuffer();
            if (photo == null) return; //exit method
           photo.ProductID = int.Parse(comboxProductID.Text);
            photo.Photo = byt;

            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var photo = (from p in this.dbContext.ProductsPhotoes.AsEnumerable()
                          where p.PhotoID == (int)dataGridView1.CurrentRow.Cells[0].Value
                          select p).FirstOrDefault();


            if (photo == null) return;

            this.dbContext.ProductsPhotoes.Remove(photo);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        BindingSource bs = new BindingSource();
        private void ProdunctPhoto_Load(object sender, EventArgs e)
        {
            //var q = from p in dbContext.ProductsPhotoes
            //        select new
            //        {
            //            p.PhotoID,
            //            p.ProductID,
            //            p.Photo



            //        };
            //bs.DataSource = q.ToList();

            //dataGridView1.DataSource = bs;

            //comboxProductID.DataBindings.Add("Text", bs, "ProductID");
            //pictureBox1.DataBindings.Add("Image", bs, "Photo",true);
        }
    }
}
