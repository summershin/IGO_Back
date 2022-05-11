
namespace 期中專題
{
    partial class Frm_SupplierData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.lbl_SupplierTitle = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.gpb_CURD = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.lbl_CRUD_S_SPhone = new System.Windows.Forms.Label();
            this.txt_CRUD_SAddress = new System.Windows.Forms.TextBox();
            this.lbl_CRUD__SAddress = new System.Windows.Forms.Label();
            this.txt_CRUD_SPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CRUD_SName = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ReadAll = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_search_f_ID = new System.Windows.Forms.Button();
            this.lbl_SuppilerID = new System.Windows.Forms.Label();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.dgv_Upate_Delete = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_SupplierName = new System.Windows.Forms.ComboBox();
            this.grb_Search_f_SplName = new System.Windows.Forms.GroupBox();
            this.btn_Search_F_SplName = new System.Windows.Forms.Button();
            this.grb_資料查詢 = new System.Windows.Forms.GroupBox();
            this.grb_Search_F_City = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Search_F_Address = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.gpb_CURD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Upate_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.grb_Search_f_SplName.SuspendLayout();
            this.grb_資料查詢.SuspendLayout();
            this.grb_Search_F_City.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Search
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Location = new System.Drawing.Point(661, 20);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowTemplate.Height = 24;
            this.dgv_Search.Size = new System.Drawing.Size(633, 258);
            this.dgv_Search.TabIndex = 2;
            // 
            // lbl_SupplierTitle
            // 
            this.lbl_SupplierTitle.AutoSize = true;
            this.lbl_SupplierTitle.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SupplierTitle.Location = new System.Drawing.Point(4, 9);
            this.lbl_SupplierTitle.Name = "lbl_SupplierTitle";
            this.lbl_SupplierTitle.Size = new System.Drawing.Size(260, 48);
            this.lbl_SupplierTitle.TabIndex = 4;
            this.lbl_SupplierTitle.Text = "供應商管理";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Create.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Create.Location = new System.Drawing.Point(283, 195);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(144, 46);
            this.btn_Create.TabIndex = 11;
            this.btn_Create.Text = "確認新增";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // gpb_CURD
            // 
            this.gpb_CURD.BackColor = System.Drawing.Color.Transparent;
            this.gpb_CURD.Controls.Add(this.btn_Clear);
            this.gpb_CURD.Controls.Add(this.btn_ADD);
            this.gpb_CURD.Controls.Add(this.lbl_CRUD_S_SPhone);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SAddress);
            this.gpb_CURD.Controls.Add(this.lbl_CRUD__SAddress);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SPhone);
            this.gpb_CURD.Controls.Add(this.btn_Create);
            this.gpb_CURD.Controls.Add(this.label9);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SName);
            this.gpb_CURD.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpb_CURD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpb_CURD.Location = new System.Drawing.Point(12, 384);
            this.gpb_CURD.Name = "gpb_CURD";
            this.gpb_CURD.Size = new System.Drawing.Size(621, 266);
            this.gpb_CURD.TabIndex = 1;
            this.gpb_CURD.TabStop = false;
            this.gpb_CURD.Text = "新增供應商資料";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(430, 143);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(170, 98);
            this.btn_Clear.TabIndex = 24;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ADD.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ADD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ADD.Location = new System.Drawing.Point(257, 143);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(170, 46);
            this.btn_ADD.TabIndex = 25;
            this.btn_ADD.Text = "預覽新增資料";
            this.btn_ADD.UseVisualStyleBackColor = false;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // lbl_CRUD_S_SPhone
            // 
            this.lbl_CRUD_S_SPhone.AutoSize = true;
            this.lbl_CRUD_S_SPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CRUD_S_SPhone.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CRUD_S_SPhone.Location = new System.Drawing.Point(20, 129);
            this.lbl_CRUD_S_SPhone.Name = "lbl_CRUD_S_SPhone";
            this.lbl_CRUD_S_SPhone.Size = new System.Drawing.Size(127, 23);
            this.lbl_CRUD_S_SPhone.TabIndex = 17;
            this.lbl_CRUD_S_SPhone.Text = "供應商電話 :";
            // 
            // txt_CRUD_SAddress
            // 
            this.txt_CRUD_SAddress.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SAddress.Location = new System.Drawing.Point(333, 61);
            this.txt_CRUD_SAddress.Name = "txt_CRUD_SAddress";
            this.txt_CRUD_SAddress.Size = new System.Drawing.Size(261, 27);
            this.txt_CRUD_SAddress.TabIndex = 16;
            // 
            // lbl_CRUD__SAddress
            // 
            this.lbl_CRUD__SAddress.AutoSize = true;
            this.lbl_CRUD__SAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CRUD__SAddress.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CRUD__SAddress.Location = new System.Drawing.Point(333, 41);
            this.lbl_CRUD__SAddress.Name = "lbl_CRUD__SAddress";
            this.lbl_CRUD__SAddress.Size = new System.Drawing.Size(127, 23);
            this.lbl_CRUD__SAddress.TabIndex = 14;
            this.lbl_CRUD__SAddress.Text = "供應商地址 :";
            // 
            // txt_CRUD_SPhone
            // 
            this.txt_CRUD_SPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SPhone.Location = new System.Drawing.Point(20, 148);
            this.txt_CRUD_SPhone.Name = "txt_CRUD_SPhone";
            this.txt_CRUD_SPhone.Size = new System.Drawing.Size(148, 27);
            this.txt_CRUD_SPhone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "供應商名稱 :";
            // 
            // txt_CRUD_SName
            // 
            this.txt_CRUD_SName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SName.Location = new System.Drawing.Point(20, 61);
            this.txt_CRUD_SName.Name = "txt_CRUD_SName";
            this.txt_CRUD_SName.Size = new System.Drawing.Size(217, 27);
            this.txt_CRUD_SName.TabIndex = 11;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Update.Location = new System.Drawing.Point(998, 647);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 65);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_ReadAll
            // 
            this.btn_ReadAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ReadAll.Font = new System.Drawing.Font("新細明體-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReadAll.Location = new System.Drawing.Point(1100, 284);
            this.btn_ReadAll.Name = "btn_ReadAll";
            this.btn_ReadAll.Size = new System.Drawing.Size(194, 40);
            this.btn_ReadAll.TabIndex = 23;
            this.btn_ReadAll.Text = "查詢所有";
            this.btn_ReadAll.UseVisualStyleBackColor = false;
            this.btn_ReadAll.Click += new System.EventHandler(this.btn_ReadAll_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Delete.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(1149, 647);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 65);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_search_f_ID
            // 
            this.btn_search_f_ID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search_f_ID.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_search_f_ID.Location = new System.Drawing.Point(1221, 418);
            this.btn_search_f_ID.Name = "btn_search_f_ID";
            this.btn_search_f_ID.Size = new System.Drawing.Size(73, 30);
            this.btn_search_f_ID.TabIndex = 24;
            this.btn_search_f_ID.Text = "Search";
            this.btn_search_f_ID.UseVisualStyleBackColor = false;
            this.btn_search_f_ID.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_SuppilerID
            // 
            this.lbl_SuppilerID.AutoSize = true;
            this.lbl_SuppilerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SuppilerID.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SuppilerID.Location = new System.Drawing.Point(902, 423);
            this.lbl_SuppilerID.Name = "lbl_SuppilerID";
            this.lbl_SuppilerID.Size = new System.Drawing.Size(132, 23);
            this.lbl_SuppilerID.TabIndex = 25;
            this.lbl_SuppilerID.Text = "供應商編號  :";
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(1040, 423);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(175, 24);
            this.cmb_SupplierID.TabIndex = 26;
            // 
            // dgv_Upate_Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Upate_Delete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Upate_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Upate_Delete.Location = new System.Drawing.Point(690, 445);
            this.dgv_Upate_Delete.Name = "dgv_Upate_Delete";
            this.dgv_Upate_Delete.RowTemplate.Height = 24;
            this.dgv_Upate_Delete.Size = new System.Drawing.Size(604, 196);
            this.dgv_Upate_Delete.TabIndex = 19;
            // 
            // cmb_SupplierName
            // 
            this.cmb_SupplierName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SupplierName.FormattingEnabled = true;
            this.cmb_SupplierName.Location = new System.Drawing.Point(18, 32);
            this.cmb_SupplierName.Name = "cmb_SupplierName";
            this.cmb_SupplierName.Size = new System.Drawing.Size(147, 24);
            this.cmb_SupplierName.TabIndex = 22;
            // 
            // grb_Search_f_SplName
            // 
            this.grb_Search_f_SplName.BackColor = System.Drawing.Color.Transparent;
            this.grb_Search_f_SplName.Controls.Add(this.cmb_SupplierName);
            this.grb_Search_f_SplName.Controls.Add(this.btn_Search_F_SplName);
            this.grb_Search_f_SplName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_Search_f_SplName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_Search_f_SplName.Location = new System.Drawing.Point(26, 32);
            this.grb_Search_f_SplName.Name = "grb_Search_f_SplName";
            this.grb_Search_f_SplName.Size = new System.Drawing.Size(440, 78);
            this.grb_Search_f_SplName.TabIndex = 18;
            this.grb_Search_f_SplName.TabStop = false;
            this.grb_Search_f_SplName.Text = "供應商名稱查詢";
            // 
            // btn_Search_F_SplName
            // 
            this.btn_Search_F_SplName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search_F_SplName.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search_F_SplName.Location = new System.Drawing.Point(206, 24);
            this.btn_Search_F_SplName.Name = "btn_Search_F_SplName";
            this.btn_Search_F_SplName.Size = new System.Drawing.Size(183, 36);
            this.btn_Search_F_SplName.TabIndex = 27;
            this.btn_Search_F_SplName.Text = "Search";
            this.btn_Search_F_SplName.UseVisualStyleBackColor = false;
            this.btn_Search_F_SplName.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb_資料查詢
            // 
            this.grb_資料查詢.BackColor = System.Drawing.Color.Transparent;
            this.grb_資料查詢.Controls.Add(this.grb_Search_F_City);
            this.grb_資料查詢.Controls.Add(this.grb_Search_f_SplName);
            this.grb_資料查詢.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_資料查詢.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_資料查詢.Location = new System.Drawing.Point(12, 134);
            this.grb_資料查詢.Name = "grb_資料查詢";
            this.grb_資料查詢.Size = new System.Drawing.Size(621, 224);
            this.grb_資料查詢.TabIndex = 28;
            this.grb_資料查詢.TabStop = false;
            this.grb_資料查詢.Text = "資料查詢";
            // 
            // grb_Search_F_City
            // 
            this.grb_Search_F_City.BackColor = System.Drawing.Color.Transparent;
            this.grb_Search_F_City.Controls.Add(this.textBox1);
            this.grb_Search_F_City.Controls.Add(this.btn_Search_F_Address);
            this.grb_Search_F_City.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_Search_F_City.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_Search_F_City.Location = new System.Drawing.Point(26, 116);
            this.grb_Search_F_City.Name = "grb_Search_F_City";
            this.grb_Search_F_City.Size = new System.Drawing.Size(440, 78);
            this.grb_Search_F_City.TabIndex = 28;
            this.grb_Search_F_City.TabStop = false;
            this.grb_Search_F_City.Text = "地址相關查詢";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(18, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 26;
            // 
            // btn_Search_F_Address
            // 
            this.btn_Search_F_Address.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search_F_Address.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search_F_Address.Location = new System.Drawing.Point(206, 20);
            this.btn_Search_F_Address.Name = "btn_Search_F_Address";
            this.btn_Search_F_Address.Size = new System.Drawing.Size(183, 36);
            this.btn_Search_F_Address.TabIndex = 28;
            this.btn_Search_F_Address.Text = "Search";
            this.btn_Search_F_Address.UseVisualStyleBackColor = false;
            this.btn_Search_F_Address.Click += new System.EventHandler(this.btn_Search_F_Address_Click);
            // 
            // Frm_SupplierData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 763);
            this.Controls.Add(this.grb_資料查詢);
            this.Controls.Add(this.btn_ReadAll);
            this.Controls.Add(this.dgv_Upate_Delete);
            this.Controls.Add(this.btn_search_f_ID);
            this.Controls.Add(this.lbl_SuppilerID);
            this.Controls.Add(this.cmb_SupplierID);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_SupplierTitle);
            this.Controls.Add(this.dgv_Search);
            this.Controls.Add(this.gpb_CURD);
            this.Name = "Frm_SupplierData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供應商管理 SupplierData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.gpb_CURD.ResumeLayout(false);
            this.gpb_CURD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Upate_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.grb_Search_f_SplName.ResumeLayout(false);
            this.grb_資料查詢.ResumeLayout(false);
            this.grb_Search_F_City.ResumeLayout(false);
            this.grb_Search_F_City.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Label lbl_SupplierTitle;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.GroupBox gpb_CURD;
        private System.Windows.Forms.Button btn_ReadAll;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_CRUD_S_SPhone;
        private System.Windows.Forms.TextBox txt_CRUD_SAddress;
        private System.Windows.Forms.Label lbl_CRUD__SAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CRUD_SName;
        private System.Windows.Forms.TextBox txt_CRUD_SPhone;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_search_f_ID;
        private System.Windows.Forms.Label lbl_SuppilerID;
        private System.Windows.Forms.ComboBox cmb_SupplierID;
        private System.Windows.Forms.DataGridView dgv_Upate_Delete;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.ComboBox cmb_SupplierName;
        private System.Windows.Forms.GroupBox grb_Search_f_SplName;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_Search_F_SplName;
        private System.Windows.Forms.GroupBox grb_資料查詢;
        private System.Windows.Forms.GroupBox grb_Search_F_City;
        private System.Windows.Forms.Button btn_Search_F_Address;
        private System.Windows.Forms.TextBox textBox1;
    }
}