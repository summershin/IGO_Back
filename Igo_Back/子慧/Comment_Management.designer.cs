
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
            this.Lb_WithComment2 = new System.Windows.Forms.Label();
            this.Lb_WithComment = new System.Windows.Forms.Label();
            this.Gb_ProductNumber = new System.Windows.Forms.GroupBox();
            this.Btn_statistics = new System.Windows.Forms.Button();
            this.Lb__ProductName = new System.Windows.Forms.Label();
            this.Tb_ProductName = new System.Windows.Forms.TextBox();
            this.Btn_SearchByProduct = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DGV_Comment = new System.Windows.Forms.DataGridView();
            this.DGV_Uncomment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_CustomerFirstName = new System.Windows.Forms.TextBox();
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
            this.Gb_Rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gb_Rank.Controls.Add(this.Btn_ByStar);
            this.Gb_Rank.Controls.Add(this.Cb_ByStar);
            this.Gb_Rank.Controls.Add(this.Btn_SearchAll);
            this.Gb_Rank.Location = new System.Drawing.Point(649, 20);
            this.Gb_Rank.Name = "Gb_Rank";
            this.Gb_Rank.Size = new System.Drawing.Size(538, 122);
            this.Gb_Rank.TabIndex = 0;
            this.Gb_Rank.TabStop = false;
            this.Gb_Rank.Text = "依評論等級查詢";
            // 
            // Btn_ByStar
            // 
            this.Btn_ByStar.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_ByStar.Location = new System.Drawing.Point(364, 51);
            this.Btn_ByStar.Name = "Btn_ByStar";
            this.Btn_ByStar.Size = new System.Drawing.Size(111, 29);
            this.Btn_ByStar.TabIndex = 3;
            this.Btn_ByStar.Text = "查詢";
            this.Btn_ByStar.UseVisualStyleBackColor = true;
            this.Btn_ByStar.Click += new System.EventHandler(this.Btn_ByStar_Click);
            // 
            // Cb_ByStar
            // 
            this.Cb_ByStar.FormattingEnabled = true;
            this.Cb_ByStar.Location = new System.Drawing.Point(184, 51);
            this.Cb_ByStar.Name = "Cb_ByStar";
            this.Cb_ByStar.Size = new System.Drawing.Size(121, 23);
            this.Cb_ByStar.TabIndex = 1;
            // 
            // Btn_SearchAll
            // 
            this.Btn_SearchAll.BackColor = System.Drawing.Color.Yellow;
            this.Btn_SearchAll.Location = new System.Drawing.Point(32, 40);
            this.Btn_SearchAll.Name = "Btn_SearchAll";
            this.Btn_SearchAll.Size = new System.Drawing.Size(123, 52);
            this.Btn_SearchAll.TabIndex = 0;
            this.Btn_SearchAll.Text = "所有評論";
            this.Btn_SearchAll.UseVisualStyleBackColor = false;
            this.Btn_SearchAll.Click += new System.EventHandler(this.Bt_SearchAll_Click);
            // 
            // Gb_Date
            // 
            this.Gb_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Gb_Date.Controls.Add(this.Lb_Month);
            this.Gb_Date.Controls.Add(this.Lb_Year);
            this.Gb_Date.Controls.Add(this.Btn_SearchByDate);
            this.Gb_Date.Controls.Add(this.Cb_Month);
            this.Gb_Date.Controls.Add(this.Cb_Year);
            this.Gb_Date.Location = new System.Drawing.Point(649, 160);
            this.Gb_Date.Name = "Gb_Date";
            this.Gb_Date.Size = new System.Drawing.Size(538, 93);
            this.Gb_Date.TabIndex = 1;
            this.Gb_Date.TabStop = false;
            this.Gb_Date.Text = "依日期查詢";
            // 
            // Lb_Month
            // 
            this.Lb_Month.AutoSize = true;
            this.Lb_Month.Location = new System.Drawing.Point(297, 49);
            this.Lb_Month.Name = "Lb_Month";
            this.Lb_Month.Size = new System.Drawing.Size(22, 15);
            this.Lb_Month.TabIndex = 4;
            this.Lb_Month.Text = "月";
            // 
            // Lb_Year
            // 
            this.Lb_Year.AutoSize = true;
            this.Lb_Year.Location = new System.Drawing.Point(157, 49);
            this.Lb_Year.Name = "Lb_Year";
            this.Lb_Year.Size = new System.Drawing.Size(22, 15);
            this.Lb_Year.TabIndex = 3;
            this.Lb_Year.Text = "年";
            // 
            // Btn_SearchByDate
            // 
            this.Btn_SearchByDate.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByDate.Location = new System.Drawing.Point(395, 33);
            this.Btn_SearchByDate.Name = "Btn_SearchByDate";
            this.Btn_SearchByDate.Size = new System.Drawing.Size(101, 41);
            this.Btn_SearchByDate.TabIndex = 2;
            this.Btn_SearchByDate.Text = "查詢";
            this.Btn_SearchByDate.UseVisualStyleBackColor = true;
            this.Btn_SearchByDate.Click += new System.EventHandler(this.Bt_SearchByDate_Click);
            // 
            // Cb_Month
            // 
            this.Cb_Month.FormattingEnabled = true;
            this.Cb_Month.Location = new System.Drawing.Point(198, 42);
            this.Cb_Month.Name = "Cb_Month";
            this.Cb_Month.Size = new System.Drawing.Size(71, 23);
            this.Cb_Month.TabIndex = 1;
            // 
            // Cb_Year
            // 
            this.Cb_Year.FormattingEnabled = true;
            this.Cb_Year.Location = new System.Drawing.Point(17, 43);
            this.Cb_Year.Name = "Cb_Year";
            this.Cb_Year.Size = new System.Drawing.Size(121, 23);
            this.Cb_Year.TabIndex = 0;
            // 
            // Gb_Information
            // 
            this.Gb_Information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.Gb_Information.Location = new System.Drawing.Point(12, 48);
            this.Gb_Information.Name = "Gb_Information";
            this.Gb_Information.Size = new System.Drawing.Size(588, 319);
            this.Gb_Information.TabIndex = 2;
            this.Gb_Information.TabStop = false;
            this.Gb_Information.Text = "評論資料異動";
            // 
            // Tb_CustomerLastName
            // 
            this.Tb_CustomerLastName.Location = new System.Drawing.Point(308, 112);
            this.Tb_CustomerLastName.Multiline = true;
            this.Tb_CustomerLastName.Name = "Tb_CustomerLastName";
            this.Tb_CustomerLastName.Size = new System.Drawing.Size(68, 24);
            this.Tb_CustomerLastName.TabIndex = 21;
            // 
            // Lb_CustomerName
            // 
            this.Lb_CustomerName.AutoSize = true;
            this.Lb_CustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.Lb_CustomerName.Location = new System.Drawing.Point(220, 115);
            this.Lb_CustomerName.Name = "Lb_CustomerName";
            this.Lb_CustomerName.Size = new System.Drawing.Size(82, 15);
            this.Lb_CustomerName.TabIndex = 20;
            this.Lb_CustomerName.Text = "異動會員姓";
            // 
            // Tb_ProductName2
            // 
            this.Tb_ProductName2.Location = new System.Drawing.Point(123, 109);
            this.Tb_ProductName2.Name = "Tb_ProductName2";
            this.Tb_ProductName2.Size = new System.Drawing.Size(91, 25);
            this.Tb_ProductName2.TabIndex = 19;
            // 
            // Lb_ProductName
            // 
            this.Lb_ProductName.AutoSize = true;
            this.Lb_ProductName.BackColor = System.Drawing.SystemColors.Info;
            this.Lb_ProductName.Location = new System.Drawing.Point(16, 112);
            this.Lb_ProductName.Name = "Lb_ProductName";
            this.Lb_ProductName.Size = new System.Drawing.Size(97, 15);
            this.Lb_ProductName.TabIndex = 18;
            this.Lb_ProductName.Text = "異動產品名稱";
            // 
            // Tb_CustomerNumber
            // 
            this.Tb_CustomerNumber.Location = new System.Drawing.Point(380, 69);
            this.Tb_CustomerNumber.Name = "Tb_CustomerNumber";
            this.Tb_CustomerNumber.Size = new System.Drawing.Size(191, 25);
            this.Tb_CustomerNumber.TabIndex = 17;
            // 
            // Lb_CustomerNumber
            // 
            this.Lb_CustomerNumber.AutoSize = true;
            this.Lb_CustomerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lb_CustomerNumber.Location = new System.Drawing.Point(262, 69);
            this.Lb_CustomerNumber.Name = "Lb_CustomerNumber";
            this.Lb_CustomerNumber.Size = new System.Drawing.Size(97, 15);
            this.Lb_CustomerNumber.TabIndex = 16;
            this.Lb_CustomerNumber.Text = "異動會員編號";
            // 
            // Btn_SearchByKeyWord
            // 
            this.Btn_SearchByKeyWord.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByKeyWord.Location = new System.Drawing.Point(470, 31);
            this.Btn_SearchByKeyWord.Name = "Btn_SearchByKeyWord";
            this.Btn_SearchByKeyWord.Size = new System.Drawing.Size(101, 25);
            this.Btn_SearchByKeyWord.TabIndex = 15;
            this.Btn_SearchByKeyWord.Text = "查詢";
            this.Btn_SearchByKeyWord.UseVisualStyleBackColor = true;
            this.Btn_SearchByKeyWord.Click += new System.EventHandler(this.Btn_SearchByKeyWord_Click);
            // 
            // Tb_Comment
            // 
            this.Tb_Comment.Location = new System.Drawing.Point(19, 175);
            this.Tb_Comment.Multiline = true;
            this.Tb_Comment.Name = "Tb_Comment";
            this.Tb_Comment.Size = new System.Drawing.Size(527, 88);
            this.Tb_Comment.TabIndex = 14;
            // 
            // Lb_Date
            // 
            this.Lb_Date.AutoSize = true;
            this.Lb_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lb_Date.Location = new System.Drawing.Point(262, 151);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(67, 15);
            this.Lb_Date.TabIndex = 12;
            this.Lb_Date.Text = "異動日期";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(380, 144);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(166, 25);
            this.DTP_Date.TabIndex = 11;
            // 
            // Tb_Star
            // 
            this.Tb_Star.Location = new System.Drawing.Point(127, 66);
            this.Tb_Star.Multiline = true;
            this.Tb_Star.Name = "Tb_Star";
            this.Tb_Star.Size = new System.Drawing.Size(34, 28);
            this.Tb_Star.TabIndex = 10;
            // 
            // Lb_ChangeStar
            // 
            this.Lb_ChangeStar.AutoSize = true;
            this.Lb_ChangeStar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lb_ChangeStar.Location = new System.Drawing.Point(20, 71);
            this.Lb_ChangeStar.Name = "Lb_ChangeStar";
            this.Lb_ChangeStar.Size = new System.Drawing.Size(97, 15);
            this.Lb_ChangeStar.TabIndex = 9;
            this.Lb_ChangeStar.Text = "異動星星等級";
            // 
            // Lb_Comment
            // 
            this.Lb_Comment.AutoSize = true;
            this.Lb_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lb_Comment.Location = new System.Drawing.Point(20, 145);
            this.Lb_Comment.Name = "Lb_Comment";
            this.Lb_Comment.Size = new System.Drawing.Size(101, 15);
            this.Lb_Comment.TabIndex = 8;
            this.Lb_Comment.Text = "異動評論內容:";
            // 
            // Tb_KeyWord
            // 
            this.Tb_KeyWord.Location = new System.Drawing.Point(380, 31);
            this.Tb_KeyWord.Name = "Tb_KeyWord";
            this.Tb_KeyWord.Size = new System.Drawing.Size(79, 25);
            this.Tb_KeyWord.TabIndex = 7;
            // 
            // Lb_KeyWord
            // 
            this.Lb_KeyWord.AutoSize = true;
            this.Lb_KeyWord.Location = new System.Drawing.Point(258, 31);
            this.Lb_KeyWord.Name = "Lb_KeyWord";
            this.Lb_KeyWord.Size = new System.Drawing.Size(116, 15);
            this.Lb_KeyWord.TabIndex = 6;
            this.Lb_KeyWord.Text = "異動評論關鍵字:";
            // 
            // Tb_Detail
            // 
            this.Tb_Detail.Location = new System.Drawing.Point(127, 28);
            this.Tb_Detail.Name = "Tb_Detail";
            this.Tb_Detail.Size = new System.Drawing.Size(125, 25);
            this.Tb_Detail.TabIndex = 5;
            // 
            // Lb_ProductNumber
            // 
            this.Lb_ProductNumber.AutoSize = true;
            this.Lb_ProductNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lb_ProductNumber.Location = new System.Drawing.Point(20, 31);
            this.Lb_ProductNumber.Name = "Lb_ProductNumber";
            this.Lb_ProductNumber.Size = new System.Drawing.Size(97, 15);
            this.Lb_ProductNumber.TabIndex = 4;
            this.Lb_ProductNumber.Text = "異動產品編號";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(419, 269);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(127, 38);
            this.Btn_Delete.TabIndex = 3;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(223, 269);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(127, 38);
            this.Btn_Refresh.TabIndex = 2;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(19, 269);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(127, 38);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lb_Title.Location = new System.Drawing.Point(205, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(127, 36);
            this.Lb_Title.TabIndex = 3;
            this.Lb_Title.Text = "評論管理";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.Lb_WithComment2);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_WithComment);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_ProductNumber);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Information);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Rank);
            this.splitContainer1.Panel1.Controls.Add(this.Lb_Title);
            this.splitContainer1.Panel1.Controls.Add(this.Gb_Date);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 801);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 4;
            // 
            // Lb_WithComment2
            // 
            this.Lb_WithComment2.AutoSize = true;
            this.Lb_WithComment2.Location = new System.Drawing.Point(866, 370);
            this.Lb_WithComment2.Name = "Lb_WithComment2";
            this.Lb_WithComment2.Size = new System.Drawing.Size(112, 15);
            this.Lb_WithComment2.TabIndex = 2;
            this.Lb_WithComment2.Text = "異動後產品資料";
            // 
            // Lb_WithComment
            // 
            this.Lb_WithComment.AutoSize = true;
            this.Lb_WithComment.Location = new System.Drawing.Point(195, 370);
            this.Lb_WithComment.Name = "Lb_WithComment";
            this.Lb_WithComment.Size = new System.Drawing.Size(97, 15);
            this.Lb_WithComment.TabIndex = 1;
            this.Lb_WithComment.Text = "所有評論資料";
            // 
            // Gb_ProductNumber
            // 
            this.Gb_ProductNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Gb_ProductNumber.Controls.Add(this.Btn_statistics);
            this.Gb_ProductNumber.Controls.Add(this.Lb__ProductName);
            this.Gb_ProductNumber.Controls.Add(this.Tb_ProductName);
            this.Gb_ProductNumber.Controls.Add(this.Btn_SearchByProduct);
            this.Gb_ProductNumber.Location = new System.Drawing.Point(649, 274);
            this.Gb_ProductNumber.Name = "Gb_ProductNumber";
            this.Gb_ProductNumber.Size = new System.Drawing.Size(538, 93);
            this.Gb_ProductNumber.TabIndex = 4;
            this.Gb_ProductNumber.TabStop = false;
            this.Gb_ProductNumber.Text = "依產品名稱查詢";
            // 
            // Btn_statistics
            // 
            this.Btn_statistics.BackColor = System.Drawing.Color.Red;
            this.Btn_statistics.Location = new System.Drawing.Point(433, 42);
            this.Btn_statistics.Name = "Btn_statistics";
            this.Btn_statistics.Size = new System.Drawing.Size(75, 23);
            this.Btn_statistics.TabIndex = 5;
            this.Btn_statistics.Text = "統計";
            this.Btn_statistics.UseVisualStyleBackColor = false;
            this.Btn_statistics.Click += new System.EventHandler(this.Btn_statistics_Click);
            // 
            // Lb__ProductName
            // 
            this.Lb__ProductName.AutoSize = true;
            this.Lb__ProductName.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb__ProductName.Location = new System.Drawing.Point(28, 46);
            this.Lb__ProductName.Name = "Lb__ProductName";
            this.Lb__ProductName.Size = new System.Drawing.Size(90, 19);
            this.Lb__ProductName.TabIndex = 4;
            this.Lb__ProductName.Text = "產品名稱:";
            // 
            // Tb_ProductName
            // 
            this.Tb_ProductName.Location = new System.Drawing.Point(137, 43);
            this.Tb_ProductName.Name = "Tb_ProductName";
            this.Tb_ProductName.Size = new System.Drawing.Size(114, 25);
            this.Tb_ProductName.TabIndex = 3;
            // 
            // Btn_SearchByProduct
            // 
            this.Btn_SearchByProduct.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_SearchByProduct.Location = new System.Drawing.Point(279, 33);
            this.Btn_SearchByProduct.Name = "Btn_SearchByProduct";
            this.Btn_SearchByProduct.Size = new System.Drawing.Size(135, 46);
            this.Btn_SearchByProduct.TabIndex = 2;
            this.Btn_SearchByProduct.Text = "查詢";
            this.Btn_SearchByProduct.UseVisualStyleBackColor = true;
            this.Btn_SearchByProduct.Click += new System.EventHandler(this.Bt_SearchByProduct_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Size = new System.Drawing.Size(1234, 400);
            this.splitContainer2.SplitterDistance = 539;
            this.splitContainer2.TabIndex = 0;
            // 
            // DGV_Comment
            // 
            this.DGV_Comment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Comment.Location = new System.Drawing.Point(0, 0);
            this.DGV_Comment.Name = "DGV_Comment";
            this.DGV_Comment.RowHeadersWidth = 51;
            this.DGV_Comment.RowTemplate.Height = 27;
            this.DGV_Comment.Size = new System.Drawing.Size(539, 400);
            this.DGV_Comment.TabIndex = 0;
            this.DGV_Comment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Comment_CellContentClick);
            // 
            // DGV_Uncomment
            // 
            this.DGV_Uncomment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Uncomment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Uncomment.Location = new System.Drawing.Point(0, 0);
            this.DGV_Uncomment.Name = "DGV_Uncomment";
            this.DGV_Uncomment.RowHeadersWidth = 51;
            this.DGV_Uncomment.RowTemplate.Height = 27;
            this.DGV_Uncomment.Size = new System.Drawing.Size(691, 400);
            this.DGV_Uncomment.TabIndex = 1;
            this.DGV_Uncomment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Uncomment_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(393, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "異動會員名";
            // 
            // Tb_CustomerFirstName
            // 
            this.Tb_CustomerFirstName.Location = new System.Drawing.Point(481, 112);
            this.Tb_CustomerFirstName.Multiline = true;
            this.Tb_CustomerFirstName.Name = "Tb_CustomerFirstName";
            this.Tb_CustomerFirstName.Size = new System.Drawing.Size(68, 24);
            this.Tb_CustomerFirstName.TabIndex = 23;
            // 
            // Comment_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 801);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Comment_Management";
            this.Text = "Comment_Management";
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