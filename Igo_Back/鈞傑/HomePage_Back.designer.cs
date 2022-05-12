
namespace 期中專題.BackEnd
{
    partial class HomePage_Back
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MemberM = new System.Windows.Forms.Button();
            this.btn_ProductM = new System.Windows.Forms.Button();
            this.btn_OrdersM = new System.Windows.Forms.Button();
            this.btn_SupplierM = new System.Windows.Forms.Button();
            this.btn_FeedBackM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer1.Panel1.BackgroundImage = global::Igo_Back.Properties.Resources._004;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 700);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer2.Panel1.BackgroundImage = global::Igo_Back.Properties.Resources.圖片38;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_MemberM);
            this.splitContainer2.Panel1.Controls.Add(this.btn_ProductM);
            this.splitContainer2.Panel1.Controls.Add(this.btn_OrdersM);
            this.splitContainer2.Panel1.Controls.Add(this.btn_SupplierM);
            this.splitContainer2.Panel1.Controls.Add(this.btn_FeedBackM);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer2.Panel2.BackgroundImage = global::Igo_Back.Properties.Resources.圖片38;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(1283, 519);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "IGO version.2022.5.13";
            // 
            // btn_MemberM
            // 
            this.btn_MemberM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MemberM.BackColor = System.Drawing.Color.Transparent;
            this.btn_MemberM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberM.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_MemberM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MemberM.Image = global::Igo_Back.Properties.Resources._016_jpg;
            this.btn_MemberM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemberM.Location = new System.Drawing.Point(17, 276);
            this.btn_MemberM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MemberM.Name = "btn_MemberM";
            this.btn_MemberM.Size = new System.Drawing.Size(135, 44);
            this.btn_MemberM.TabIndex = 5;
            this.btn_MemberM.Text = "會員資料管理";
            this.btn_MemberM.UseVisualStyleBackColor = false;
            this.btn_MemberM.Click += new System.EventHandler(this.btn_MemberM_Click);
            // 
            // btn_ProductM
            // 
            this.btn_ProductM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductM.AutoSize = true;
            this.btn_ProductM.BackColor = System.Drawing.Color.Transparent;
            this.btn_ProductM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ProductM.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ProductM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ProductM.Location = new System.Drawing.Point(17, 146);
            this.btn_ProductM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ProductM.Name = "btn_ProductM";
            this.btn_ProductM.Size = new System.Drawing.Size(136, 44);
            this.btn_ProductM.TabIndex = 6;
            this.btn_ProductM.Text = "商品管理";
            this.btn_ProductM.UseVisualStyleBackColor = false;
            this.btn_ProductM.Click += new System.EventHandler(this.btn_ProductM_Click);
            // 
            // btn_OrdersM
            // 
            this.btn_OrdersM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OrdersM.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrdersM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_OrdersM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrdersM.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OrdersM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OrdersM.Location = new System.Drawing.Point(17, 18);
            this.btn_OrdersM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_OrdersM.Name = "btn_OrdersM";
            this.btn_OrdersM.Size = new System.Drawing.Size(135, 44);
            this.btn_OrdersM.TabIndex = 9;
            this.btn_OrdersM.Text = "訂單管理";
            this.btn_OrdersM.UseVisualStyleBackColor = false;
            this.btn_OrdersM.Click += new System.EventHandler(this.btn_OrdersM_Click);
            // 
            // btn_SupplierM
            // 
            this.btn_SupplierM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SupplierM.BackColor = System.Drawing.Color.Transparent;
            this.btn_SupplierM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SupplierM.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SupplierM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SupplierM.Location = new System.Drawing.Point(17, 211);
            this.btn_SupplierM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SupplierM.Name = "btn_SupplierM";
            this.btn_SupplierM.Size = new System.Drawing.Size(135, 44);
            this.btn_SupplierM.TabIndex = 8;
            this.btn_SupplierM.Text = "供應商管理";
            this.btn_SupplierM.UseVisualStyleBackColor = false;
            this.btn_SupplierM.Click += new System.EventHandler(this.btn_SupplierM_Click);
            // 
            // btn_FeedBackM
            // 
            this.btn_FeedBackM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FeedBackM.BackColor = System.Drawing.Color.Transparent;
            this.btn_FeedBackM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FeedBackM.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_FeedBackM.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_FeedBackM.Location = new System.Drawing.Point(17, 79);
            this.btn_FeedBackM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FeedBackM.Name = "btn_FeedBackM";
            this.btn_FeedBackM.Size = new System.Drawing.Size(135, 44);
            this.btn_FeedBackM.TabIndex = 7;
            this.btn_FeedBackM.Text = "評論管理";
            this.btn_FeedBackM.UseVisualStyleBackColor = false;
            this.btn_FeedBackM.Click += new System.EventHandler(this.btn_FeedBackM_Click);
            // 
            // HomePage_Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 700);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "HomePage_Back";
            this.Text = "HomePageBack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_OrdersM;
        private System.Windows.Forms.Button btn_SupplierM;
        private System.Windows.Forms.Button btn_FeedBackM;
        private System.Windows.Forms.Button btn_MemberM;
        private System.Windows.Forms.Button btn_ProductM;
        private System.Windows.Forms.Label label1;
    }
}



