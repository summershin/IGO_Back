
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_SupplierTitle = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.gpb_CURD = new System.Windows.Forms.GroupBox();
            this.lbl_CRUD__SAddress = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_CRUD_S_SPhone = new System.Windows.Forms.Label();
            this.txt_CRUD_SAddress = new System.Windows.Forms.TextBox();
            this.txt_CRUD_SPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CRUD_SName = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_crud_ID = new System.Windows.Forms.Button();
            this.lbl_SuppilerID = new System.Windows.Forms.Label();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.dgv_Upate_Delete = new System.Windows.Forms.DataGridView();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Search = new System.Windows.Forms.DataGridView();
            this.cmb_splID = new System.Windows.Forms.ComboBox();
            this.cmb_SupplierName = new System.Windows.Forms.ComboBox();
            this.btn_ReadAll = new System.Windows.Forms.Button();
            this.btn_Search_ID = new System.Windows.Forms.Button();
            this.grb_資料查詢 = new System.Windows.Forms.GroupBox();
            this.grb_Search_F_City = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_Search_F_Address = new System.Windows.Forms.Button();
            this.grb_Search_f_SplName = new System.Windows.Forms.GroupBox();
            this.txt_searchName = new System.Windows.Forms.TextBox();
            this.btn_txtsearchName = new System.Windows.Forms.Button();
            this.btn_Search_F_SplName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Del = new System.Windows.Forms.Button();
            this.dgv_PreviewAdd = new System.Windows.Forms.DataGridView();
            this.gpb_CURD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Upate_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).BeginInit();
            this.grb_資料查詢.SuspendLayout();
            this.grb_Search_F_City.SuspendLayout();
            this.grb_Search_f_SplName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreviewAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SupplierTitle
            // 
            this.lbl_SupplierTitle.AutoSize = true;
            this.lbl_SupplierTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SupplierTitle.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SupplierTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SupplierTitle.Location = new System.Drawing.Point(77, 22);
            this.lbl_SupplierTitle.Name = "lbl_SupplierTitle";
            this.lbl_SupplierTitle.Size = new System.Drawing.Size(267, 61);
            this.lbl_SupplierTitle.TabIndex = 4;
            this.lbl_SupplierTitle.Text = "供應商管理";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Transparent;
            this.btn_Create.BackgroundImage = global::Igo_Back.Properties.Resources.圖片36;
            this.btn_Create.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Create.Location = new System.Drawing.Point(403, 120);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(206, 51);
            this.btn_Create.TabIndex = 11;
            this.btn_Create.Text = "新增";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // gpb_CURD
            // 
            this.gpb_CURD.BackColor = System.Drawing.Color.Transparent;
            this.gpb_CURD.CausesValidation = false;
            this.gpb_CURD.Controls.Add(this.lbl_CRUD__SAddress);
            this.gpb_CURD.Controls.Add(this.btn_Clear);
            this.gpb_CURD.Controls.Add(this.lbl_CRUD_S_SPhone);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SAddress);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SPhone);
            this.gpb_CURD.Controls.Add(this.label9);
            this.gpb_CURD.Controls.Add(this.txt_CRUD_SName);
            this.gpb_CURD.Controls.Add(this.btn_Create);
            this.gpb_CURD.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpb_CURD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpb_CURD.Location = new System.Drawing.Point(12, 17);
            this.gpb_CURD.Name = "gpb_CURD";
            this.gpb_CURD.Size = new System.Drawing.Size(763, 178);
            this.gpb_CURD.TabIndex = 1;
            this.gpb_CURD.TabStop = false;
            this.gpb_CURD.Text = "新增供應商資料";
            // 
            // lbl_CRUD__SAddress
            // 
            this.lbl_CRUD__SAddress.AutoSize = true;
            this.lbl_CRUD__SAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CRUD__SAddress.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CRUD__SAddress.Location = new System.Drawing.Point(480, 39);
            this.lbl_CRUD__SAddress.Name = "lbl_CRUD__SAddress";
            this.lbl_CRUD__SAddress.Size = new System.Drawing.Size(129, 28);
            this.lbl_CRUD__SAddress.TabIndex = 14;
            this.lbl_CRUD__SAddress.Text = "供應商地址 :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BackgroundImage = global::Igo_Back.Properties.Resources.圖片36;
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(625, 120);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(122, 51);
            this.btn_Clear.TabIndex = 24;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_CRUD_S_SPhone
            // 
            this.lbl_CRUD_S_SPhone.AutoSize = true;
            this.lbl_CRUD_S_SPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CRUD_S_SPhone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CRUD_S_SPhone.Location = new System.Drawing.Point(247, 39);
            this.lbl_CRUD_S_SPhone.Name = "lbl_CRUD_S_SPhone";
            this.lbl_CRUD_S_SPhone.Size = new System.Drawing.Size(129, 28);
            this.lbl_CRUD_S_SPhone.TabIndex = 17;
            this.lbl_CRUD_S_SPhone.Text = "供應商電話 :";
            // 
            // txt_CRUD_SAddress
            // 
            this.txt_CRUD_SAddress.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SAddress.Location = new System.Drawing.Point(480, 70);
            this.txt_CRUD_SAddress.Name = "txt_CRUD_SAddress";
            this.txt_CRUD_SAddress.Size = new System.Drawing.Size(261, 27);
            this.txt_CRUD_SAddress.TabIndex = 16;
            // 
            // txt_CRUD_SPhone
            // 
            this.txt_CRUD_SPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SPhone.Location = new System.Drawing.Point(247, 69);
            this.txt_CRUD_SPhone.Name = "txt_CRUD_SPhone";
            this.txt_CRUD_SPhone.Size = new System.Drawing.Size(217, 27);
            this.txt_CRUD_SPhone.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "供應商名稱 :";
            // 
            // txt_CRUD_SName
            // 
            this.txt_CRUD_SName.AllowDrop = true;
            this.txt_CRUD_SName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CRUD_SName.Location = new System.Drawing.Point(13, 70);
            this.txt_CRUD_SName.Name = "txt_CRUD_SName";
            this.txt_CRUD_SName.Size = new System.Drawing.Size(217, 27);
            this.txt_CRUD_SName.TabIndex = 11;
            // 
            // btn_ADD
            // 
            this.btn_ADD.BackColor = System.Drawing.Color.Transparent;
            this.btn_ADD.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_ADD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ADD.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ADD.Location = new System.Drawing.Point(363, 573);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(212, 39);
            this.btn_ADD.TabIndex = 25;
            this.btn_ADD.Text = "預覽新增資料";
            this.btn_ADD.UseVisualStyleBackColor = false;
            this.btn_ADD.Visible = false;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BackgroundImage = global::Igo_Back.Properties.Resources.圖片36;
            this.btn_Update.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Location = new System.Drawing.Point(603, 255);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(196, 69);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Delete.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(1518, 1071);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(203, 69);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_crud_ID
            // 
            this.btn_crud_ID.BackColor = System.Drawing.Color.Transparent;
            this.btn_crud_ID.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_crud_ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_crud_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_crud_ID.Location = new System.Drawing.Point(339, 214);
            this.btn_crud_ID.Name = "btn_crud_ID";
            this.btn_crud_ID.Size = new System.Drawing.Size(90, 30);
            this.btn_crud_ID.TabIndex = 24;
            this.btn_crud_ID.Text = "Search";
            this.btn_crud_ID.UseVisualStyleBackColor = false;
            this.btn_crud_ID.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_SuppilerID
            // 
            this.lbl_SuppilerID.AutoSize = true;
            this.lbl_SuppilerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SuppilerID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SuppilerID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SuppilerID.Location = new System.Drawing.Point(20, 218);
            this.lbl_SuppilerID.Name = "lbl_SuppilerID";
            this.lbl_SuppilerID.Size = new System.Drawing.Size(134, 28);
            this.lbl_SuppilerID.TabIndex = 25;
            this.lbl_SuppilerID.Text = "供應商編號  :";
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(158, 218);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(175, 24);
            this.cmb_SupplierID.TabIndex = 26;
            // 
            // dgv_Upate_Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Upate_Delete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Upate_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Upate_Delete.Location = new System.Drawing.Point(36, 256);
            this.dgv_Upate_Delete.Name = "dgv_Upate_Delete";
            this.dgv_Upate_Delete.RowTemplate.Height = 24;
            this.dgv_Upate_Delete.Size = new System.Drawing.Size(549, 356);
            this.dgv_Upate_Delete.TabIndex = 19;
            // 
            // dgv_Search
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Search.Location = new System.Drawing.Point(13, 322);
            this.dgv_Search.Name = "dgv_Search";
            this.dgv_Search.RowTemplate.Height = 24;
            this.dgv_Search.Size = new System.Drawing.Size(579, 262);
            this.dgv_Search.TabIndex = 2;
            // 
            // cmb_splID
            // 
            this.cmb_splID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_splID.FormattingEnabled = true;
            this.cmb_splID.Location = new System.Drawing.Point(153, 282);
            this.cmb_splID.Name = "cmb_splID";
            this.cmb_splID.Size = new System.Drawing.Size(175, 28);
            this.cmb_splID.TabIndex = 31;
            // 
            // cmb_SupplierName
            // 
            this.cmb_SupplierName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_SupplierName.FormattingEnabled = true;
            this.cmb_SupplierName.Location = new System.Drawing.Point(153, 243);
            this.cmb_SupplierName.Name = "cmb_SupplierName";
            this.cmb_SupplierName.Size = new System.Drawing.Size(175, 29);
            this.cmb_SupplierName.TabIndex = 22;
            // 
            // btn_ReadAll
            // 
            this.btn_ReadAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_ReadAll.BackgroundImage = global::Igo_Back.Properties.Resources.圖片36;
            this.btn_ReadAll.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReadAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ReadAll.Location = new System.Drawing.Point(429, 243);
            this.btn_ReadAll.Name = "btn_ReadAll";
            this.btn_ReadAll.Size = new System.Drawing.Size(163, 73);
            this.btn_ReadAll.TabIndex = 23;
            this.btn_ReadAll.Text = "查詢所有";
            this.btn_ReadAll.UseVisualStyleBackColor = false;
            this.btn_ReadAll.Click += new System.EventHandler(this.btn_ReadAll_Click);
            // 
            // btn_Search_ID
            // 
            this.btn_Search_ID.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search_ID.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_Search_ID.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search_ID.Location = new System.Drawing.Point(334, 282);
            this.btn_Search_ID.Name = "btn_Search_ID";
            this.btn_Search_ID.Size = new System.Drawing.Size(89, 34);
            this.btn_Search_ID.TabIndex = 30;
            this.btn_Search_ID.Text = "Search";
            this.btn_Search_ID.UseVisualStyleBackColor = false;
            this.btn_Search_ID.Click += new System.EventHandler(this.btn_Search_ID_Click);
            // 
            // grb_資料查詢
            // 
            this.grb_資料查詢.BackColor = System.Drawing.Color.Transparent;
            this.grb_資料查詢.Controls.Add(this.grb_Search_F_City);
            this.grb_資料查詢.Controls.Add(this.grb_Search_f_SplName);
            this.grb_資料查詢.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_資料查詢.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grb_資料查詢.Location = new System.Drawing.Point(13, 15);
            this.grb_資料查詢.Name = "grb_資料查詢";
            this.grb_資料查詢.Size = new System.Drawing.Size(561, 215);
            this.grb_資料查詢.TabIndex = 28;
            this.grb_資料查詢.TabStop = false;
            this.grb_資料查詢.Text = "資料查詢";
            // 
            // grb_Search_F_City
            // 
            this.grb_Search_F_City.BackColor = System.Drawing.Color.Transparent;
            this.grb_Search_F_City.Controls.Add(this.txt_address);
            this.grb_Search_F_City.Controls.Add(this.btn_Search_F_Address);
            this.grb_Search_F_City.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_Search_F_City.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_Search_F_City.Location = new System.Drawing.Point(90, 116);
            this.grb_Search_F_City.Name = "grb_Search_F_City";
            this.grb_Search_F_City.Size = new System.Drawing.Size(409, 78);
            this.grb_Search_F_City.TabIndex = 28;
            this.grb_Search_F_City.TabStop = false;
            this.grb_Search_F_City.Text = "地址相關查詢";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.Location = new System.Drawing.Point(18, 29);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(250, 35);
            this.txt_address.TabIndex = 26;
            // 
            // btn_Search_F_Address
            // 
            this.btn_Search_F_Address.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search_F_Address.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_Search_F_Address.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search_F_Address.Location = new System.Drawing.Point(274, 29);
            this.btn_Search_F_Address.Name = "btn_Search_F_Address";
            this.btn_Search_F_Address.Size = new System.Drawing.Size(117, 36);
            this.btn_Search_F_Address.TabIndex = 28;
            this.btn_Search_F_Address.Text = "Search";
            this.btn_Search_F_Address.UseVisualStyleBackColor = false;
            this.btn_Search_F_Address.Click += new System.EventHandler(this.btn_Search_F_Address_Click);
            // 
            // grb_Search_f_SplName
            // 
            this.grb_Search_f_SplName.BackColor = System.Drawing.Color.Transparent;
            this.grb_Search_f_SplName.Controls.Add(this.txt_searchName);
            this.grb_Search_f_SplName.Controls.Add(this.btn_txtsearchName);
            this.grb_Search_f_SplName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grb_Search_f_SplName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_Search_f_SplName.Location = new System.Drawing.Point(90, 43);
            this.grb_Search_f_SplName.Name = "grb_Search_f_SplName";
            this.grb_Search_f_SplName.Size = new System.Drawing.Size(409, 78);
            this.grb_Search_f_SplName.TabIndex = 18;
            this.grb_Search_f_SplName.TabStop = false;
            this.grb_Search_f_SplName.Text = "供應商名稱查詢";
            // 
            // txt_searchName
            // 
            this.txt_searchName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_searchName.Location = new System.Drawing.Point(18, 32);
            this.txt_searchName.Name = "txt_searchName";
            this.txt_searchName.Size = new System.Drawing.Size(250, 35);
            this.txt_searchName.TabIndex = 28;
            // 
            // btn_txtsearchName
            // 
            this.btn_txtsearchName.BackColor = System.Drawing.Color.Transparent;
            this.btn_txtsearchName.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_txtsearchName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_txtsearchName.Location = new System.Drawing.Point(274, 32);
            this.btn_txtsearchName.Name = "btn_txtsearchName";
            this.btn_txtsearchName.Size = new System.Drawing.Size(117, 36);
            this.btn_txtsearchName.TabIndex = 28;
            this.btn_txtsearchName.Text = "Search";
            this.btn_txtsearchName.UseVisualStyleBackColor = false;
            this.btn_txtsearchName.Click += new System.EventHandler(this.btn_txtsearchName_Click);
            // 
            // btn_Search_F_SplName
            // 
            this.btn_Search_F_SplName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search_F_SplName.BackgroundImage = global::Igo_Back.Properties.Resources.圖片40;
            this.btn_Search_F_SplName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search_F_SplName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search_F_SplName.Location = new System.Drawing.Point(334, 243);
            this.btn_Search_F_SplName.Name = "btn_Search_F_SplName";
            this.btn_Search_F_SplName.Size = new System.Drawing.Size(89, 33);
            this.btn_Search_F_SplName.TabIndex = 27;
            this.btn_Search_F_SplName.Text = "Search";
            this.btn_Search_F_SplName.UseVisualStyleBackColor = false;
            this.btn_Search_F_SplName.Click += new System.EventHandler(this.btn_Search_F_SplName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "供應商名稱  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "供應商編號  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.grb_資料查詢);
            this.panel1.Controls.Add(this.cmb_SupplierName);
            this.panel1.Controls.Add(this.btn_ReadAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_splID);
            this.panel1.Controls.Add(this.btn_Search_ID);
            this.panel1.Controls.Add(this.dgv_Search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Search_F_SplName);
            this.panel1.Location = new System.Drawing.Point(73, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 612);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Controls.Add(this.gpb_CURD);
            this.panel2.Controls.Add(this.btn_ADD);
            this.panel2.Controls.Add(this.cmb_SupplierID);
            this.panel2.Controls.Add(this.lbl_SuppilerID);
            this.panel2.Controls.Add(this.dgv_PreviewAdd);
            this.panel2.Controls.Add(this.btn_crud_ID);
            this.panel2.Controls.Add(this.dgv_Upate_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Location = new System.Drawing.Point(723, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 612);
            this.panel2.TabIndex = 34;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BackgroundImage = global::Igo_Back.Properties.Resources.圖片36;
            this.btn_Del.Font = new System.Drawing.Font("微軟正黑體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del.Location = new System.Drawing.Point(603, 330);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(200, 71);
            this.btn_Del.TabIndex = 28;
            this.btn_Del.Text = "刪除";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // dgv_PreviewAdd
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PreviewAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PreviewAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PreviewAdd.Location = new System.Drawing.Point(36, 419);
            this.dgv_PreviewAdd.Name = "dgv_PreviewAdd";
            this.dgv_PreviewAdd.RowTemplate.Height = 24;
            this.dgv_PreviewAdd.Size = new System.Drawing.Size(549, 69);
            this.dgv_PreviewAdd.TabIndex = 27;
            this.dgv_PreviewAdd.Visible = false;
            // 
            // Frm_SupplierData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igo_Back.Properties.Resources.圖片38;
            this.ClientSize = new System.Drawing.Size(1601, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_SupplierTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SupplierData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供應商管理 SupplierData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_SupplierData_Load);
            this.gpb_CURD.ResumeLayout(false);
            this.gpb_CURD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Upate_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Search)).EndInit();
            this.grb_資料查詢.ResumeLayout(false);
            this.grb_Search_F_City.ResumeLayout(false);
            this.grb_Search_F_City.PerformLayout();
            this.grb_Search_f_SplName.ResumeLayout(false);
            this.grb_Search_f_SplName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreviewAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_SupplierTitle;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.GroupBox gpb_CURD;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_CRUD_S_SPhone;
        private System.Windows.Forms.TextBox txt_CRUD_SAddress;
        private System.Windows.Forms.Label lbl_CRUD__SAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CRUD_SName;
        private System.Windows.Forms.TextBox txt_CRUD_SPhone;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_crud_ID;
        private System.Windows.Forms.Label lbl_SuppilerID;
        private System.Windows.Forms.ComboBox cmb_SupplierID;
        private System.Windows.Forms.DataGridView dgv_Upate_Delete;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search_F_SplName;
        private System.Windows.Forms.GroupBox grb_資料查詢;
        private System.Windows.Forms.GroupBox grb_Search_F_City;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_Search_F_Address;
        private System.Windows.Forms.GroupBox grb_Search_f_SplName;
        private System.Windows.Forms.TextBox txt_searchName;
        private System.Windows.Forms.Button btn_txtsearchName;
        private System.Windows.Forms.Button btn_Search_ID;
        private System.Windows.Forms.Button btn_ReadAll;
        private System.Windows.Forms.ComboBox cmb_SupplierName;
        private System.Windows.Forms.ComboBox cmb_splID;
        private System.Windows.Forms.DataGridView dgv_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridView dgv_PreviewAdd;
    }
}