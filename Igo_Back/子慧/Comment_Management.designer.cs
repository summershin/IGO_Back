
namespace IGO
{
    partial class Comment_Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_Rank = new System.Windows.Forms.GroupBox();
            this.Btn_ByStar = new System.Windows.Forms.Button();
            this.Cb_ByStar = new System.Windows.Forms.ComboBox();
            this.Btn_SearchAll = new System.Windows.Forms.Button();
            this.Gb_Date = new System.Windows.Forms.GroupBox();
            this.Lb_Month = new System.Windows.Forms.Label();
            this.Lb_Year = new System.Windows.Forms.Label();
            this.Btn_SearchByDate = new System.Windows.Forms.Button();
            this.Cb_Month = new System.Windows.Forms.ComboBox();
            this.Cb_Year = new System.Windows.Forms.ComboBox();
            this.Gb_Information = new System.Windows.Forms.GroupBox();
            this.Tb_CustomerFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_CustomerLastName = new System.Windows.Forms.TextBox();
            this.Lb_CustomerName = new System.Windows.Forms.Label();
            this.Tb_ProductName2 = new System.Windows.Forms.TextBox();
            this.Lb_ProductName = new System.Windows.Forms.Label();
            this.Tb_CustomerNumber = new System.Windows.Forms.TextBox();
            this.Lb_CustomerNumber = new System.Windows.Forms.Label();
            this.Btn_SearchByKeyWord = new System.Windows.Forms.Button();
            this.Tb_Comment = new System.Windows.Forms.TextBox();
            this.Lb_Date = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.Tb_Star = new System.Windows.Forms.TextBox();
            this.Lb_ChangeStar = new System.Windows.Forms.Label();
            this.Lb_Comment = new System.Windows.Forms.Label();
            this.Tb_KeyWord = new System.Windows.Forms.TextBox();
            this.Lb_KeyWord = new System.Windows.Forms.Label();
            this.Tb_Detail = new System.Windows.Forms.TextBox();
            this.Lb_ProductNumber = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_statistics = new System.Windows.Forms.Button();
            this.Lb_WithComment2 = new System.Windows.Forms.Label();
            this.Lb_WithComment = new System.Windows.Forms.Label();
            this.Gb_ProductNumber = new System.Windows.Forms.GroupBox();
            this.Lb__ProductName = new System.Windows.Forms.Label();
            this.Tb_ProductName = new System.Windows.Forms.TextBox();
            this.Btn_SearchByProduct = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DGV_Comment = new System.Windows.Forms.DataGridView();
            this.DGV_Uncomment = new System.Windows.Forms.DataGridView();
            this.Gb_Rank.SuspendLayout();
            this.Gb_Date.SuspendLayout();
            this.Gb_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Gb_ProductNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Uncomment)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Rank
            // 
            this.Gb_Rank.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Rank.Controls.Add(this.Btn_ByStar);
            this.Gb_Rank.Controls.Add(this.Cb_ByStar);
            this.Gb_Rank.Controls.Add(this.Btn_SearchAll);
            this.Gb_Rank.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_Rank.Location = new System.Drawing.Point(1106, 47);
            this.Gb_Rank.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_Rank.Name = "Gb_Rank";
            this.Gb_Rank.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_Rank.Size = new System.Drawing.Size(423, 130);
            this.Gb_Rank.TabIndex = 0;
            this.Gb_Rank.TabStop = false;
            this.Gb_Rank.Text = "依評論等級查詢";
            // 
            // Btn_ByStar
            // 
            this.Btn_ByStar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Btn_ByStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ByStar.ForeColor = System.Drawing.Color.White;
            this.Btn_ByStar.Location = new System.Drawing.Point(304, 37);
            this.Btn_ByStar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ByStar.Name = "Btn_ByStar";
            this.Btn_ByStar.Size = new System.Drawing.Size(103, 47);
            this.Btn_ByStar.TabIndex = 3;
            this.Btn_ByStar.Text = "查詢";
            this.Btn_ByStar.UseVisualStyleBackColor = false;
            this.Btn_ByStar.Click += new System.EventHandler(this.Btn_ByStar_Click);
            // 
            // Cb_ByStar
            // 
            this.Cb_ByStar.FormattingEnabled = true;
            this.Cb_ByStar.Location = new System.Drawing.Point(144, 45);
            this.Cb_ByStar.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_ByStar.Name = "Cb_ByStar";
            this.Cb_ByStar.Size = new System.Drawing.Size(144, 32);
            this.Cb_ByStar.TabIndex = 1;
            // 
            // Btn_SearchAll
            // 
            this.Btn_SearchAll.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SearchAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchAll.ForeColor = System.Drawing.Color.Red;
            this.Btn_SearchAll.Location = new System.Drawing.Point(48, 37);
            this.Btn_SearchAll.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchAll.Name = "Btn_SearchAll";
            this.Btn_SearchAll.Size = new System.Drawing.Size(92, 42);
            this.Btn_SearchAll.TabIndex = 0;
            this.Btn_SearchAll.Text = "所有評論";
            this.Btn_SearchAll.UseVisualStyleBackColor = false;
            this.Btn_SearchAll.Click += new System.EventHandler(this.Bt_SearchAll_Click);
            // 
            // Gb_Date
            // 
            this.Gb_Date.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Date.Controls.Add(this.Lb_Month);
            this.Gb_Date.Controls.Add(this.Lb_Year);
            this.Gb_Date.Controls.Add(this.Btn_SearchByDate);
            this.Gb_Date.Controls.Add(this.Cb_Month);
            this.Gb_Date.Controls.Add(this.Cb_Year);
            this.Gb_Date.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_Date.Location = new System.Drawing.Point(638, 42);
            this.Gb_Date.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_Date.Name = "Gb_Date";
            this.Gb_Date.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_Date.Size = new System.Drawing.Size(450, 107);
            this.Gb_Date.TabIndex = 1;
            this.Gb_Date.TabStop = false;
            this.Gb_Date.Text = "依日期查詢";
            // 
            // Lb_Month
            // 
            this.Lb_Month.AutoSize = true;
            this.Lb_Month.Location = new System.Drawing.Point(223, 39);
            this.Lb_Month.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Month.Name = "Lb_Month";
            this.Lb_Month.Size = new System.Drawing.Size(29, 24);
            this.Lb_Month.TabIndex = 4;
            this.Lb_Month.Text = "月";
            // 
            // Lb_Year
            // 
            this.Lb_Year.AutoSize = true;
            this.Lb_Year.Location = new System.Drawing.Point(118, 39);
            this.Lb_Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Year.Name = "Lb_Year";
            this.Lb_Year.Size = new System.Drawing.Size(29, 24);
            this.Lb_Year.TabIndex = 3;
            this.Lb_Year.Text = "年";
            // 
            // Btn_SearchByDate
            // 
            this.Btn_SearchByDate.BackColor = System.Drawing.Color.CadetBlue;
            this.Btn_SearchByDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByDate.ForeColor = System.Drawing.Color.White;
            this.Btn_SearchByDate.Location = new System.Drawing.Point(287, 36);
            this.Btn_SearchByDate.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchByDate.Name = "Btn_SearchByDate";
            this.Btn_SearchByDate.Size = new System.Drawing.Size(101, 33);
            this.Btn_SearchByDate.TabIndex = 2;
            this.Btn_SearchByDate.Text = "查詢";
            this.Btn_SearchByDate.UseVisualStyleBackColor = false;
            this.Btn_SearchByDate.Click += new System.EventHandler(this.Bt_SearchByDate_Click);
            // 
            // Cb_Month
            // 
            this.Cb_Month.FormattingEnabled = true;
            this.Cb_Month.Location = new System.Drawing.Point(148, 34);
            this.Cb_Month.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_Month.Name = "Cb_Month";
            this.Cb_Month.Size = new System.Drawing.Size(54, 32);
            this.Cb_Month.TabIndex = 1;
            // 
            // Cb_Year
            // 
            this.Cb_Year.FormattingEnabled = true;
            this.Cb_Year.Location = new System.Drawing.Point(13, 34);
            this.Cb_Year.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_Year.Name = "Cb_Year";
            this.Cb_Year.Size = new System.Drawing.Size(92, 32);
            this.Cb_Year.TabIndex = 0;
            // 
            // Gb_Information
            // 
            this.Gb_Information.BackColor = System.Drawing.Color.Transparent;
            this.Gb_Information.Controls.Add(this.Tb_CustomerFirstName);
            this.Gb_Information.Controls.Add(this.label1);
            this.Gb_Information.Controls.Add(this.Tb_CustomerLastName);
            this.Gb_Information.Controls.Add(this.Lb_CustomerName);
            this.Gb_Information.Controls.Add(this.Tb_ProductName2);
            this.Gb_Information.Controls.Add(this.Lb_ProductName);
            this.Gb_Information.Controls.Add(this.Tb_CustomerNumber);
            this.Gb_Information.Controls.Add(this.Lb_CustomerNumber);
            this.Gb_Information.Controls.Add(this.Btn_SearchByKeyWord);
            this.Gb_Information.Controls.Add(this.Tb_Comment);
            this.Gb_Information.Controls.Add(this.Lb_Date);
            this.Gb_Information.Controls.Add(this.DTP_Date);
            this.Gb_Information.Controls.Add(this.Tb_Star);
            this.Gb_Information.Controls.Add(this.Lb_ChangeStar);
            this.Gb_Information.Controls.Add(this.Lb_Comment);
            this.Gb_Information.Controls.Add(this.Tb_KeyWord);
            this.Gb_Information.Controls.Add(this.Lb_KeyWord);
            this.Gb_Information.Controls.Add(this.Tb_Detail);
            this.Gb_Information.Controls.Add(this.Lb_ProductNumber);
            this.Gb_Information.Controls.Add(this.Btn_Delete);
            this.Gb_Information.Controls.Add(this.Btn_Refresh);
            this.Gb_Information.Controls.Add(this.Btn_Save);
            this.Gb_Information.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_Information.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_Information.Location = new System.Drawing.Point(11, 42);
            this.Gb_Information.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_Information.Name = "Gb_Information";
            this.Gb_Information.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_Information.Size = new System.Drawing.Size(549, 325);
            this.Gb_Information.TabIndex = 2;
            this.Gb_Information.TabStop = false;
            this.Gb_Information.Text = "評論資料異動";
            // 
            // Tb_CustomerFirstName
            // 
            this.Tb_CustomerFirstName.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_CustomerFirstName.Location = new System.Drawing.Point(457, 92);
            this.Tb_CustomerFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_CustomerFirstName.Multiline = true;
            this.Tb_CustomerFirstName.Name = "Tb_CustomerFirstName";
            this.Tb_CustomerFirstName.Size = new System.Drawing.Size(52, 20);
            this.Tb_CustomerFirstName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(351, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "異動會員名";
            // 
            // Tb_CustomerLastName
            // 
            this.Tb_CustomerLastName.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_CustomerLastName.Location = new System.Drawing.Point(284, 89);
            this.Tb_CustomerLastName.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_CustomerLastName.Multiline = true;
            this.Tb_CustomerLastName.Name = "Tb_CustomerLastName";
            this.Tb_CustomerLastName.Size = new System.Drawing.Size(52, 20);
            this.Tb_CustomerLastName.TabIndex = 21;
            // 
            // Lb_CustomerName
            // 
            this.Lb_CustomerName.AutoSize = true;
            this.Lb_CustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.Lb_CustomerName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_CustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lb_CustomerName.Location = new System.Drawing.Point(195, 89);
            this.Lb_CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_CustomerName.Name = "Lb_CustomerName";
            this.Lb_CustomerName.Size = new System.Drawing.Size(73, 17);
            this.Lb_CustomerName.TabIndex = 20;
            this.Lb_CustomerName.Text = "異動會員姓";
            // 
            // Tb_ProductName2
            // 
            this.Tb_ProductName2.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_ProductName2.Location = new System.Drawing.Point(99, 84);
            this.Tb_ProductName2.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_ProductName2.Name = "Tb_ProductName2";
            this.Tb_ProductName2.Size = new System.Drawing.Size(69, 22);
            this.Tb_ProductName2.TabIndex = 19;
            // 
            // Lb_ProductName
            // 
            this.Lb_ProductName.AutoSize = true;
            this.Lb_ProductName.BackColor = System.Drawing.SystemColors.Info;
            this.Lb_ProductName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_ProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lb_ProductName.Location = new System.Drawing.Point(9, 84);
            this.Lb_ProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_ProductName.Name = "Lb_ProductName";
            this.Lb_ProductName.Size = new System.Drawing.Size(86, 17);
            this.Lb_ProductName.TabIndex = 18;
            this.Lb_ProductName.Text = "異動產品名稱";
            // 
            // Tb_CustomerNumber
            // 
            this.Tb_CustomerNumber.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_CustomerNumber.Location = new System.Drawing.Point(389, 62);
            this.Tb_CustomerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_CustomerNumber.Name = "Tb_CustomerNumber";
            this.Tb_CustomerNumber.Size = new System.Drawing.Size(144, 22);
            this.Tb_CustomerNumber.TabIndex = 17;
            // 
            // Lb_CustomerNumber
            // 
            this.Lb_CustomerNumber.AutoSize = true;
            this.Lb_CustomerNumber.BackColor = System.Drawing.Color.LightPink;
            this.Lb_CustomerNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_CustomerNumber.Location = new System.Drawing.Point(280, 60);
            this.Lb_CustomerNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_CustomerNumber.Name = "Lb_CustomerNumber";
            this.Lb_CustomerNumber.Size = new System.Drawing.Size(106, 21);
            this.Lb_CustomerNumber.TabIndex = 16;
            this.Lb_CustomerNumber.Text = "異動會員編號";
            // 
            // Btn_SearchByKeyWord
            // 
            this.Btn_SearchByKeyWord.BackColor = System.Drawing.Color.SlateGray;
            this.Btn_SearchByKeyWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByKeyWord.ForeColor = System.Drawing.Color.White;
            this.Btn_SearchByKeyWord.Location = new System.Drawing.Point(457, 22);
            this.Btn_SearchByKeyWord.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchByKeyWord.Name = "Btn_SearchByKeyWord";
            this.Btn_SearchByKeyWord.Size = new System.Drawing.Size(76, 39);
            this.Btn_SearchByKeyWord.TabIndex = 15;
            this.Btn_SearchByKeyWord.Text = "查詢";
            this.Btn_SearchByKeyWord.UseVisualStyleBackColor = false;
            this.Btn_SearchByKeyWord.Click += new System.EventHandler(this.Btn_SearchByKeyWord_Click);
            // 
            // Tb_Comment
            // 
            this.Tb_Comment.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_Comment.Location = new System.Drawing.Point(26, 152);
            this.Tb_Comment.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Comment.Multiline = true;
            this.Tb_Comment.Name = "Tb_Comment";
            this.Tb_Comment.Size = new System.Drawing.Size(507, 124);
            this.Tb_Comment.TabIndex = 14;
            // 
            // Lb_Date
            // 
            this.Lb_Date.AutoSize = true;
            this.Lb_Date.BackColor = System.Drawing.Color.LightPink;
            this.Lb_Date.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Date.Location = new System.Drawing.Point(238, 121);
            this.Lb_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(74, 21);
            this.Lb_Date.TabIndex = 12;
            this.Lb_Date.Text = "異動日期";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTP_Date.Location = new System.Drawing.Point(316, 120);
            this.DTP_Date.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(126, 22);
            this.DTP_Date.TabIndex = 11;
            // 
            // Tb_Star
            // 
            this.Tb_Star.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_Star.Location = new System.Drawing.Point(149, 57);
            this.Tb_Star.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Star.Multiline = true;
            this.Tb_Star.Name = "Tb_Star";
            this.Tb_Star.Size = new System.Drawing.Size(26, 23);
            this.Tb_Star.TabIndex = 10;
            // 
            // Lb_ChangeStar
            // 
            this.Lb_ChangeStar.AutoSize = true;
            this.Lb_ChangeStar.BackColor = System.Drawing.Color.LightPink;
            this.Lb_ChangeStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_ChangeStar.Location = new System.Drawing.Point(8, 56);
            this.Lb_ChangeStar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_ChangeStar.Name = "Lb_ChangeStar";
            this.Lb_ChangeStar.Size = new System.Drawing.Size(106, 21);
            this.Lb_ChangeStar.TabIndex = 9;
            this.Lb_ChangeStar.Text = "異動星星等級";
            // 
            // Lb_Comment
            // 
            this.Lb_Comment.AutoSize = true;
            this.Lb_Comment.BackColor = System.Drawing.Color.LightPink;
            this.Lb_Comment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Comment.Location = new System.Drawing.Point(41, 115);
            this.Lb_Comment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Comment.Name = "Lb_Comment";
            this.Lb_Comment.Size = new System.Drawing.Size(110, 21);
            this.Lb_Comment.TabIndex = 8;
            this.Lb_Comment.Text = "異動評論內容:";
            // 
            // Tb_KeyWord
            // 
            this.Tb_KeyWord.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_KeyWord.Location = new System.Drawing.Point(389, 27);
            this.Tb_KeyWord.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_KeyWord.Name = "Tb_KeyWord";
            this.Tb_KeyWord.Size = new System.Drawing.Size(60, 22);
            this.Tb_KeyWord.TabIndex = 7;
            // 
            // Lb_KeyWord
            // 
            this.Lb_KeyWord.AutoSize = true;
            this.Lb_KeyWord.BackColor = System.Drawing.Color.Transparent;
            this.Lb_KeyWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_KeyWord.Location = new System.Drawing.Point(259, 28);
            this.Lb_KeyWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_KeyWord.Name = "Lb_KeyWord";
            this.Lb_KeyWord.Size = new System.Drawing.Size(126, 21);
            this.Lb_KeyWord.TabIndex = 6;
            this.Lb_KeyWord.Text = "異動評論關鍵字:";
            // 
            // Tb_Detail
            // 
            this.Tb_Detail.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_Detail.Location = new System.Drawing.Point(137, 22);
            this.Tb_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Detail.Name = "Tb_Detail";
            this.Tb_Detail.Size = new System.Drawing.Size(95, 22);
            this.Tb_Detail.TabIndex = 5;
            // 
            // Lb_ProductNumber
            // 
            this.Lb_ProductNumber.AutoSize = true;
            this.Lb_ProductNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lb_ProductNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_ProductNumber.Location = new System.Drawing.Point(8, 31);
            this.Lb_ProductNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_ProductNumber.Name = "Lb_ProductNumber";
            this.Lb_ProductNumber.Size = new System.Drawing.Size(106, 21);
            this.Lb_ProductNumber.TabIndex = 4;
            this.Lb_ProductNumber.Text = "異動產品編號";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(438, 280);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(95, 30);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(339, 280);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(95, 30);
            this.Btn_Refresh.TabIndex = 2;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(231, 280);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(95, 30);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Title.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Title.ForeColor = System.Drawing.Color.White;
            this.Lb_Title.Location = new System.Drawing.Point(152, 0);
            this.Lb_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(160, 45);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "評論管理";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.BackgroundImage = global::Igo_Back.Properties.Resources.圖片381;
            this.splitContainer1.Panel1.Controls.Add(this.Btn_statistics);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_WithComment2);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_WithComment);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_ProductNumber);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Information);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Rank);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_Title);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Date);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1583, 757);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // Btn_statistics
            // 
            this.Btn_statistics.BackColor = System.Drawing.Color.RosyBrown;
            this.Btn_statistics.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_statistics.ForeColor = System.Drawing.Color.White;
            this.Btn_statistics.Location = new System.Drawing.Point(1328, 203);
            this.Btn_statistics.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_statistics.Name = "Btn_statistics";
            this.Btn_statistics.Size = new System.Drawing.Size(165, 45);
            this.Btn_statistics.TabIndex = 5;
            this.Btn_statistics.Text = "圖表統計";
            this.Btn_statistics.UseVisualStyleBackColor = false;
            this.Btn_statistics.Click += new System.EventHandler(this.Btn_statistics_Click);
            // 
            // Lb_WithComment2
            // 
            this.Lb_WithComment2.AutoSize = true;
            this.Lb_WithComment2.BackColor = System.Drawing.Color.Transparent;
            this.Lb_WithComment2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_WithComment2.ForeColor = System.Drawing.Color.White;
            this.Lb_WithComment2.Location = new System.Drawing.Point(747, 350);
            this.Lb_WithComment2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_WithComment2.Name = "Lb_WithComment2";
            this.Lb_WithComment2.Size = new System.Drawing.Size(143, 24);
            this.Lb_WithComment2.TabIndex = 2;
            this.Lb_WithComment2.Text = "異動後產品資料";
            // 
            // Lb_WithComment
            // 
            this.Lb_WithComment.AutoSize = true;
            this.Lb_WithComment.BackColor = System.Drawing.Color.Transparent;
            this.Lb_WithComment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_WithComment.ForeColor = System.Drawing.Color.White;
            this.Lb_WithComment.Location = new System.Drawing.Point(573, 350);
            this.Lb_WithComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_WithComment.Name = "Lb_WithComment";
            this.Lb_WithComment.Size = new System.Drawing.Size(124, 24);
            this.Lb_WithComment.TabIndex = 1;
            this.Lb_WithComment.Text = "所有評論資料";
            // 
            // Gb_ProductNumber
            // 
            this.Gb_ProductNumber.BackColor = System.Drawing.Color.Transparent;
            this.Gb_ProductNumber.Controls.Add(this.Lb__ProductName);
            this.Gb_ProductNumber.Controls.Add(this.Tb_ProductName);
            this.Gb_ProductNumber.Controls.Add(this.Btn_SearchByProduct);
            this.Gb_ProductNumber.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_ProductNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gb_ProductNumber.Location = new System.Drawing.Point(638, 168);
            this.Gb_ProductNumber.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_ProductNumber.Name = "Gb_ProductNumber";
            this.Gb_ProductNumber.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_ProductNumber.Size = new System.Drawing.Size(450, 106);
            this.Gb_ProductNumber.TabIndex = 4;
            this.Gb_ProductNumber.TabStop = false;
            this.Gb_ProductNumber.Text = "依產品名稱查詢";
            // 
            // Lb__ProductName
            // 
            this.Lb__ProductName.AutoSize = true;
            this.Lb__ProductName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb__ProductName.ForeColor = System.Drawing.Color.White;
            this.Lb__ProductName.Location = new System.Drawing.Point(28, 45);
            this.Lb__ProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb__ProductName.Name = "Lb__ProductName";
            this.Lb__ProductName.Size = new System.Drawing.Size(73, 19);
            this.Lb__ProductName.TabIndex = 4;
            this.Lb__ProductName.Text = "產品名稱:";
            // 
            // Tb_ProductName
            // 
            this.Tb_ProductName.Location = new System.Drawing.Point(105, 35);
            this.Tb_ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_ProductName.Name = "Tb_ProductName";
            this.Tb_ProductName.Size = new System.Drawing.Size(117, 33);
            this.Tb_ProductName.TabIndex = 3;
            // 
            // Btn_SearchByProduct
            // 
            this.Btn_SearchByProduct.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_SearchByProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByProduct.ForeColor = System.Drawing.Color.White;
            this.Btn_SearchByProduct.Location = new System.Drawing.Point(287, 31);
            this.Btn_SearchByProduct.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchByProduct.Name = "Btn_SearchByProduct";
            this.Btn_SearchByProduct.Size = new System.Drawing.Size(101, 37);
            this.Btn_SearchByProduct.TabIndex = 2;
            this.Btn_SearchByProduct.Text = "查詢";
            this.Btn_SearchByProduct.UseVisualStyleBackColor = false;
            this.Btn_SearchByProduct.Click += new System.EventHandler(this.Bt_SearchByProduct_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer2.Panel1.Controls.Add(this.DGV_Comment);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer2.Panel2.Controls.Add(this.DGV_Uncomment);
            this.splitContainer2.Size = new System.Drawing.Size(1583, 380);
            this.splitContainer2.SplitterDistance = 717;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // DGV_Comment
            // 
            this.DGV_Comment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Comment.Location = new System.Drawing.Point(0, 0);
            this.DGV_Comment.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Comment.Name = "DGV_Comment";
            this.DGV_Comment.RowHeadersWidth = 51;
            this.DGV_Comment.RowTemplate.Height = 27;
            this.DGV_Comment.Size = new System.Drawing.Size(717, 380);
            this.DGV_Comment.TabIndex = 0;
            this.DGV_Comment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Comment_CellContentClick);
            // 
            // DGV_Uncomment
            // 
            this.DGV_Uncomment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Uncomment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Uncomment.Location = new System.Drawing.Point(0, 0);
            this.DGV_Uncomment.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Uncomment.Name = "DGV_Uncomment";
            this.DGV_Uncomment.RowHeadersWidth = 51;
            this.DGV_Uncomment.RowTemplate.Height = 27;
            this.DGV_Uncomment.Size = new System.Drawing.Size(863, 380);
            this.DGV_Uncomment.TabIndex = 1;
            this.DGV_Uncomment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Uncomment_CellContentClick);
            // 
            // Comment_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 757);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Comment_Management";
            this.Text = "Comment_Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Gb_Rank.ResumeLayout(false);
            this.Gb_Date.ResumeLayout(false);
            this.Gb_Date.PerformLayout();
            this.Gb_Information.ResumeLayout(false);
            this.Gb_Information.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Gb_ProductNumber.ResumeLayout(false);
            this.Gb_ProductNumber.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Uncomment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Rank;
        private System.Windows.Forms.GroupBox Gb_Date;
        private System.Windows.Forms.Button Btn_SearchAll;
        private System.Windows.Forms.Label Lb_Month;
        private System.Windows.Forms.Label Lb_Year;
        private System.Windows.Forms.Button Btn_SearchByDate;
        private System.Windows.Forms.ComboBox Cb_Month;
        private System.Windows.Forms.ComboBox Cb_Year;
        private System.Windows.Forms.GroupBox Gb_Information;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Gb_ProductNumber;
        private System.Windows.Forms.Label Lb__ProductName;
        private System.Windows.Forms.TextBox Tb_ProductName;
        private System.Windows.Forms.Button Btn_SearchByProduct;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DGV_Comment;
        private System.Windows.Forms.DataGridView DGV_Uncomment;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Tb_KeyWord;
        private System.Windows.Forms.Label Lb_KeyWord;
        private System.Windows.Forms.TextBox Tb_Detail;
        private System.Windows.Forms.Label Lb_ProductNumber;
        private System.Windows.Forms.Label Lb_Comment;
        private System.Windows.Forms.Label Lb_Date;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.TextBox Tb_Star;
        private System.Windows.Forms.Label Lb_ChangeStar;
        private System.Windows.Forms.Label Lb_WithComment;
        private System.Windows.Forms.Label Lb_WithComment2;
        private System.Windows.Forms.TextBox Tb_Comment;
        private System.Windows.Forms.Button Btn_SearchByKeyWord;
        private System.Windows.Forms.TextBox Tb_CustomerNumber;
        private System.Windows.Forms.Label Lb_CustomerNumber;
        private System.Windows.Forms.Button Btn_statistics;
        private System.Windows.Forms.TextBox Tb_CustomerLastName;
        private System.Windows.Forms.Label Lb_CustomerName;
        private System.Windows.Forms.TextBox Tb_ProductName2;
        private System.Windows.Forms.Label Lb_ProductName;
        private System.Windows.Forms.Button Btn_ByStar;
        private System.Windows.Forms.ComboBox Cb_ByStar;
        private System.Windows.Forms.TextBox Tb_CustomerFirstName;
        private System.Windows.Forms.Label label1;
    }
}