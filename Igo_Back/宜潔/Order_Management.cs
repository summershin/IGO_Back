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
    public partial class Order_Management : Form
    {
        IGOEntities dbContext = new IGOEntities();

        public Order_Management()
        {
            InitializeComponent();

            ShowAllOrders();  //顯示所有訂單
            TextBoxDisEnable(); //無法輸入文字進行查詢
            SetDateTime();  //設定起查詢起始日期
            label3.Visible = false;
            label4.Visible = false;
            btn_Search.Enabled = false;
            timer1.Enabled = true;
            lab_SeatsAlarm.Visible = true;
        }

        private void SetDateTime()
        {
            //設定日期區間
            var q = from o in dbContext.Orders.AsEnumerable()
                    select o.OrderDate.Value.Date;
                   
            DateTime startday = DateTime.Today;
            //DateTime oneday = DateTime;  //TODO: 須扣一天，如何取的一天?
            foreach (DateTime d in q.Distinct())  //設定最早搜尋日期
            {
                if (d < startday)
                {
                    startday = d;
                }
                dateTimePicker_Orders2.Value = startday;
            }
        }

        private void TextBoxDisEnable()
        {
            this.txt_OrderID.Enabled = false;
            this.txt_LastName.Enabled = false;
            this.txt_FirstName.Enabled = false;
            this.dateTimePicker_Shipper.Enabled = false;
            this.txt_PayType.Enabled = false;
            this.dateTimePicker_Orders2.Enabled = false; ;
            this.txt_CusPhone.Enabled = false;
            this.txt_Status.Enabled = false;
            this.dateTimePicker_Shipper.Enabled = false;
            this.dateTimePicker_Orders2.Enabled = false;
        }

        //開啟訂單明細
        private void btn_Details_Click(object sender, EventArgs e)
        {
            ClearDatabinding2();
            

            int orderid = Convert.ToInt32(txt_OrderID.Text);

            var q1 = from od in this.dbContext.OrderDetails
                     where od.OrderID == orderid
                     select new
                     {
                         od.OrderID,
                         od.OrderDetailsID,
                         od.Product.ProductName,
                         od.TicketType.TicketName,
                         od.Price,
                         od.Quantity,
                         od.Product.StartTime,
                         od.Product.EndTime,
                         od.ProductID,
                         od.TicketID,
                         SubCategoryName = od.Product.SubCategory.SubCategoryName,
                         SubCategoryID = od.Product.SubCategoryID
                     };
            //this.dgv_OrderDetails.DataSource = q.ToList();
            this.bindingSource2.DataSource = q1.ToList();
            this.dgv_OrderDetails.DataSource = this.bindingSource2;


            this.txt_OrderDetailsID.DataBindings.Add("Text", this.bindingSource2, "OrderDetailsID");
            this.txt_ProductName.DataBindings.Add("Text", this.bindingSource2, "ProductName");
            this.txt_Quantity.DataBindings.Add("Text", this.bindingSource2, "Quantity");
            this.txt_TicketTpyeName.DataBindings.Add("Text", this.bindingSource2, "TicketName");
            this.Secret_SubcategoryID.DataBindings.Add("Text", this.bindingSource2, "SubCategoryID");
            
                this.txt_ProductID.DataBindings.Add("Text", this.bindingSource2, "ProductID");
            this.txt_TicketID.DataBindings.Add("Text", this.bindingSource2, "TicketID");
            //=========================================================================================


        }



        //手機號碼輸入驗證
        private void txt_CusPhone_TextChanged(object sender, EventArgs e)
        {
            int phone;
            bool isPhoneNum = int.TryParse(txt_CusPhone.Text, out phone);
            if (this.txt_CusPhone.Text == "")
            {
                this.label4.Text = "請輸入數字";
                this.label4.ForeColor = Color.Black;
            }
            else if (isPhoneNum && this.txt_CusPhone.Text.Length == 10)
            {
                this.label4.Text = "輸入格式正確";
                this.label4.ForeColor = Color.Blue;
                btn_Search.Enabled = true;
                btn_Search.Click += btn_Search_Click;               
            }
            else
            {
                this.label4.Text = "輸入格式錯誤";
                this.label4.ForeColor = Color.Red;
            }
        }
        //訂單編號輸入驗證
        private void txt_OrderID_TextChanged(object sender, EventArgs e)
        {
            int orderid;
            
            bool isOrdridNum = int.TryParse(txt_OrderID.Text, out orderid);           
            if (this.txt_OrderID.Text == "") 
            {                
                this.label3.Text = "請輸入數字";
                this.label3.ForeColor = Color.Black;
            }
            else if (isOrdridNum)
            {
                this.label3.Text = "輸入格式正確";
                this.label3.ForeColor = Color.Blue;
                btn_Search.Enabled = true;
                btn_Search.Click += btn_Search_Click;                               
            }
            else
            {
                this.label3.Text = "輸入格式錯誤";
                this.label3.ForeColor = Color.Red;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.dgv_Orders.DataSource = null;
            ClearDatabinding1();
            TextBoxDisEnable();

            if (checkBox_OrderID.Checked == true && checkBox_CusPhone.Checked == true)
            {
                int orderid;
                bool isOrdridNum = int.TryParse(txt_OrderID.Text, out orderid);
                if (isOrdridNum)
                {
                    try
                    {
                        var q = from o in dbContext.Orders
                                where o.OrderID == orderid && o.Customer.Phone == txt_CusPhone.Text
                                select new
                                {
                                    o.OrderID,
                                    o.Customer.LastName,
                                    o.Customer.FirstName,
                                    o.OrderDate,
                                    o.Payment.PayType,
                                    o.ShippedDate,
                                    o.Status.StatusName,
                                    o.Customer.Phone,
                                    o.TotalPrice
                                    //TotalPrice = o.OrderDetails.Sum(a => a.Price * a.Quantity)
                                };

                        this.bindingSource1.DataSource = q.ToList();
                        this.dgv_Orders.DataSource = this.bindingSource1;
                        btn_Search.Enabled = false;
                        ShowOrderInfo();
                    }
                    catch
                    {
                        MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
                    }

                }
            }
            //if (checkBox_OrderDate.Checked == true && checkBox_CusPhone.Checked == true)
            //{
            //    try
            //    {
            //        var q = from o in dbContext.Orders.AsEnumerable()
            //                where o.Customer.Phone == txt_CusPhone.Text && o.OrderDate == dateTimePicker_Orders2.Value /*&& o.OrderDate == dateTimePicker_Orders2.Value.Month*/
            //                select new
            //                {
            //                    o.OrderID,
            //                    o.Customer.LastName,
            //                    o.Customer.FirstName,
            //                    o.OrderDate,
            //                    o.Payment.PayType,
            //                    o.ShippedDate,
            //                    o.Status.StatusName,
            //                    o.Customer.Phone,
            //                    o.TotalPrice
            //                };

            //        this.bindingSource1.DataSource = q.ToList();
            //        this.dgv_Orders.DataSource = this.bindingSource1;
            //        btn_Search.Enabled = false;
            //        ShowOrderInfo();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
            //    }

            //}
            else if (checkBox_OrderDate.Checked == true)
            {
                try
                {
                    var q = from o in dbContext.Orders.AsEnumerable()
                            where o.OrderDate == dateTimePicker_Orders2.Value
                            select new
                            {
                                o.OrderID,
                                o.Customer.LastName,
                                o.Customer.FirstName,
                                o.OrderDate,
                                o.Payment.PayType,
                                o.ShippedDate,
                                o.Status.StatusName,
                                o.Customer.Phone,
                                o.TotalPrice
                            };

                    this.bindingSource1.DataSource = q.ToList();
                    this.dgv_Orders.DataSource = this.bindingSource1;
                    btn_Search.Enabled = false;
                    ShowOrderInfo();
                }
                catch
                {
                    MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
                }
            }
            else if (checkBox_OrderID.Checked == true)
            {
                int orderid;
                bool isOrdridNum = int.TryParse(txt_OrderID.Text, out orderid);
                if (isOrdridNum)
                {
                    try
                    {
                        var q = from o in dbContext.Orders
                                where o.OrderID == orderid
                                select new
                                {
                                    o.OrderID,
                                    o.Customer.LastName,
                                    o.Customer.FirstName,
                                    o.OrderDate,
                                    o.Payment.PayType,
                                    o.ShippedDate,
                                    o.Status.StatusName,
                                    o.Customer.Phone,
                                    o.TotalPrice
                                };

                        this.bindingSource1.DataSource = q.ToList();
                        this.dgv_Orders.DataSource = this.bindingSource1;
                        btn_Search.Enabled = false;
                        ShowOrderInfo();
                    }
                    catch
                    {
                        MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
                    }

                }
            }
            else if (checkBox_CusPhone.Checked == true)
            {
                try
                {
                    var q = from o in dbContext.Orders
                            where o.Customer.Phone == txt_CusPhone.Text
                            select new
                            {
                                o.OrderID,
                                o.Customer.LastName,
                                o.Customer.FirstName,
                                o.OrderDate,
                                o.Payment.PayType,
                                o.ShippedDate,
                                o.Status.StatusName,
                                o.Customer.Phone,
                                o.TotalPrice
                                //TotalPrice = o.OrderDetails.Sum(a => a.Price * a.Quantity)
                            };

                    this.bindingSource1.DataSource = q.ToList();
                    this.dgv_Orders.DataSource = this.bindingSource1;

                    ShowOrderInfo();

                    btn_Search.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
                }
            }
            else
            {
                MessageBox.Show("訂單欄位與手機欄位請輸入數字。");
            }
        }
        private void TextBoxEnable()
        {
            this.txt_OrderID.Enabled = true;
            this.txt_LastName.Enabled = true;
            this.txt_FirstName.Enabled = true;           
            this.txt_PayType.Enabled = true;           
            this.txt_CusPhone.Enabled = true;
            this.txt_Status.Enabled = true;
        }

        private void ClearDatabinding1()
        {
            this.txt_OrderID.DataBindings.Clear();
            this.txt_LastName.DataBindings.Clear();
            this.txt_FirstName.DataBindings.Clear();
            this.dateTimePicker_Shipper.DataBindings.Clear();
            this.txt_PayType.DataBindings.Clear();
            this.dateTimePicker_Shipper.DataBindings.Clear();
            this.dateTimePicker_Orders2.DataBindings.Clear();
            this.txt_CusPhone.DataBindings.Clear();
            this.txt_Status.DataBindings.Clear();           
        }
        private void ClearDatabinding2()
        {
            this.txt_OrderDetailsID.DataBindings.Clear();
            this.txt_ProductName.DataBindings.Clear();
            this.txt_Quantity.DataBindings.Clear();
            this.txt_TicketTpyeName.DataBindings.Clear();
            this.Secret_SubcategoryID.DataBindings.Clear();
            this.txt_ProductID.DataBindings.Clear();
            this.txt_TicketID.DataBindings.Clear();
        }
        //顯示所有訂單
        private void btn_SearchAll_Click(object sender, EventArgs e)
        {
            ClearDatabinding1();
            ShowAllOrders();
            TextBoxDisEnable();
        }

        //方法:顯示所有訂單
        private void ShowAllOrders()
        {
            this.dgv_Orders.DataSource = null;
            ClearDatabinding1();
            comboBox_StatusType.Items.Clear();

            var q1 = from o in dbContext.Orders.AsEnumerable()
                     select new
                     {
                         o.OrderID,
                         o.Customer.LastName,
                         o.Customer.FirstName,
                         o.OrderDate,
                         o.Payment.PayType,
                         o.ShippedDate,
                         o.Status.StatusName,
                         o.Customer.Phone,
                         o.TotalPrice,
                         //Sum = Sum(od => od.Price * od.Quantity)
                        //TODO: 總價格
                       
                    };
            this.bindingSource1.DataSource = q1.ToList();
            this.dgv_Orders.DataSource = this.bindingSource1;

            ShowOrderInfo();          
            //===================================================
            //加入產品型態選單
            var q2 = (from o in dbContext.Orders
                      select o.Status.StatusName).Distinct();

            var Q = q2.ToList();
            for (int i = 0; i < Q.Count(); i++)
            {
                comboBox_StatusType.Items.Add(Q[i]);
            }
            comboBox_StatusType.SelectedIndex = 0;
            //TODO:調整儲存格大小
            //=============================================================================
            //    var Q = q.ToList();
            //    for (int i = 0; i < Q.Count; i++)
            //    {
            //        //int orderid = Q[i].OrderID;

            //        Order order = new Order
            //        {
            //            orderID = Q[i].OrderID,
            //            position = i
            //        };
            //        //positionList.Add(i);  //i=position
            //        orderidList.Add(order);
            //        //orderidDict.Add(i, orderID);
            //        //MessageBox.Show(i.ToString() + " + " + orderID);
            //    }
            //}

            //private void bindingSource1_CurrentChanged(object sender, EventArgs e)
            //{           
            //    int position = bindingSource1.Position;
            //    this.label2.Text = position.ToString();
            //    //int id = position + 1;

            //    string id = txt_OrderID.Text;
            //    this.label2.Text = id;
            //    //int oid = Convert.ToInt32()

            //    var q2 = from od in dbContext.OrderDetails
            //            where od.OrderID == 2
            //            select od;

            //    this.dgv_OrderDetails.DataSource = q2.ToList();

        }

        private void ShowOrderInfo()
        {
            this.txt_OrderID.DataBindings.Add("Text", this.bindingSource1, "OrderID");
            this.txt_LastName.DataBindings.Add("Text", this.bindingSource1, "LastName");
            this.txt_FirstName.DataBindings.Add("Text", this.bindingSource1, "FirstName");
            this.dateTimePicker_Shipper.DataBindings.Add("Value", this.bindingSource1, "ShippedDate");
            this.txt_PayType.DataBindings.Add("Text", this.bindingSource1, "PayType");
            this.dateTimePicker_Orders2.DataBindings.Add("Value", this.bindingSource1, "OrderDate");
            this.txt_CusPhone.DataBindings.Add("Text", this.bindingSource1, "Phone");
            this.txt_Status.DataBindings.Add("Text", this.bindingSource1, "StatusName");
        }



        //進入查詢模式
        private void btn_transferToSearch_Click(object sender, EventArgs e)
        {
            ClearDatabinding1();
            //TextBoxEnable();                       

            if (checkBox_OrderID.Checked == true)
            {
                lab_OrderID.BackColor = Color.LightPink;
                txt_OrderID.Enabled = true;
                txt_OrderID.TextChanged += txt_OrderID_TextChanged;
                label3.Visible = true;
                label3.ForeColor = Color.Black;
                ClearText();
            }
            if (checkBox_CusPhone.Checked == true)
            {
                lab_CusPhone.BackColor = Color.LightPink;
                txt_CusPhone.Enabled = true;
                txt_CusPhone.TextChanged += txt_CusPhone_TextChanged;
                label4.Visible = true;
                label4.ForeColor = Color.Black;
                ClearText();
            }
            if (checkBox_OrderDate.Checked == true) 
            {
                lab_OrderDate.BackColor = Color.LightPink;
                //btn_Search.Enabled = true;

                //btn_Search.Click += btn_Search_Click;
                //dateTimePicker_Orders2.EnabledChanged += dateTimePicker_Orders2_EnableChanged;
                dateTimePicker_Orders2.ValueChanged += dateTimePicker_Orders2_ValChanged;
                dateTimePicker_Orders2.Enabled = true;

            }
            if (checkBox_OrderID.Checked == false)
            {
                lab_OrderID.BackColor = Color.Transparent;
                txt_OrderID.Enabled = false;
            }
            if (checkBox_CusPhone.Checked == false)
            {
                lab_CusPhone.BackColor = Color.Transparent;
                txt_CusPhone.Enabled = false;
            }
            if (checkBox_OrderDate.Checked == false)
            {
               
                lab_OrderDate.BackColor = Color.Transparent;
                dateTimePicker_Orders2.Value = DateTime.Now;
                dateTimePicker_Orders2.Enabled = false;
            }
            if(checkBox_OrderID.Checked == false&& checkBox_CusPhone.Checked == false&& checkBox_OrderDate.Checked == false)
            {
                MessageBox.Show("請勾選欲查詢項目。");
            }
        }

        //private void dateTimePicker_Orders2_EnableChanged(object sender, EventArgs e)
        //{
        //    btn_Search.Enabled = true;
        //    btn_Search.Click += btn_Search_Click;

        //}

        private void dateTimePicker_Orders2_ValChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
            btn_Search.Click += btn_Search_Click;
        }

        private void ClearText()
        {
            this.txt_OrderID.Clear();
            this.txt_LastName.Clear();
            this.txt_FirstName.Clear();
            this.dateTimePicker_Shipper.Value = DateTime.Now;
            this.txt_PayType.DataBindings.Clear();
            this.dateTimePicker_Orders2.Value = DateTime.Now;
            this.txt_CusPhone.Clear();
            this.txt_Status.Clear();
        }

        //更新訂單明細
        private void btn_Update_Click(object sender, EventArgs e)
        {
            int plusQuantity;
            int minusQuantity;

            try
            {
                int orderdetailid = Convert.ToInt32(txt_OrderDetailsID.Text);
                int orderid = Convert.ToInt32(txt_OrderID.Text);

                bool isminusQuantityNum = int.TryParse(txt_MinusQuantity.Text, out minusQuantity);
                bool isplusQuantityNum = int.TryParse(txt_PlusQuantity.Text, out plusQuantity);

                if (isplusQuantityNum && txt_MinusQuantity.Text == "")
                {
                    //愈增加票的單價
                    Decimal UnitPrice = 0;

                    var q2 = from od in this.dbContext.OrderDetails.AsEnumerable()
                             where od.OrderDetailsID == Convert.ToInt32(txt_OrderDetailsID.Text)
                             select new
                             {
                                 od.Price,
                                 od.Quantity,
                                 UnitPrice = od.Price / od.Quantity  //不可除以零 //TODO:Debug
                             };

                    var Q2 = q2.ToList();

                    for (int i = 0; i < Q2.Count; i++)
                    {
                        UnitPrice = Convert.ToInt32(Q2[i].UnitPrice);
                    }
                    //====================================================================================
                    var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                                       where od.OrderDetailsID == orderdetailid
                                       select od).FirstOrDefault();

                    if (orderdetail == null)
                    {
                        return;
                    }
                    else
                    {
                        orderdetail.Quantity = plusQuantity + orderdetail.Quantity;
                        orderdetail.Price = orderdetail.Price + UnitPrice * plusQuantity;
                        this.dbContext.SaveChanges();
                        this.dgv_OrderDetails.DataSource = null;
                        //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                        this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.Where(x => x.OrderDetailsID == orderdetailid).
                   Select(x => new
                   {
                       x.OrderID,
                       x.OrderDetailsID,
                       x.Product.ProductName,
                       x.TicketType.TicketName,
                       x.Price,
                       x.Quantity,
                       x.Product.StartTime,
                       x.Product.EndTime
                   }).ToList();


                    //======================================================================================================
                       

                        this.dgv_Orders.DataSource = null;
                        ClearDatabinding1();

                        var order = (from o in this.dbContext.Orders.AsEnumerable()
                                     where o.OrderID == orderid
                                     select o).FirstOrDefault();

                        if (orderdetail == null)
                        {
                            return;
                        }
                        else
                        {

                            //orderdetail.Quantity = plusQuantity + orderdetail.Quantity;
                            order.TotalPrice = order.TotalPrice + UnitPrice * plusQuantity;
                            this.dbContext.SaveChanges();
                            this.dgv_Orders.DataSource = null;
                            //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                            this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderid).
                       Select(x => new
                       {
                           x.OrderID,
                           x.Customer.LastName,
                           x.Customer.FirstName,
                           x.OrderDate,
                           x.Payment.PayType,
                           x.ShippedDate,
                           x.Status.StatusName,
                           x.Customer.Phone,
                           x.TotalPrice
                       }).ToList();
                        }
                    }
                }
                else if (isminusQuantityNum && txt_PlusQuantity.Text == "")
                {
                    //愈減少票的單價
                    Decimal UnitPrice = 0;

                    var q2 = from od in this.dbContext.OrderDetails.AsEnumerable()
                             where od.OrderDetailsID == Convert.ToInt32(txt_OrderDetailsID.Text)
                             select new
                             {
                                 od.Price,
                                 od.Quantity,
                                 UnitPrice = od.Price / od.Quantity  //不可除以零 //TODO:Debug
                             };

                    var Q2 = q2.ToList();

                    for (int i = 0; i < Q2.Count; i++)
                    {
                        UnitPrice = Convert.ToInt32(Q2[i].UnitPrice);
                    }
                    //====================================================================================
                    var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                                       where od.OrderDetailsID == orderdetailid
                                       select od).FirstOrDefault();

                    if (orderdetail == null)
                    {
                        return;
                    }
                    else
                    {
                        orderdetail.Quantity = orderdetail.Quantity - minusQuantity;
                        orderdetail.Price = orderdetail.Price - UnitPrice * minusQuantity;
                        this.dbContext.SaveChanges();
                        this.dgv_OrderDetails.DataSource = null;
                        //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                        this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.Where(x => x.OrderDetailsID == orderdetailid).
                   Select(x => new
                   {
                       x.OrderID,
                       x.OrderDetailsID,
                       x.Product.ProductName,
                       x.TicketType.TicketName,
                       x.Price,
                       x.Quantity,
                       x.Product.StartTime,
                       x.Product.EndTime
                   }).ToList();


                        //======================================================================================================


                        this.dgv_Orders.DataSource = null;
                        ClearDatabinding1();

                        var order = (from o in this.dbContext.Orders.AsEnumerable()
                                     where o.OrderID == orderid
                                     select o).FirstOrDefault();

                        if (orderdetail == null)
                        {
                            return;
                        }
                        else
                        {

                            //orderdetail.Quantity = plusQuantity + orderdetail.Quantity;
                            order.TotalPrice = order.TotalPrice - UnitPrice * minusQuantity;
                            this.dbContext.SaveChanges();
                            this.dgv_Orders.DataSource = null;
                            //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                            this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderid).
                       Select(x => new
                       {
                           x.OrderID,
                           x.Customer.LastName,
                           x.Customer.FirstName,
                           x.OrderDate,
                           x.Payment.PayType,
                           x.ShippedDate,
                           x.Status.StatusName,
                           x.Customer.Phone,
                           x.TotalPrice
                       }).ToList();
                        }
                    }
                }
                else if ((txt_MinusQuantity.Text == "" && txt_PlusQuantity.Text == "") || (txt_MinusQuantity.Text != "" && txt_PlusQuantity.Text != ""))
                {
                    MessageBox.Show("請選其一修改數量。");
                }
                else
                {
                    MessageBox.Show("請輸入正確數量。");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }           
        }

        //刪除訂單明細
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int orderdetailsID = Convert.ToInt32(txt_OrderDetailsID.Text);
            int orderid = Convert.ToInt32(txt_OrderID.Text);

            Decimal deletePrice = 0;

            var q1 = from od in this.dbContext.OrderDetails
                     where od.OrderDetailsID == orderdetailsID
                     select od.Price;
           
            var Q1 = q1.ToList();
            for (int i = 0; i < Q1.Count; i++)
            {
                deletePrice = Q1[i].Value;
                
            }
            //====================================================================
            var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                               where od.OrderDetailsID == orderdetailsID
                               select od).FirstOrDefault();
            if (orderdetail == null)
            {
                return;
            }
            else
            {
                this.dbContext.OrderDetails.Remove(orderdetail);
                this.dbContext.SaveChanges();
                this.dgv_OrderDetails.DataSource = null;
                //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.Where(x => x.OrderID == orderid).
                  Select(x => new
                  {
                      x.OrderID,
                      x.OrderDetailsID,
                      x.Product.ProductName,
                      x.TicketType.TicketName,
                      x.Price,
                      x.Quantity,
                      x.Product.StartTime,
                      x.Product.EndTime
                  }).ToList();
            }

            //===============================================================================
            this.dgv_Orders.DataSource = null;
            ClearDatabinding1();
            

            var order = (from o in this.dbContext.Orders.AsEnumerable()
                               where o.OrderID == orderid
                         select o).FirstOrDefault();

            if (order == null)
            {
                return;
            }
            else
            {
                //orderdetail.Quantity = plusQuantity + orderdetail.Quantity;
                order.TotalPrice = order.TotalPrice - deletePrice;
                this.dbContext.SaveChanges();
                this.dgv_Orders.DataSource = null;
                //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderid).
           Select(x => new
           {
               x.OrderID,
               x.Customer.LastName,
               x.Customer.FirstName,
               x.OrderDate,
               x.Payment.PayType,
               x.ShippedDate,
               x.Status.StatusName,
               x.Customer.Phone,
               x.TotalPrice
           }).ToList();
            }
        }


        private void btn_UpdateOrders_Click(object sender, EventArgs e)
        {
            //comboBox_StatusType.Items
            int orderID = Convert.ToInt32(txt_OrderID.Text);

            var orders = (from o in this.dbContext.Orders
                                   where o.OrderID == orderID
                          select o).FirstOrDefault();

                if (orders == null)
                {
                    return;
                }
            else
            {
                orders.StatusID = Convert.ToInt32(this.label6.Text)/* + orders.Status.StatusName*/;
                this.dbContext.SaveChanges();
                this.dgv_Orders.DataSource = null;
                //this.dgv_Orders.DataSource = this.dbContext.Orders.ToList();
                this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderID).
                    Select(x => new
                    {
                        x.OrderID,
                        x.Customer.LastName,
                        x.Customer.FirstName,
                        x.OrderDate,
                        x.Payment.PayType,
                        x.ShippedDate,
                        x.Status.StatusName,
                        x.Customer.Phone
                    }).ToList();
            }
        }

        private void comboBox_StatusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statusName = comboBox_StatusType.Text;
            var q = from s in this.dbContext.Status
                    where s.StatusName == statusName
                    select s.StatusID;
            for (int i = 0; i < q.ToList().Count; i++) 
            {
                label6.Text = q.ToList()[i].ToString();
            }
        }

        //查詢訂單明細
        private void btn_SearchOrderDetails_Click(object sender, EventArgs e)
        {
            ClearDatabinding3();
            //this.dgv_OrderDetails = null;

            int orderdetaisID;
            bool isOrderDetailsIDNum = int.TryParse(txt_btn_SearchOrderDetailsID.Text, out orderdetaisID);

            if (isOrderDetailsIDNum)
            {
                var q = from od in this.dbContext.OrderDetails.AsEnumerable()
                        where od.OrderDetailsID == Convert.ToInt32(orderdetaisID)
                        select new
                        {
                            od.OrderID,
                            od.OrderDetailsID,
                            od.Product.ProductName,
                            od.TicketType.TicketName,
                            od.Price,
                            od.Quantity,
                            od.Product.StartTime,
                            od.Product.EndTime,
                            od.ProductID,
                            od.TicketID
                        };
                this.bindingSource3.DataSource = q.ToList();
                this.dgv_OrderDetails.DataSource = this.bindingSource3;

                this.txt_OrderDetailsID.DataBindings.Add("Text", this.bindingSource3, "OrderDetailsID");
                this.txt_ProductName.DataBindings.Add("Text", this.bindingSource3, "ProductName");
                this.txt_Quantity.DataBindings.Add("Text", this.bindingSource3, "Quantity");
                this.txt_TicketTpyeName.DataBindings.Add("Text", this.bindingSource3, "TicketName");
                this.txt_ProductID.DataBindings.Add("Text", this.bindingSource3, "ProductID");
                this.txt_TicketID.DataBindings.Add("Text", this.bindingSource3, "TicketID");
            }
            else
            {
                MessageBox.Show("請輸入數字。");
            }
        }

        private void ClearDatabinding3()
        {
            this.txt_OrderDetailsID.DataBindings.Clear();
            this.txt_ProductName.DataBindings.Clear();
            this.txt_Quantity.DataBindings.Clear();
            this.txt_TicketTpyeName.DataBindings.Clear();
            this.Secret_SubcategoryID.DataBindings.Clear();
            this.txt_ProductID.DataBindings.Clear();
            this.txt_TicketID.DataBindings.Clear();
        }

        //查詢所有訂單明細
        private void btn_SearchAllOrderdetails_Click(object sender, EventArgs e)
        {
            ClearDatabinding3();

            var q = from od in this.dbContext.OrderDetails
                    select new
                    {
                        od.OrderID,
                        od.OrderDetailsID,
                        od.Product.ProductName,
                        od.TicketType.TicketName,
                        od.Price,
                        od.Quantity,
                        od.Product.StartTime,
                        od.Product.EndTime,
                        od.ProductID,
                        od.TicketID,
                        SubCategoryName = od.Product.SubCategory.SubCategoryName,
                        SubCategoryID = od.Product.SubCategoryID
                    };

            this.bindingSource3.DataSource = q.ToList();
            this.dgv_OrderDetails.DataSource = this.bindingSource3;

            //Databinding3Clear();
            this.txt_OrderDetailsID.DataBindings.Add("Text", this.bindingSource3, "OrderDetailsID");
            this.txt_ProductName.DataBindings.Add("Text", this.bindingSource3, "ProductName");
            this.txt_Quantity.DataBindings.Add("Text", this.bindingSource3, "Quantity");
            this.txt_TicketTpyeName.DataBindings.Add("Text", this.bindingSource3, "TicketName");
            this.Secret_SubcategoryID.DataBindings.Add("Text", this.bindingSource3, "SubCategoryID");
            this.txt_ProductID.DataBindings.Add("Text", this.bindingSource3, "ProductID");
            this.txt_TicketID.DataBindings.Add("Text", this.bindingSource3, "TicketID");
        }


        private void dgv_OrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            dgv_Seats.DataSource = null;
            this.Secret_SeatID.DataBindings.Clear();
            

            if (Secret_SubcategoryID.Text == "3")
            {
                //int quantity = Convert.ToInt32(txt_Quantity.Text);
                //Secret_Quantity.Text = quantity.ToString();

                var q1 = from s in this.dbContext.Seats.AsEnumerable()
                         where s.OrderDetailID== Convert.ToInt32(txt_OrderDetailsID.Text) /*&& s.OrderOrNot == true*/
                         select new
                         {
                             s.OrderDetailID,
                             s.Product.ProductName,
                             s.SeatName,
                             s.SeatID                            
                         };
                //this.dgv_Seats.DataSource = q2.ToList();
                this.bindingSource4.DataSource = q1.ToList();
                this.dgv_Seats.DataSource = this.bindingSource4;
                this.Secret_SeatID.DataBindings.Add("Text", this.bindingSource4, "SeatID");
                //timer1.Enabled = true;

                //========================================================================================
                //TODO:沒抓到實際數量
                int quantity = Convert.ToInt32(txt_Quantity.Text);
                Secret_Quantity.Text = quantity.ToString();

                if (quantity > 1)
                {
                    var q2 = from od in this.dbContext.OrderDetails.AsEnumerable()
                             where od.OrderDetailsID == Convert.ToInt32(txt_OrderDetailsID.Text)
                             select new
                             {
                                 od.Price,
                                 od.Quantity,
                                 UnitPrice = od.Price / od.Quantity  //不可除以零 //TODO:Debug
                             };

                    var Q2 = q2.ToList();

                    for (int i = 0; i < Q2.Count; i++)
                    {
                        Secret_UnitPrice.Text = Q2[i].UnitPrice.ToString();
                    }
                    quantity = quantity - 1;
                }
                else if (quantity == 1)
                {
                    var q2 = from od in this.dbContext.OrderDetails.AsEnumerable()
                             where od.OrderDetailsID == Convert.ToInt32(txt_OrderDetailsID.Text)
                             select new
                             {
                                 od.Price,
                                 od.Quantity,
                                 UnitPrice = 0  //不可除以零 //TODO:Debug
                             };
                    var Q2 = q2.ToList();
                    for (int i = 0; i < Q2.Count; i++)
                    {
                        Secret_UnitPrice.Text = Q2[i].UnitPrice.ToString();
                    }
                    quantity = quantity - 1;
                }
                else if(quantity==0) 
                {
                    MessageBox.Show("已無電影票");
                }
                

            }
            else
            {
                dgv_Seats.DataSource = null;
                //timer1.Enabled = false;
                //lab_SeatsAlarm.Visible = false;

                return;
            }
        }

        private void bindingSource2_DataSourceChanged(object sender, EventArgs e)
        {
            dgv_Seats.DataSource = null;
            //timer1.Enabled = false;
            //lab_SeatsAlarm.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lab_SeatsAlarm.Visible = true;
            string newst = lab_SeatsAlarm.Text.Substring(0, 1); //第一個字
            lab_SeatsAlarm.Text = lab_SeatsAlarm.Text.Substring(1, lab_SeatsAlarm.Text.Length - 1) + newst;
        }

        private void btn_DeleteMovieTicket_Click(object sender, EventArgs e)
        {
            this.Secret_Quantity.DataBindings.Clear();

            //只刪除座位表
            int orderdetailsID = Convert.ToInt32(txt_OrderDetailsID.Text);
            int seatid = Convert.ToInt32(Secret_SeatID.Text);
            int orderID = Convert.ToInt32(txt_OrderID.Text);
            int quantity = Convert.ToInt32(Secret_Quantity.Text);
            int deleteUnitprice = Convert.ToInt32(Secret_UnitPrice.Text);

            //////刪除seatandorder的seatID
            //var seatandorder = (from so1 in this.dbContext.SeatAndOrders.AsEnumerable()
            //                    where so1.SeatID == seatid
            //                    select so1).FirstOrDefault();
            //if (seatandorder == null)
            //{
            //    return;
            //}
            //else
            //{
            //    this.dbContext.SeatAndOrders.Remove(seatandorder);  //SeatsAndOrders

            //    this.dbContext.SaveChanges();
            //    //this.dgv_Seats.DataSource = null;
            //    //this.dgv_Seats.DataSource = this.dbContext.SeatAndOrders.ToList();
            //}


            //刪除Seat的seatID
            var seat = (from s in this.dbContext.Seats.AsEnumerable()
                            where s.SeatID == seatid
                            select s).FirstOrDefault();

                if (seat == null)
                {
                    return;
                }
                else
                {
                    //this.dbContext.Seats.Remove(seat); //Seats中的欄位會直接刪除
                    seat.OrderDetailID = null;//Seats中的Orderdetail欄位會變成null，OrderOrNot = false
                    this.dbContext.SaveChanges();
                    this.dgv_Seats.DataSource = null;
                this.dgv_Seats.DataSource = this.dbContext.Seats.ToList();


            }

            if (quantity > 1)
            {
                //訂單明細價格改變  //TODO       

                var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                                   where od.OrderDetailsID == orderdetailsID
                                   select od).FirstOrDefault();
                if (orderdetail == null)
                {
                    return;
                }
                else
                {
                    //Decimal deleteUnitprice = Convert.ToInt32(Secret_UnitPrice.Text);
                    orderdetail.Price = orderdetail.Price - deleteUnitprice;
                    orderdetail.Quantity = orderdetail.Quantity - 1;
                    this.dbContext.SaveChanges();
                    this.dgv_OrderDetails.DataSource = null;
                    //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                    this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.Where(x => x.OrderDetailsID == orderdetailsID).
           Select(x => new
           {
               x.OrderID,
               x.OrderDetailsID,
               x.Product.ProductName,
               x.TicketType.TicketName,
               x.Price,
               x.Quantity,
               x.Product.StartTime,
               x.Product.EndTime,
               SubCategoryName = x.Product.SubCategory.SubCategoryName,
               SubCategoryID = x.Product.SubCategoryID
           }).ToList();

                    Secret_Quantity.Text = orderdetail.Quantity.ToString();
                }

                //訂單總價格改變
                var order = (from o in this.dbContext.Orders.AsEnumerable()
                             where o.OrderID == orderID
                             select o).FirstOrDefault();
                if (order == null)
                {
                    return;
                }
                else
                {
                    //Decimal deleteUnitprice = Convert.ToInt32(Secret_UnitPrice.Text);
                    order.TotalPrice = order.TotalPrice - deleteUnitprice;
                    this.dbContext.SaveChanges();
                    this.dgv_Orders.DataSource = null;
                    this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderID).
                        Select(x => new
                        {
                            x.OrderID,
                            x.Customer.LastName,
                            x.Customer.FirstName,
                            x.OrderDate,
                            x.Payment.PayType,
                            x.ShippedDate,
                            x.Status.StatusName,
                            x.Customer.Phone,
                            x.TotalPrice
                        }).ToList();
                }
            }
            else if(quantity ==1) 
            {
                //訂單明細價格改變  //TODO       

                var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                                   where od.OrderDetailsID == orderdetailsID
                                   select od).FirstOrDefault();
                if (orderdetail == null)
                {
                    return;
                }
                else
                {
                    //Decimal deleteUnitprice = Convert.ToInt32(Secret_UnitPrice.Text);
                    orderdetail.Price = 0;
                    orderdetail.Quantity = orderdetail.Quantity - 1;
                    this.dbContext.SaveChanges();
                    this.dgv_OrderDetails.DataSource = null;
                    this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                    Secret_Quantity.Text = orderdetail.Quantity.ToString();
                }
                //訂單總價格改變
                var order = (from o in this.dbContext.Orders.AsEnumerable()
                             where o.OrderID == orderID
                             select o).FirstOrDefault();
                if (order == null)
                {
                    return;
                }
                else
                {
                    //Decimal deleteUnitprice = Convert.ToInt32(Secret_UnitPrice.Text);
                    order.TotalPrice = order.TotalPrice - deleteUnitprice;
                    this.dbContext.SaveChanges();
                    this.dgv_Orders.DataSource = null;
                    this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderID).
                        Select(x => new
                        {
                            x.OrderID,
                            x.Customer.LastName,
                            x.Customer.FirstName,
                            x.OrderDate,
                            x.Payment.PayType,
                            x.ShippedDate,
                            x.Status.StatusName,
                            x.Customer.Phone,
                            x.TotalPrice
                        }).ToList();
                }

            }


            //==============================================================================           
            //TODO:刪除整筆電影訂單明細         
            //==============================================================================
        }
        //熱銷產品分析
        private void btn_bestseller_Click(object sender, EventArgs e)
        {
            BestSellerAnalysis f = new BestSellerAnalysis();
            f.Show();
        }

        private void btn_DeleteMovie_Click(object sender, EventArgs e)
        {
            int orderdetailsID = Convert.ToInt32(txt_OrderDetailsID.Text);
            int seatid = Convert.ToInt32(Secret_SeatID.Text);
            int orderid = Convert.ToInt32(txt_OrderID.Text);           

            Decimal deletePrice = 0;

            var q1 = from od in this.dbContext.OrderDetails.AsEnumerable()
                     where od.OrderDetailsID == orderdetailsID
                     select od.Price;

            var Q1 = q1.ToList();
            for (int i = 0; i < Q1.Count; i++)
            {
                deletePrice = Q1[i].Value;

            }
            //====================================================================
            var orderdetail = (from od in this.dbContext.OrderDetails.AsEnumerable()
                               where od.OrderDetailsID == orderdetailsID
                               select od).FirstOrDefault();
            if (orderdetail == null)
            {
                return;
            }
            else
            {
                this.dbContext.OrderDetails.Remove(orderdetail);

                this.dbContext.SaveChanges();
                this.dgv_OrderDetails.DataSource = null;
                //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();

                this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.Where(x => x.OrderID == orderid).
                   Select(x => new
                   {
                       x.OrderID,
                       x.OrderDetailsID,
                       x.Product.ProductName,
                       x.TicketType.TicketName,
                       x.Price,
                       x.Quantity,
                       x.Product.StartTime,
                       x.Product.EndTime
                   }).ToList();
            }

            //刪除Seat的seatID
            var seat = (from s in this.dbContext.Seats.AsEnumerable()
                        where s.SeatID == seatid
                        select s).FirstOrDefault();

            if (seat == null)
            {
                return;
            }
            else
            {
                //this.dbContext.Seats.Remove(seat); //Seats中的欄位會直接刪除
                seat.OrderDetailID = null;//Seats中的Orderdetail欄位會變成null，OrderOrNot = false
                //seat.OrderOrNot = false;   //OrderOrNot = false
                this.dbContext.SaveChanges();
                this.dgv_Seats.DataSource = null;
                //this.dgv_Seats.DataSource = this.dbContext.Seats.ToList();

                //===============================================================================
                this.dgv_Orders.DataSource = null;
                ClearDatabinding1();
                

                var order = (from o in this.dbContext.Orders.AsEnumerable()
                             where o.OrderID == orderid
                             select o).FirstOrDefault();

                if (orderdetail == null)
                {
                    return;
                }
                else
                {
                    //orderdetail.Quantity = plusQuantity + orderdetail.Quantity;
                    order.TotalPrice = order.TotalPrice - deletePrice;
                    this.dbContext.SaveChanges();
                    this.dgv_Orders.DataSource = null;
                    //this.dgv_OrderDetails.DataSource = this.dbContext.OrderDetails.ToList();
                    this.dgv_Orders.DataSource = this.dbContext.Orders.Where(x => x.OrderID == orderid).
               Select(x => new
               {
                   x.OrderID,
                   x.Customer.LastName,
                   x.Customer.FirstName,
                   x.OrderDate,
                   x.Payment.PayType,
                   x.ShippedDate,
                   x.Status.StatusName,
                   x.Customer.Phone,
                   x.TotalPrice
               }).ToList();
                }
            }
        }
    }
    
}
