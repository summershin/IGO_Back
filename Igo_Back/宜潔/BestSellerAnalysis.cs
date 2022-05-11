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
    public partial class BestSellerAnalysis : Form
    {
        public BestSellerAnalysis()
        {
            InitializeComponent();
        }

        IGOEntities dbContext = new IGOEntities();
        private void BestSellerAnalysis_Load(object sender, EventArgs e)
        {            
            var q = from od in this.dbContext.OrderDetails
                    group od by od.Product.ProductName into g
                    select new
                    {
                        ProductName = g.Key,
                        QuantitySold = g.Sum(od=>od.Quantity)
                        //Count = g.Count(x => x.Quantity)
                    };
            //this.dataGridView1.DataSource = q.ToList();

            this.chart1.DataSource = q.ToList();

            this.chart1.Series[0].XValueMember = "ProductName";  //x軸
            this.chart1.Series[0].YValueMembers = "QuantitySold"; //y軸
            this.chart1.Series[0].Name = "產品銷售數量";
            this.chart1.Series[0].IsValueShownAsLabel = true;
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }
    }
}
