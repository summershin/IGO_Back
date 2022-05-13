using Igo_Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO
{
    public partial class Comment_Management : Form
    {
        public Comment_Management()
        {
            InitializeComponent();
           
            LoadYearToComboBox();
            LoadMonthYoComboBox();
            LoadStarToComboBox();

            
            

        }

       
        IGOEntities dbContext = new IGOEntities();

        private void LoadStarToComboBox()
        {
            var q = (from p in dbContext.FeedbackManagements
                     orderby p.Ranking descending
                     select p.Ranking.ToString()).Distinct();

            foreach (var item in q)
            {
                this.Cb_ByStar.Items.Add(item);
            }
        }



        private void LoadMonthYoComboBox()
        {
            var q = (from p in dbContext.FeedbackManagements
                     select p.FeedbackDate.Value.Month).Distinct();

            foreach (var item in q)
            {
                this.Cb_Month.Items.Add(item);
            }
        }

        private void LoadYearToComboBox()
        {
            var q = (from p in dbContext.FeedbackManagements
                    select p.FeedbackDate.Value.Year).Distinct();

            foreach(var item in q)
            {
                this.Cb_Year.Items.Add(item);
            }

           
        }

        //=============================右半部===============================================

        private void Bt_SearchAll_Click(object sender, EventArgs e)
        {
          
            var q = from p in dbContext.FeedbackManagements
                    select new { p.FeedbackID,p.CustomerID, CustomerName = p.Customer.LastName + p.Customer.FirstName, p.FeedbackContent,
                                    p.Ranking,p.ProductsID,p.Product.ProductName,p.FeedbackDate };

            this.DGV_Comment.DataSource = q.ToList();
            Lb_WithComment.Text = "所有評論共" + q.Count() + "筆";

        }

        
        private void Btn_ByStar_Click(object sender, EventArgs e)
        {
            if(Cb_ByStar.Text=="5")
            {
                var q = from p in dbContext.FeedbackManagements
                        where p.Ranking == 5
                        select new
                        {
                            p.FeedbackID,
                            p.CustomerID,
                            CustomerName = p.Customer.LastName + p.Customer.FirstName,
                            p.FeedbackContent,
                            p.Ranking,
                            p.ProductsID,
                            p.Product.ProductName,
                            p.FeedbackDate
                        };

                this.DGV_Comment.DataSource = q.ToList();
                Lb_WithComment.Text = "五星評論共" + q.Count() + "筆";
            }
            else if(Cb_ByStar.Text == "4")
            {
                var q = from p in dbContext.FeedbackManagements
                        where p.Ranking == 4
                        select new
                        {
                            p.FeedbackID,
                            p.CustomerID,
                            CustomerName = p.Customer.LastName + p.Customer.FirstName,
                            p.FeedbackContent,
                            p.Ranking,
                            p.ProductsID,
                            p.Product.ProductName,
                            p.FeedbackDate
                        };

                this.DGV_Comment.DataSource = q.ToList();
                Lb_WithComment.Text = "四星評論共" + q.Count() + "筆";
            }
            else if (Cb_ByStar.Text == "3")
            {
                var q = from p in dbContext.FeedbackManagements
                        where p.Ranking == 3
                        select new
                        {
                            p.FeedbackID,
                            p.CustomerID,
                            CustomerName = p.Customer.LastName + p.Customer.FirstName,
                            p.FeedbackContent,
                            p.Ranking,
                            p.ProductsID,
                            p.Product.ProductName,
                            p.FeedbackDate
                        };

                this.DGV_Comment.DataSource = q.ToList();
                Lb_WithComment.Text = "三星評論共" + q.Count() + "筆";
            }
            else if (Cb_ByStar.Text == "2")
            {
                var q = from p in dbContext.FeedbackManagements
                        where p.Ranking == 2
                        select new
                        {
                            p.FeedbackID,
                            p.CustomerID,
                            CustomerName = p.Customer.LastName + p.Customer.FirstName,
                            p.FeedbackContent,
                            p.Ranking,
                            p.ProductsID,
                            p.Product.ProductName,
                            p.FeedbackDate
                        };

                this.DGV_Comment.DataSource = q.ToList();
                Lb_WithComment.Text = "二星評論共" + q.Count() + "筆";
            }
            else
            {
                var q = from p in dbContext.FeedbackManagements
                        where p.Ranking == 1
                        select new
                        {
                            p.FeedbackID,
                            p.CustomerID,
                            CustomerName = p.Customer.LastName + p.Customer.FirstName,
                            p.FeedbackContent,
                            p.Ranking,
                            p.ProductsID,
                            p.Product.ProductName,
                            p.FeedbackDate
                        };

                this.DGV_Comment.DataSource = q.ToList();
                Lb_WithComment.Text = "一星評論共" + q.Count() + "筆";
            }

        }

        private void Bt_SearchByDate_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.FeedbackManagements.AsEnumerable()
                    where p.FeedbackDate.Value.Year==Convert.ToInt32(Cb_Year.Text)
                    &&p.FeedbackDate.Value.Month==Convert.ToInt32(Cb_Month.Text)
                    select new
                    {
                        p.FeedbackID,
                        p.CustomerID,
                        CustomerName = p.Customer.LastName + p.Customer.FirstName,
                        p.FeedbackContent,
                        p.Ranking,
                        p.ProductsID,
                        p.Product.ProductName,
                        p.FeedbackDate
                    };
            
            
                DGV_Comment.DataSource = q.ToList();
            Lb_WithComment.Text = "日期篩選評論共" + q.Count() + "筆";

        }

        private void Bt_SearchByProduct_Click(object sender, EventArgs e)
        {
            string userInput = Tb_ProductName.Text;
            //int UserInput = Convert.ToInt32(Tb_ProductNumber.Text);
            var q = from f in dbContext.FeedbackManagements.AsEnumerable()
                    where f.Product.ProductName.Contains(userInput)

                    select new
                    {
                        f.FeedbackID,
                        f.CustomerID,
                        CustomerName = f.Customer.LastName + f.Customer.FirstName,
                        f.FeedbackContent,
                        f.Ranking,
                        f.ProductsID,
                        f.Product.ProductName,
                        f.FeedbackDate
                    };


            DGV_Comment.DataSource = q.ToList();
            Lb_WithComment.Text = "產品篩選評論共" + q.Count() + "筆";
        }

       //=============================左半部===============================================

        
        private void Btn_SearchByKeyWord_Click(object sender, EventArgs e)
        {
            string userInput = Tb_KeyWord.Text;
            var q = from f in dbContext.FeedbackManagements
                    where f.FeedbackContent.Contains(userInput)
                    select new
                    {
                        f.FeedbackID,
                       f.CustomerID,
                        CustomerName = f.Customer.LastName + f.Customer.FirstName,
                        f.FeedbackContent,
                        f.Ranking,
                        f.ProductsID,
                        f.Product.ProductName,
                        f.FeedbackDate
                    };



            DGV_Comment.DataSource = q.ToList();
        }




       


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Tb_Comment.TextLength >10)
            {
                MessageBox.Show("超過字數!");
                return;
            }

            else if (Tb_Detail.Text == "")
            {
                MessageBox.Show("缺少必要產品ID!");
                return;
            }
            else if (Tb_CustomerNumber.Text == "")
            {
                MessageBox.Show("缺少必要客戶ID!");
                return;
            }

            else if (Tb_Star.Text == "")
            {
                MessageBox.Show("缺少必要五星評分");
                return;
            }
            else  if (Tb_Comment.Text=="")
            {
                MessageBox.Show("缺少必要評論!");
                return;
            }
           
            
            FeedbackManagement feedback = new FeedbackManagement
            {
                ProductsID = Convert.ToInt32(Tb_Detail.Text),
                CustomerID = Convert.ToInt32(Tb_CustomerNumber.Text),
                FeedbackContent = Tb_Comment.Text,
                Ranking = Convert.ToInt32(Tb_Star.Text),
                FeedbackDate = DateTime.Now
            };
            this.dbContext.FeedbackManagements.Add(feedback);

            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();

            

        }


        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            string q = Convert.ToString(DGV_Comment.CurrentRow.Cells[3].Value);
            var comment = (from p in this.dbContext.FeedbackManagements.AsEnumerable()
                           where p.FeedbackContent == q

                           select p).FirstOrDefault();

            

            if (comment != null)
            {
                comment.Customer.LastName = Tb_CustomerLastName.Text;
                comment.Customer.FirstName = Tb_CustomerFirstName.Text;
                comment.Product.ProductName = Tb_ProductName2.Text;
                comment.FeedbackContent = Tb_Comment.Text;

                dbContext.SaveChanges();
                this.Read_RefreshDataGridView();
            }

            

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            // delete one comment
            string q = Convert.ToString(DGV_Comment.CurrentRow.Cells[3].Value);
            var comment = (from p in this.dbContext.FeedbackManagements.AsEnumerable()
                           where p.FeedbackContent == q

                           select p).FirstOrDefault();

            if (comment == null) return;

            this.dbContext.FeedbackManagements.Remove(comment);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();
        }


        void Read_RefreshDataGridView()
        {

            var q = from p in dbContext.FeedbackManagements
                    select new
                    {
                        p.FeedbackID,
                        p.CustomerID,
                        CustomerName = p.Customer.LastName + p.Customer.FirstName,
                        p.FeedbackContent,
                        p.Ranking,
                        p.ProductsID,
                        p.Product.ProductName,
                        p.FeedbackDate
                    };


            this.DGV_Uncomment.DataSource = null;
            this.DGV_Uncomment.DataSource = q.ToList();
            

        }



        //=============================共同部分===============================================
        
        private void DGV_Uncomment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DGV_Uncomment.CurrentRow.Cells != null)
            //{
            //    Tb_ProductName.Text = DGV_Uncomment.CurrentRow.Cells[5].Value.ToString();
            //    Tb_Comment.Text = DGV_Uncomment.CurrentRow.Cells[2].Value.ToString();
            //    // Tb_Star.Text = DGV_Comment.CurrentRow.Cells[4].Value.ToString();
            //    Tb_CustomerName.Text = DGV_Uncomment.CurrentRow.Cells[1].Value.ToString();
            //    DTP_Date.Value = (DateTime)DGV_Uncomment.CurrentRow.Cells[6].Value;
            //}
            //else
            //{
            //    MessageBox.Show("缺少必要輸入");
            //}

        }

       

        private void DGV_Comment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
                Tb_CustomerFirstName.Text= DGV_Comment.CurrentRow.Cells[2].Value.ToString().Substring(1);
                Tb_CustomerLastName.Text = DGV_Comment.CurrentRow.Cells[2].Value.ToString().Substring(0,1);
                Tb_Detail.Text=DGV_Comment.CurrentRow.Cells[0].Value.ToString();
                Tb_ProductName2.Text = DGV_Comment.CurrentRow.Cells[6].Value.ToString();
                Tb_Comment.Text = DGV_Comment.CurrentRow.Cells[3].Value.ToString();
                Tb_Star.Text = DGV_Comment.CurrentRow.Cells[4].Value.ToString();
                Tb_CustomerNumber.Text = DGV_Comment.CurrentRow.Cells[1].Value.ToString();
                //DTP_Date.Value = (DateTime)DGV_Comment.CurrentRow.Cells[7].Value;
             
             
        }

        //==============================分頁======================================
        private void Btn_statistics_Click(object sender, EventArgs e)
        {
            Comment_Statistics f = new Comment_Statistics();
            f.Show();

        //    var q = from p in dbContext.FeedbackManagements.AsEnumerable()
        //            where p.CustomerID = (int)f.customerIDTextBox.BindingContext.ToString()
        //            select p.Customer.LastName + p.Customer.FirstName;

        //    f.Tb_CustomerName.Text = q.ToList().ToString();
        }

        
    }
}
