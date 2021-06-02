
namespace Dev_FormStock
{
    partial class FM_Main
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
            this.BarMenu = new System.Windows.Forms.MenuStrip();
            this.CustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FM_Seed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FM_Port2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.space = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.FM_PORT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FM_STOCK = new System.Windows.Forms.ToolStripMenuItem();
            this.MyTabControl1 = new Dev_FormStock.MyTabControler();
            this.BarMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarMenu
            // 
            this.BarMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerMenu,
            this.ManagerMenu});
            this.BarMenu.Location = new System.Drawing.Point(0, 0);
            this.BarMenu.Name = "BarMenu";
            this.BarMenu.Size = new System.Drawing.Size(1070, 28);
            this.BarMenu.TabIndex = 11;
            this.BarMenu.Text = "메뉴";
            // 
            // CustomerMenu
            // 
            this.CustomerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FM_Option,
            this.toolStripSeparator3,
            this.FM_Seed,
            this.toolStripMenuItem2});
            this.CustomerMenu.Name = "CustomerMenu";
            this.CustomerMenu.Size = new System.Drawing.Size(88, 24);
            this.CustomerMenu.Text = "고객 메뉴";
            // 
            // FM_Option
            // 
            this.FM_Option.Name = "FM_Option";
            this.FM_Option.Size = new System.Drawing.Size(172, 26);
            this.FM_Option.Text = "전체 주식";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // FM_Seed
            // 
            this.FM_Seed.Name = "FM_Seed";
            this.FM_Seed.Size = new System.Drawing.Size(172, 26);
            this.FM_Seed.Text = "예수금 입금";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 26);
            this.toolStripMenuItem2.Text = "나의 주식";
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FM_Port2});
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.Size = new System.Drawing.Size(103, 24);
            this.ManagerMenu.Text = "관리자 메뉴";
            // 
            // FM_Port2
            // 
            this.FM_Port2.Name = "FM_Port2";
            this.FM_Port2.Size = new System.Drawing.Size(157, 26);
            this.FM_Port2.Text = "고객 관리";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.space,
            this.tssUserName,
            this.tssNowDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 769);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1070, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // space
            // 
            this.space.AutoSize = false;
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(751, 20);
            this.space.Spring = true;
            this.space.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tssUserName
            // 
            this.tssUserName.AutoSize = false;
            this.tssUserName.Name = "tssUserName";
            this.tssUserName.Size = new System.Drawing.Size(152, 20);
            this.tssUserName.Text = "toolStripStatusLabel2";
            // 
            // tssNowDate
            // 
            this.tssNowDate.AutoSize = false;
            this.tssNowDate.Name = "tssNowDate";
            this.tssNowDate.Size = new System.Drawing.Size(152, 20);
            this.tssNowDate.Text = "toolStripStatusLabel3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnClose,
            this.toolStripSeparator2,
            this.btnHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 43);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Dev_FormStock.Properties.Resources.close_512;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 40);
            this.btnExit.Text = "종료";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::Dev_FormStock.Properties.Resources.reply_512;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 40);
            this.btnClose.Text = "닫기";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnHome
            // 
            this.btnHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = global::Dev_FormStock.Properties.Resources.dashboard_512;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(1, 1, 10, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 40);
            this.btnHome.Text = "홈화면";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FM_PORT
            // 
            this.FM_PORT.Name = "FM_PORT";
            this.FM_PORT.Size = new System.Drawing.Size(157, 26);
            this.FM_PORT.Text = "나의 주식";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // FM_STOCK
            // 
            this.FM_STOCK.Name = "FM_STOCK";
            this.FM_STOCK.Size = new System.Drawing.Size(157, 26);
            this.FM_STOCK.Text = "전체 주식";
            // 
            // MyTabControl1
            // 
            this.MyTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTabControl1.Location = new System.Drawing.Point(0, 71);
            this.MyTabControl1.Name = "MyTabControl1";
            this.MyTabControl1.SelectedIndex = 0;
            this.MyTabControl1.Size = new System.Drawing.Size(1070, 698);
            this.MyTabControl1.TabIndex = 19;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 795);
            this.Controls.Add(this.MyTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BarMenu);
            this.IsMdiContainer = true;
            this.Name = "FM_Main";
            this.Text = "메인 화면";
            this.BarMenu.ResumeLayout(false);
            this.BarMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip BarMenu;
        private System.Windows.Forms.ToolStripMenuItem CustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem ManagerMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel space;
        private System.Windows.Forms.ToolStripStatusLabel tssUserName;
        private System.Windows.Forms.ToolStripStatusLabel tssNowDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FM_PORT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FM_STOCK;
        private System.Windows.Forms.ToolStripMenuItem FM_Port2;
        private System.Windows.Forms.ToolStripMenuItem FM_Option;
        private MyTabControler MyTabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FM_Seed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}