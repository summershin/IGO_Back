using Igo_Back;
using System;
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
    public partial class Comment_Statistics : Form
    {
        public Comment_Statistics()
        {
            InitializeComponent();
           
            
        }

        IGOEntities dbContext = new IGOEntities();
         

        
        private void feedbackManagementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'iGODataSet.FeedbackManagement' 資料表。您可以視需要進行移動或移除。
            //this.feedbackManagementTableAdapter.Fill(this.iGODataSet.FeedbackManagement);
            
            
        }

        private void Comment_Statistics_Load(object sender, EventArgs e)
        {
            //this.Validate();
            //this.feedbackManagementBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.iGODataSet);

            var q = from p in dbContext.FeedbackManagements
                    select new
                    {
                        客戶名稱 = p.Customer.LastName + p.Customer.FirstName,
                        客戶照片=p.Customer.Photo,
                        p.Product.ProductName,
                        p.FeedbackContent,
                        p.Ranking
                    };
            this.dataGridView1.DataSource = q.ToList();

            //this.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            //this.textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            //this.textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            //this.textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);


            bs.DataSource = q.ToList();
            dataGridView1.DataSource = bs;

            textBox1.DataBindings.Add("Text", bs, "客戶名稱");
            textBox2.DataBindings.Add("Text", bs, "ProductName");
            textBox3.DataBindings.Add("Text", bs, "FeedbackContent");
            textBox4.DataBindings.Add("Text", bs, "Ranking");
            this.pictureBox1.DataBindings.Add("Image", bs, "客戶照片", true);
            


            feedbackManagementBindingNavigator.BindingSource = bs;



        }

        BindingSource bs = new BindingSource();








        private void Btn_chart_Click(object sender, EventArgs e)
        {
            var q= from p in dbContext.FeedbackManagements
                   group p by p.Customer.FirstName  into g
                   select new { 會員 = g.Key, 發言次數 = g.Count() };

            this.Chart_Customer.DataSource = q.ToList();

            this.Chart_Customer.Series[0].XValueMember = "會員";
            this.Chart_Customer.Series[0].YValueMembers = "發言次數";
            this.Chart_Customer.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void Chart_Customer_Click(object sender, EventArgs e)
        {
             

        }
    }
}
