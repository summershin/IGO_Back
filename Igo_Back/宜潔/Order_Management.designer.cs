
namespace IGO
{
    partial class Order_Management
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.dgv_OrderDetails = new System.Windows.Forms.DataGridView();
            this.lab_OrderDetailsID = new System.Windows.Forms.Label();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.lab_OrderID = new System.Windows.Forms.Label();
            this.lab_LatName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lab_FirstName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lab_OrderDate = new System.Windows.Forms.Label();
            this.txt_OrderDetailsID = new System.Windows.Forms.TextBox();
            this.lab_PayType = new System.Windows.Forms.Label();
            this.txt_PayType = new System.Windows.Forms.TextBox();
            this.lab_ShippedDate = new System.Windows.Forms.Label();
            this.lab_Status = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.btn_OpenDetails = new System.Windows.Forms.Button();
            this.dateTimePicker_Orders2 = new System.Windows.Forms.DateTimePicker();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Shipper = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lab_CusPhone = new System.Windows.Forms.Label();
            this.btn_advanceSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SearchAll = new System.Windows.Forms.Button();
            this.txt_CusPhone = new System.Windows.Forms.TextBox();
            this.checkBox_OrderID = new System.Windows.Forms.CheckBox();
            this.checkBox_CusPhone = new System.Windows.Forms.CheckBox();
            this.lab_ProductName = new System.Windows.Forms.Label();
            this.lab_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lab_TicketTpyeName = new System.Windows.Forms.Label();
            this.txt_TicketTpyeName = new System.Windows.Forms.TextBox();
            this.btn_UpdateOrderDetails = new System.Windows.Forms.Button();
            this.txt_MinusQuantity = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_OrderDate = new System.Windows.Forms.CheckBox();
            this.btn_UpdateOrders = new System.Windows.Forms.Button();
            this.comboBox_StatusType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PlusQuantity = new System.Windows.Forms.TextBox();
            this.lab_Plus = new System.Windows.Forms.Label();
            this.lab_Minus = new System.Windows.Forms.Label();
            this.btn_SearchOrderDetails = new System.Windows.Forms.Button();
            this.txt_btn_SearchOrderDetailsID = new System.Windows.Forms.TextBox();
            this.btn_SearchAllOrderdetails = new System.Windows.Forms.Button();
            this.dgv_Seats = new System.Windows.Forms.DataGridView();
            this.Secret_SubcategoryID = new System.Windows.Forms.Label();
            this.lab_SeatsAlarm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Secret_SeatID = new System.Windows.Forms.Label();
            this.btn_DeleteMovieTicket = new System.Windows.Forms.Button();
            this.Secret_UnitPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteMovie = new System.Windows.Forms.Button();
            this.groupBox_Orders = new System.Windows.Forms.GroupBox();
            this.btn_bestseller = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lab_TicketID = new System.Windows.Forms.Label();
            this.lab_ProductID = new System.Windows.Forms.Label();
            this.txt_TicketID = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.Secret_Quantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Orders.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Location = new System.Drawing.Point(9, 336);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Orders.RowHeadersWidth = 62;
            this.dgv_Orders.RowTemplate.Height = 31;
            this.dgv_Orders.Size = new System.Drawing.Size(614, 385);
            this.dgv_Orders.TabIndex = 0;
            // 
            // dgv_OrderDetails
            // 
            this.dgv_OrderDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetails.Location = new System.Drawing.Point(6, 336);
            this.dgv_OrderDetails.Name = "dgv_OrderDetails";
            this.dgv_OrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_OrderDetails.RowHeadersWidth = 62;
            this.dgv_OrderDetails.RowTemplate.Height = 31;
            this.dgv_OrderDetails.Size = new System.Drawing.Size(511, 385);
            this.dgv_OrderDetails.TabIndex = 1;
            this.dgv_OrderDetails.SelectionChanged += new System.EventHandler(this.dgv_OrderDetails_SelectionChanged);
            // 
            // lab_OrderDetailsID
            // 
            this.lab_OrderDetailsID.AutoSize = true;
            this.lab_OrderDetailsID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderDetailsID.Location = new System.Drawing.Point(26, 79);
            this.lab_OrderDetailsID.Name = "lab_OrderDetailsID";
            this.lab_OrderDetailsID.Size = new System.Drawing.Size(118, 23);
            this.lab_OrderDetailsID.TabIndex = 3;
            this.lab_OrderDetailsID.Text = "訂單明細編號";
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OrderID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_OrderID.Location = new System.Drawing.Point(105, 73);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(170, 31);
            this.txt_OrderID.TabIndex = 4;
            // 
            // lab_OrderID
            // 
            this.lab_OrderID.AutoSize = true;
            this.lab_OrderID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderID.Location = new System.Drawing.Point(17, 75);
            this.lab_OrderID.Name = "lab_OrderID";
            this.lab_OrderID.Size = new System.Drawing.Size(82, 23);
            this.lab_OrderID.TabIndex = 5;
            this.lab_OrderID.Text = "訂單編號";
            // 
            // lab_LatName
            // 
            this.lab_LatName.AutoSize = true;
            this.lab_LatName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_LatName.Location = new System.Drawing.Point(281, 75);
            this.lab_LatName.Name = "lab_LatName";
            this.lab_LatName.Size = new System.Drawing.Size(82, 23);
            this.lab_LatName.TabIndex = 7;
            this.lab_LatName.Text = "會員姓氏";
            // 
            // txt_LastName
            // 
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LastName.Location = new System.Drawing.Point(369, 73);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            this.txt_LastName.Size = new System.Drawing.Size(157, 31);
            this.txt_LastName.TabIndex = 6;
            // 
            // lab_FirstName
            // 
            this.lab_FirstName.AutoSize = true;
            this.lab_FirstName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_FirstName.Location = new System.Drawing.Point(281, 133);
            this.lab_FirstName.Name = "lab_FirstName";
            this.lab_FirstName.Size = new System.Drawing.Size(82, 23);
            this.lab_FirstName.TabIndex = 9;
            this.lab_FirstName.Text = "會員名字";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_FirstName.Location = new System.Drawing.Point(366, 125);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.ReadOnly = true;
            this.txt_FirstName.Size = new System.Drawing.Size(160, 31);
            this.txt_FirstName.TabIndex = 8;
            // 
            // lab_OrderDate
            // 
            this.lab_OrderDate.AutoSize = true;
            this.lab_OrderDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderDate.Location = new System.Drawing.Point(14, 202);
            this.lab_OrderDate.Name = "lab_OrderDate";
            this.lab_OrderDate.Size = new System.Drawing.Size(82, 23);
            this.lab_OrderDate.TabIndex = 11;
            this.lab_OrderDate.Text = "訂單日期";
            // 
            // txt_OrderDetailsID
            // 
            this.txt_OrderDetailsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OrderDetailsID.Enabled = false;
            this.txt_OrderDetailsID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_OrderDetailsID.Location = new System.Drawing.Point(150, 75);
            this.txt_OrderDetailsID.Name = "txt_OrderDetailsID";
            this.txt_OrderDetailsID.Size = new System.Drawing.Size(93, 31);
            this.txt_OrderDetailsID.TabIndex = 10;
            // 
            // lab_PayType
            // 
            this.lab_PayType.AutoSize = true;
            this.lab_PayType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_PayType.Location = new System.Drawing.Point(17, 250);
            this.lab_PayType.Name = "lab_PayType";
            this.lab_PayType.Size = new System.Drawing.Size(82, 23);
            this.lab_PayType.TabIndex = 13;
            this.lab_PayType.Text = "付款方式";
            // 
            // txt_PayType
            // 
            this.txt_PayType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PayType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_PayType.Location = new System.Drawing.Point(102, 248);
            this.txt_PayType.Name = "txt_PayType";
            this.txt_PayType.ReadOnly = true;
            this.txt_PayType.Size = new System.Drawing.Size(176, 31);
            this.txt_PayType.TabIndex = 12;
            // 
            // lab_ShippedDate
            // 
            this.lab_ShippedDate.AutoSize = true;
            this.lab_ShippedDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ShippedDate.Location = new System.Drawing.Point(281, 202);
            this.lab_ShippedDate.Name = "lab_ShippedDate";
            this.lab_ShippedDate.Size = new System.Drawing.Size(82, 23);
            this.lab_ShippedDate.TabIndex = 15;
            this.lab_ShippedDate.Text = "出貨日期";
            // 
            // lab_Status
            // 
            this.lab_Status.AutoSize = true;
            this.lab_Status.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Status.Location = new System.Drawing.Point(281, 252);
            this.lab_Status.Name = "lab_Status";
            this.lab_Status.Size = new System.Drawing.Size(82, 23);
            this.lab_Status.TabIndex = 17;
            this.lab_Status.Text = "訂單狀態";
            // 
            // txt_Status
            // 
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Status.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Status.Location = new System.Drawing.Point(366, 247);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(160, 31);
            this.txt_Status.TabIndex = 16;
            // 
            // btn_OpenDetails
            // 
            this.btn_OpenDetails.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_OpenDetails.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OpenDetails.Location = new System.Drawing.Point(626, 495);
            this.btn_OpenDetails.Name = "btn_OpenDetails";
            this.btn_OpenDetails.Size = new System.Drawing.Size(101, 40);
            this.btn_OpenDetails.TabIndex = 21;
            this.btn_OpenDetails.Text = "開啟明細";
            this.btn_OpenDetails.UseVisualStyleBackColor = false;
            this.btn_OpenDetails.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // dateTimePicker_Orders2
            // 
            this.dateTimePicker_Orders2.Enabled = false;
            this.dateTimePicker_Orders2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Orders2.Location = new System.Drawing.Point(102, 199);
            this.dateTimePicker_Orders2.Name = "dateTimePicker_Orders2";
            this.dateTimePicker_Orders2.Size = new System.Drawing.Size(173, 31);
            this.dateTimePicker_Orders2.TabIndex = 22;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductName.Enabled = false;
            this.txt_ProductName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductName.Location = new System.Drawing.Point(148, 118);
            this.txt_ProductName.Multiline = true;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(192, 53);
            this.txt_ProductName.TabIndex = 24;
            // 
            // dateTimePicker_Shipper
            // 
            this.dateTimePicker_Shipper.Enabled = false;
            this.dateTimePicker_Shipper.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Shipper.Location = new System.Drawing.Point(366, 196);
            this.dateTimePicker_Shipper.Name = "dateTimePicker_Shipper";
            this.dateTimePicker_Shipper.Size = new System.Drawing.Size(160, 31);
            this.dateTimePicker_Shipper.TabIndex = 25;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(593, 197);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 33);
            this.btn_Search.TabIndex = 26;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lab_CusPhone
            // 
            this.lab_CusPhone.AutoSize = true;
            this.lab_CusPhone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_CusPhone.Location = new System.Drawing.Point(17, 134);
            this.lab_CusPhone.Name = "lab_CusPhone";
            this.lab_CusPhone.Size = new System.Drawing.Size(82, 23);
            this.lab_CusPhone.TabIndex = 28;
            this.lab_CusPhone.Text = "會員電話";
            // 
            // btn_advanceSearch
            // 
            this.btn_advanceSearch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_advanceSearch.Location = new System.Drawing.Point(30, 116);
            this.btn_advanceSearch.Name = "btn_advanceSearch";
            this.btn_advanceSearch.Size = new System.Drawing.Size(106, 33);
            this.btn_advanceSearch.TabIndex = 29;
            this.btn_advanceSearch.Text = "進階查詢";
            this.btn_advanceSearch.UseVisualStyleBackColor = true;
            this.btn_advanceSearch.Click += new System.EventHandler(this.btn_transferToSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "請輸入數字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "請輸入數字";
            // 
            // btn_SearchAll
            // 
            this.btn_SearchAll.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SearchAll.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SearchAll.Location = new System.Drawing.Point(18, 27);
            this.btn_SearchAll.Name = "btn_SearchAll";
            this.btn_SearchAll.Size = new System.Drawing.Size(133, 33);
            this.btn_SearchAll.TabIndex = 32;
            this.btn_SearchAll.Text = "查詢全部訂單";
            this.btn_SearchAll.UseVisualStyleBackColor = false;
            this.btn_SearchAll.Click += new System.EventHandler(this.btn_SearchAll_Click);
            // 
            // txt_CusPhone
            // 
            this.txt_CusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CusPhone.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CusPhone.Location = new System.Drawing.Point(105, 131);
            this.txt_CusPhone.Name = "txt_CusPhone";
            this.txt_CusPhone.Size = new System.Drawing.Size(170, 31);
            this.txt_CusPhone.TabIndex = 27;
            // 
            // checkBox_OrderID
            // 
            this.checkBox_OrderID.AutoSize = true;
            this.checkBox_OrderID.Location = new System.Drawing.Point(30, 21);
            this.checkBox_OrderID.Name = "checkBox_OrderID";
            this.checkBox_OrderID.Size = new System.Drawing.Size(108, 27);
            this.checkBox_OrderID.TabIndex = 33;
            this.checkBox_OrderID.Text = "訂單編號";
            this.checkBox_OrderID.UseVisualStyleBackColor = true;
            // 
            // checkBox_CusPhone
            // 
            this.checkBox_CusPhone.AutoSize = true;
            this.checkBox_CusPhone.Location = new System.Drawing.Point(30, 52);
            this.checkBox_CusPhone.Name = "checkBox_CusPhone";
            this.checkBox_CusPhone.Size = new System.Drawing.Size(108, 27);
            this.checkBox_CusPhone.TabIndex = 34;
            this.checkBox_CusPhone.Text = "會員電話";
            this.checkBox_CusPhone.UseVisualStyleBackColor = true;
            // 
            // lab_ProductName
            // 
            this.lab_ProductName.AutoSize = true;
            this.lab_ProductName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ProductName.Location = new System.Drawing.Point(54, 123);
            this.lab_ProductName.Name = "lab_ProductName";
            this.lab_ProductName.Size = new System.Drawing.Size(82, 23);
            this.lab_ProductName.TabIndex = 36;
            this.lab_ProductName.Text = "產品名稱";
            // 
            // lab_Quantity
            // 
            this.lab_Quantity.AutoSize = true;
            this.lab_Quantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Quantity.Location = new System.Drawing.Point(54, 178);
            this.lab_Quantity.Name = "lab_Quantity";
            this.lab_Quantity.Size = new System.Drawing.Size(82, 23);
            this.lab_Quantity.TabIndex = 38;
            this.lab_Quantity.Text = "產品數量";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Enabled = false;
            this.txt_Quantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Quantity.Location = new System.Drawing.Point(148, 176);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(194, 31);
            this.txt_Quantity.TabIndex = 37;
            // 
            // lab_TicketTpyeName
            // 
            this.lab_TicketTpyeName.AutoSize = true;
            this.lab_TicketTpyeName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_TicketTpyeName.Location = new System.Drawing.Point(54, 281);
            this.lab_TicketTpyeName.Name = "lab_TicketTpyeName";
            this.lab_TicketTpyeName.Size = new System.Drawing.Size(82, 23);
            this.lab_TicketTpyeName.TabIndex = 40;
            this.lab_TicketTpyeName.Text = "產品型態";
            // 
            // txt_TicketTpyeName
            // 
            this.txt_TicketTpyeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TicketTpyeName.Enabled = false;
            this.txt_TicketTpyeName.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_TicketTpyeName.Location = new System.Drawing.Point(151, 273);
            this.txt_TicketTpyeName.Name = "txt_TicketTpyeName";
            this.txt_TicketTpyeName.Size = new System.Drawing.Size(189, 31);
            this.txt_TicketTpyeName.TabIndex = 39;
            // 
            // btn_UpdateOrderDetails
            // 
            this.btn_UpdateOrderDetails.BackColor = System.Drawing.Color.LightPink;
            this.btn_UpdateOrderDetails.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_UpdateOrderDetails.Location = new System.Drawing.Point(352, 210);
            this.btn_UpdateOrderDetails.Name = "btn_UpdateOrderDetails";
            this.btn_UpdateOrderDetails.Size = new System.Drawing.Size(102, 33);
            this.btn_UpdateOrderDetails.TabIndex = 41;
            this.btn_UpdateOrderDetails.Text = "修改";
            this.btn_UpdateOrderDetails.UseVisualStyleBackColor = false;
            this.btn_UpdateOrderDetails.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_MinusQuantity
            // 
            this.txt_MinusQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MinusQuantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_MinusQuantity.Location = new System.Drawing.Point(270, 213);
            this.txt_MinusQuantity.Name = "txt_MinusQuantity";
            this.txt_MinusQuantity.Size = new System.Drawing.Size(69, 31);
            this.txt_MinusQuantity.TabIndex = 42;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Location = new System.Drawing.Point(16, 78);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 42);
            this.btn_Delete.TabIndex = 43;
            this.btn_Delete.Text = "刪除訂單明細";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(145, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "選擇欲增加或減少產品的數量";
            // 
            // checkBox_OrderDate
            // 
            this.checkBox_OrderDate.AutoSize = true;
            this.checkBox_OrderDate.Location = new System.Drawing.Point(30, 83);
            this.checkBox_OrderDate.Name = "checkBox_OrderDate";
            this.checkBox_OrderDate.Size = new System.Drawing.Size(108, 27);
            this.checkBox_OrderDate.TabIndex = 35;
            this.checkBox_OrderDate.Text = "訂單日期";
            this.checkBox_OrderDate.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateOrders
            // 
            this.btn_UpdateOrders.BackColor = System.Drawing.Color.LightPink;
            this.btn_UpdateOrders.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_UpdateOrders.Location = new System.Drawing.Point(532, 288);
            this.btn_UpdateOrders.Name = "btn_UpdateOrders";
            this.btn_UpdateOrders.Size = new System.Drawing.Size(102, 33);
            this.btn_UpdateOrders.TabIndex = 49;
            this.btn_UpdateOrders.Text = "修改";
            this.btn_UpdateOrders.UseVisualStyleBackColor = false;
            this.btn_UpdateOrders.Click += new System.EventHandler(this.btn_UpdateOrders_Click);
            // 
            // comboBox_StatusType
            // 
            this.comboBox_StatusType.FormattingEnabled = true;
            this.comboBox_StatusType.Location = new System.Drawing.Point(532, 246);
            this.comboBox_StatusType.Name = "comboBox_StatusType";
            this.comboBox_StatusType.Size = new System.Drawing.Size(121, 31);
            this.comboBox_StatusType.TabIndex = 50;
            this.comboBox_StatusType.SelectedIndexChanged += new System.EventHandler(this.comboBox_StatusType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(791, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "label6";
            // 
            // txt_PlusQuantity
            // 
            this.txt_PlusQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PlusQuantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_PlusQuantity.Location = new System.Drawing.Point(175, 213);
            this.txt_PlusQuantity.Name = "txt_PlusQuantity";
            this.txt_PlusQuantity.Size = new System.Drawing.Size(60, 31);
            this.txt_PlusQuantity.TabIndex = 52;
            // 
            // lab_Plus
            // 
            this.lab_Plus.AutoSize = true;
            this.lab_Plus.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Plus.Location = new System.Drawing.Point(143, 219);
            this.lab_Plus.Name = "lab_Plus";
            this.lab_Plus.Size = new System.Drawing.Size(27, 25);
            this.lab_Plus.TabIndex = 53;
            this.lab_Plus.Text = "+";
            // 
            // lab_Minus
            // 
            this.lab_Minus.AutoSize = true;
            this.lab_Minus.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Minus.Location = new System.Drawing.Point(244, 219);
            this.lab_Minus.Name = "lab_Minus";
            this.lab_Minus.Size = new System.Drawing.Size(21, 25);
            this.lab_Minus.TabIndex = 54;
            this.lab_Minus.Text = "-";
            // 
            // btn_SearchOrderDetails
            // 
            this.btn_SearchOrderDetails.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SearchOrderDetails.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SearchOrderDetails.Location = new System.Drawing.Point(352, 74);
            this.btn_SearchOrderDetails.Name = "btn_SearchOrderDetails";
            this.btn_SearchOrderDetails.Size = new System.Drawing.Size(102, 33);
            this.btn_SearchOrderDetails.TabIndex = 55;
            this.btn_SearchOrderDetails.Text = "查詢";
            this.btn_SearchOrderDetails.UseVisualStyleBackColor = false;
            this.btn_SearchOrderDetails.Click += new System.EventHandler(this.btn_SearchOrderDetails_Click);
            // 
            // txt_btn_SearchOrderDetailsID
            // 
            this.txt_btn_SearchOrderDetailsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_btn_SearchOrderDetailsID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_btn_SearchOrderDetailsID.Location = new System.Drawing.Point(249, 75);
            this.txt_btn_SearchOrderDetailsID.Name = "txt_btn_SearchOrderDetailsID";
            this.txt_btn_SearchOrderDetailsID.Size = new System.Drawing.Size(90, 31);
            this.txt_btn_SearchOrderDetailsID.TabIndex = 56;
            // 
            // btn_SearchAllOrderdetails
            // 
            this.btn_SearchAllOrderdetails.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SearchAllOrderdetails.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SearchAllOrderdetails.Location = new System.Drawing.Point(6, 30);
            this.btn_SearchAllOrderdetails.Name = "btn_SearchAllOrderdetails";
            this.btn_SearchAllOrderdetails.Size = new System.Drawing.Size(175, 33);
            this.btn_SearchAllOrderdetails.TabIndex = 57;
            this.btn_SearchAllOrderdetails.Text = "查詢全部訂單明細";
            this.btn_SearchAllOrderdetails.UseVisualStyleBackColor = false;
            this.btn_SearchAllOrderdetails.Click += new System.EventHandler(this.btn_SearchAllOrderdetails_Click);
            // 
            // dgv_Seats
            // 
            this.dgv_Seats.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Seats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Seats.Location = new System.Drawing.Point(523, 336);
            this.dgv_Seats.Name = "dgv_Seats";
            this.dgv_Seats.RowHeadersWidth = 62;
            this.dgv_Seats.RowTemplate.Height = 31;
            this.dgv_Seats.Size = new System.Drawing.Size(379, 382);
            this.dgv_Seats.TabIndex = 59;
            // 
            // Secret_SubcategoryID
            // 
            this.Secret_SubcategoryID.AutoSize = true;
            this.Secret_SubcategoryID.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Secret_SubcategoryID.Location = new System.Drawing.Point(683, 455);
            this.Secret_SubcategoryID.Name = "Secret_SubcategoryID";
            this.Secret_SubcategoryID.Size = new System.Drawing.Size(175, 20);
            this.Secret_SubcategoryID.TabIndex = 60;
            this.Secret_SubcategoryID.Text = "Secret_SubcategoryID";
            // 
            // lab_SeatsAlarm
            // 
            this.lab_SeatsAlarm.AutoSize = true;
            this.lab_SeatsAlarm.BackColor = System.Drawing.Color.Tomato;
            this.lab_SeatsAlarm.Font = new System.Drawing.Font("微軟正黑體", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_SeatsAlarm.ForeColor = System.Drawing.Color.White;
            this.lab_SeatsAlarm.Location = new System.Drawing.Point(730, 164);
            this.lab_SeatsAlarm.Name = "lab_SeatsAlarm";
            this.lab_SeatsAlarm.Size = new System.Drawing.Size(154, 21);
            this.lab_SeatsAlarm.TabIndex = 61;
            this.lab_SeatsAlarm.Text = "~~產品熱銷分析~~";
            this.lab_SeatsAlarm.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Secret_SeatID
            // 
            this.Secret_SeatID.AutoSize = true;
            this.Secret_SeatID.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Secret_SeatID.Location = new System.Drawing.Point(749, 136);
            this.Secret_SeatID.Name = "Secret_SeatID";
            this.Secret_SeatID.Size = new System.Drawing.Size(113, 20);
            this.Secret_SeatID.TabIndex = 62;
            this.Secret_SeatID.Text = "Secret_SeatID";
            // 
            // btn_DeleteMovieTicket
            // 
            this.btn_DeleteMovieTicket.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_DeleteMovieTicket.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DeleteMovieTicket.Location = new System.Drawing.Point(493, 24);
            this.btn_DeleteMovieTicket.Name = "btn_DeleteMovieTicket";
            this.btn_DeleteMovieTicket.Size = new System.Drawing.Size(141, 45);
            this.btn_DeleteMovieTicket.TabIndex = 63;
            this.btn_DeleteMovieTicket.Text = "刪除座位";
            this.btn_DeleteMovieTicket.UseVisualStyleBackColor = false;
            this.btn_DeleteMovieTicket.Visible = false;
            this.btn_DeleteMovieTicket.Click += new System.EventHandler(this.btn_DeleteMovieTicket_Click);
            // 
            // Secret_UnitPrice
            // 
            this.Secret_UnitPrice.AutoSize = true;
            this.Secret_UnitPrice.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Secret_UnitPrice.Location = new System.Drawing.Point(730, 82);
            this.Secret_UnitPrice.Name = "Secret_UnitPrice";
            this.Secret_UnitPrice.Size = new System.Drawing.Size(132, 20);
            this.Secret_UnitPrice.TabIndex = 66;
            this.Secret_UnitPrice.Text = "Secret_UnitPrice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_OrderDate);
            this.groupBox1.Controls.Add(this.checkBox_CusPhone);
            this.groupBox1.Controls.Add(this.checkBox_OrderID);
            this.groupBox1.Controls.Add(this.btn_advanceSearch);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(536, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 155);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "進階查詢";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_DeleteMovie);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(477, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 127);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "刪除選項";
            // 
            // btn_DeleteMovie
            // 
            this.btn_DeleteMovie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_DeleteMovie.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_DeleteMovie.Location = new System.Drawing.Point(16, 28);
            this.btn_DeleteMovie.Name = "btn_DeleteMovie";
            this.btn_DeleteMovie.Size = new System.Drawing.Size(141, 45);
            this.btn_DeleteMovie.TabIndex = 64;
            this.btn_DeleteMovie.Text = "刪除電影訂單";
            this.btn_DeleteMovie.UseVisualStyleBackColor = false;
            this.btn_DeleteMovie.Click += new System.EventHandler(this.btn_DeleteMovie_Click);
            // 
            // groupBox_Orders
            // 
            this.groupBox_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Orders.BackColor = System.Drawing.Color.Linen;
            this.groupBox_Orders.Controls.Add(this.btn_OpenDetails);
            this.groupBox_Orders.Controls.Add(this.txt_Status);
            this.groupBox_Orders.Controls.Add(this.dgv_Orders);
            this.groupBox_Orders.Controls.Add(this.groupBox1);
            this.groupBox_Orders.Controls.Add(this.txt_OrderID);
            this.groupBox_Orders.Controls.Add(this.lab_OrderID);
            this.groupBox_Orders.Controls.Add(this.txt_LastName);
            this.groupBox_Orders.Controls.Add(this.lab_LatName);
            this.groupBox_Orders.Controls.Add(this.txt_FirstName);
            this.groupBox_Orders.Controls.Add(this.lab_FirstName);
            this.groupBox_Orders.Controls.Add(this.lab_OrderDate);
            this.groupBox_Orders.Controls.Add(this.txt_PayType);
            this.groupBox_Orders.Controls.Add(this.lab_PayType);
            this.groupBox_Orders.Controls.Add(this.lab_ShippedDate);
            this.groupBox_Orders.Controls.Add(this.lab_Status);
            this.groupBox_Orders.Controls.Add(this.dateTimePicker_Orders2);
            this.groupBox_Orders.Controls.Add(this.comboBox_StatusType);
            this.groupBox_Orders.Controls.Add(this.dateTimePicker_Shipper);
            this.groupBox_Orders.Controls.Add(this.btn_UpdateOrders);
            this.groupBox_Orders.Controls.Add(this.btn_Search);
            this.groupBox_Orders.Controls.Add(this.txt_CusPhone);
            this.groupBox_Orders.Controls.Add(this.lab_CusPhone);
            this.groupBox_Orders.Controls.Add(this.label3);
            this.groupBox_Orders.Controls.Add(this.label4);
            this.groupBox_Orders.Controls.Add(this.btn_SearchAll);
            this.groupBox_Orders.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Orders.Location = new System.Drawing.Point(2, 1);
            this.groupBox_Orders.Name = "groupBox_Orders";
            this.groupBox_Orders.Size = new System.Drawing.Size(728, 733);
            this.groupBox_Orders.TabIndex = 69;
            this.groupBox_Orders.TabStop = false;
            this.groupBox_Orders.Text = "訂單明細";
            // 
            // btn_bestseller
            // 
            this.btn_bestseller.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_bestseller.Image = global::Igo_Back.Properties.Resources.images;
            this.btn_bestseller.Location = new System.Drawing.Point(726, 25);
            this.btn_bestseller.Name = "btn_bestseller";
            this.btn_bestseller.Size = new System.Drawing.Size(172, 167);
            this.btn_bestseller.TabIndex = 70;
            this.btn_bestseller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bestseller.UseVisualStyleBackColor = true;
            this.btn_bestseller.Click += new System.EventHandler(this.btn_bestseller_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv_OrderDetails);
            this.groupBox3.Controls.Add(this.lab_SeatsAlarm);
            this.groupBox3.Controls.Add(this.dgv_Seats);
            this.groupBox3.Controls.Add(this.lab_TicketID);
            this.groupBox3.Controls.Add(this.lab_ProductID);
            this.groupBox3.Controls.Add(this.txt_TicketID);
            this.groupBox3.Controls.Add(this.txt_ProductID);
            this.groupBox3.Controls.Add(this.btn_DeleteMovieTicket);
            this.groupBox3.Controls.Add(this.Secret_Quantity);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_bestseller);
            this.groupBox3.Controls.Add(this.btn_SearchAllOrderdetails);
            this.groupBox3.Controls.Add(this.Secret_SeatID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.lab_OrderDetailsID);
            this.groupBox3.Controls.Add(this.Secret_UnitPrice);
            this.groupBox3.Controls.Add(this.txt_OrderDetailsID);
            this.groupBox3.Controls.Add(this.txt_ProductName);
            this.groupBox3.Controls.Add(this.lab_ProductName);
            this.groupBox3.Controls.Add(this.Secret_SubcategoryID);
            this.groupBox3.Controls.Add(this.txt_Quantity);
            this.groupBox3.Controls.Add(this.lab_Quantity);
            this.groupBox3.Controls.Add(this.txt_TicketTpyeName);
            this.groupBox3.Controls.Add(this.txt_btn_SearchOrderDetailsID);
            this.groupBox3.Controls.Add(this.lab_TicketTpyeName);
            this.groupBox3.Controls.Add(this.btn_SearchOrderDetails);
            this.groupBox3.Controls.Add(this.btn_UpdateOrderDetails);
            this.groupBox3.Controls.Add(this.lab_Minus);
            this.groupBox3.Controls.Add(this.txt_MinusQuantity);
            this.groupBox3.Controls.Add(this.lab_Plus);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_PlusQuantity);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(736, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(913, 721);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂單明細";
            // 
            // lab_TicketID
            // 
            this.lab_TicketID.AutoSize = true;
            this.lab_TicketID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_TicketID.Location = new System.Drawing.Point(263, 459);
            this.lab_TicketID.Name = "lab_TicketID";
            this.lab_TicketID.Size = new System.Drawing.Size(82, 23);
            this.lab_TicketID.TabIndex = 76;
            this.lab_TicketID.Text = "TicketID";
            this.lab_TicketID.Visible = false;
            // 
            // lab_ProductID
            // 
            this.lab_ProductID.AutoSize = true;
            this.lab_ProductID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ProductID.Location = new System.Drawing.Point(59, 459);
            this.lab_ProductID.Name = "lab_ProductID";
            this.lab_ProductID.Size = new System.Drawing.Size(99, 23);
            this.lab_ProductID.TabIndex = 75;
            this.lab_ProductID.Text = "ProductID";
            this.lab_ProductID.Visible = false;
            // 
            // txt_TicketID
            // 
            this.txt_TicketID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TicketID.Enabled = false;
            this.txt_TicketID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_TicketID.Location = new System.Drawing.Point(343, 451);
            this.txt_TicketID.Name = "txt_TicketID";
            this.txt_TicketID.Size = new System.Drawing.Size(93, 31);
            this.txt_TicketID.TabIndex = 74;
            this.txt_TicketID.Visible = false;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductID.Enabled = false;
            this.txt_ProductID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ProductID.Location = new System.Drawing.Point(164, 457);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(93, 31);
            this.txt_ProductID.TabIndex = 73;
            this.txt_ProductID.Visible = false;
            // 
            // Secret_Quantity
            // 
            this.Secret_Quantity.AutoSize = true;
            this.Secret_Quantity.Location = new System.Drawing.Point(656, 365);
            this.Secret_Quantity.Name = "Secret_Quantity";
            this.Secret_Quantity.Size = new System.Drawing.Size(146, 23);
            this.Secret_Quantity.TabIndex = 72;
            this.Secret_Quantity.Text = "Secret_Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "Secet_totalPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "座位表";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSourceChanged += new System.EventHandler(this.bindingSource2_DataSourceChanged);
            // 
            // Order_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1641, 737);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Orders);
            this.Name = "Order_Management";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox_Orders.ResumeLayout(false);
            this.groupBox_Orders.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.DataGridView dgv_OrderDetails;
        private System.Windows.Forms.Label lab_OrderDetailsID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.Label lab_OrderID;
        private System.Windows.Forms.Label lab_LatName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lab_FirstName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lab_OrderDate;
        private System.Windows.Forms.TextBox txt_OrderDetailsID;
        private System.Windows.Forms.Label lab_PayType;
        private System.Windows.Forms.TextBox txt_PayType;
        private System.Windows.Forms.Label lab_ShippedDate;
        private System.Windows.Forms.Label lab_Status;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Button btn_OpenDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Orders2;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Shipper;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lab_CusPhone;
        private System.Windows.Forms.Button btn_advanceSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SearchAll;
        private System.Windows.Forms.TextBox txt_CusPhone;
        private System.Windows.Forms.CheckBox checkBox_OrderID;
        private System.Windows.Forms.CheckBox checkBox_CusPhone;
        private System.Windows.Forms.Label lab_ProductName;
        private System.Windows.Forms.Label lab_Quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lab_TicketTpyeName;
        private System.Windows.Forms.TextBox txt_TicketTpyeName;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button btn_UpdateOrderDetails;
        private System.Windows.Forms.TextBox txt_MinusQuantity;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateOrders;
        private System.Windows.Forms.ComboBox comboBox_StatusType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PlusQuantity;
        private System.Windows.Forms.Label lab_Plus;
        private System.Windows.Forms.Label lab_Minus;
        private System.Windows.Forms.CheckBox checkBox_OrderDate;
        private System.Windows.Forms.Button btn_SearchOrderDetails;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.TextBox txt_btn_SearchOrderDetailsID;
        private System.Windows.Forms.Button btn_SearchAllOrderdetails;
        private System.Windows.Forms.DataGridView dgv_Seats;
        private System.Windows.Forms.Label Secret_SubcategoryID;
        private System.Windows.Forms.Label lab_SeatsAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Secret_SeatID;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.Button btn_DeleteMovieTicket;
        private System.Windows.Forms.Label Secret_UnitPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_Orders;
        private System.Windows.Forms.Button btn_bestseller;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Secret_Quantity;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.Button btn_DeleteMovie;
        private System.Windows.Forms.TextBox txt_TicketID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label lab_TicketID;
        private System.Windows.Forms.Label lab_ProductID;
    }
}

