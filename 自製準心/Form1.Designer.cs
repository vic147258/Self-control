namespace 自製準心
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放到最大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一般大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縮到最小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.設定上下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定左右ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(180, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定上下ToolStripMenuItem,
            this.設定左右ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.視窗設定ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 202);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "向上微調";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "向右微調";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem4.Text = "向下微調";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem5.Text = "向左微調";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // 視窗設定ToolStripMenuItem
            // 
            this.視窗設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放到最大ToolStripMenuItem,
            this.一般大小ToolStripMenuItem,
            this.縮到最小ToolStripMenuItem});
            this.視窗設定ToolStripMenuItem.Name = "視窗設定ToolStripMenuItem";
            this.視窗設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.視窗設定ToolStripMenuItem.Text = "視窗設定";
            // 
            // 放到最大ToolStripMenuItem
            // 
            this.放到最大ToolStripMenuItem.Name = "放到最大ToolStripMenuItem";
            this.放到最大ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.放到最大ToolStripMenuItem.Text = "放到最大";
            this.放到最大ToolStripMenuItem.Click += new System.EventHandler(this.放到最大ToolStripMenuItem_Click);
            // 
            // 一般大小ToolStripMenuItem
            // 
            this.一般大小ToolStripMenuItem.Name = "一般大小ToolStripMenuItem";
            this.一般大小ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.一般大小ToolStripMenuItem.Text = "一般大小";
            this.一般大小ToolStripMenuItem.Click += new System.EventHandler(this.一般大小ToolStripMenuItem_Click);
            // 
            // 縮到最小ToolStripMenuItem
            // 
            this.縮到最小ToolStripMenuItem.Name = "縮到最小ToolStripMenuItem";
            this.縮到最小ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.縮到最小ToolStripMenuItem.Text = "縮到最小";
            this.縮到最小ToolStripMenuItem.Click += new System.EventHandler(this.縮到最小ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "關閉";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 設定上下ToolStripMenuItem
            // 
            this.設定上下ToolStripMenuItem.Name = "設定上下ToolStripMenuItem";
            this.設定上下ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.設定上下ToolStripMenuItem.Text = "設定上下";
            this.設定上下ToolStripMenuItem.Click += new System.EventHandler(this.設定上下ToolStripMenuItem_Click);
            // 
            // 設定左右ToolStripMenuItem
            // 
            this.設定左右ToolStripMenuItem.Name = "設定左右ToolStripMenuItem";
            this.設定左右ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.設定左右ToolStripMenuItem.Text = "設定左右";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 349);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "準心";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 視窗設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放到最大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 縮到最小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定上下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定左右ToolStripMenuItem;
    }
}

