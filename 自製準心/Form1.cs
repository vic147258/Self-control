using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 自製準心
{
    public partial class Form1 : Form
    {


        Bitmap bm;
        Graphics g;
        GraphicsPath gp;
        GraphicsPath gp2;

        Pen pen1 = new Pen(Color.Blue, 2);
        Pen pen2 = new Pen(Color.Red, 3);

        int theCrosshairSize = 41;

        int Move_X = 0, Move_Y = -20;

        int forPayday_X = 0,forPayday_Y = 21;


        public Form1()
        {
            InitializeComponent();

            this.SizeChanged += new EventHandler(Form1_SizeChanged);
            pictureBox1.Size = new System.Drawing.Size(theCrosshairSize, theCrosshairSize);
            pictureBox1.Location = new Point(this.Size.Width / 2 - pictureBox1.Width / 2 - 8 + forPayday_X, this.Size.Height / 2 - pictureBox1.Height / 2 - 19 + forPayday_Y);

            this.ShowInTaskbar = false;

            //this.BackColor = Color.White;//设置主窗体透明颜色 这里我是随便设的 大家可以找个用不到的颜色来设置透明色
            this.TransparencyKey = System.Drawing.SystemColors.Control;  //将指定颜色设置为透明色
            this.TopMost = true;

            notifyIcon1.ShowBalloonTip(3000, "外部準心", "將視窗拉大到你想要的位置", new ToolTipIcon());
            notifyIcon1.Click += new EventHandler(notifyIcon1_Click);


            /*
            ContextMenu contextMenu1 = new ContextMenu();
            contextMenu1.MenuItems.Add("&Open Application");
            contextMenu1.MenuItems.Add("S&uspend Application");
            contextMenu1.MenuItems.Add("Exit");
            contextMenu1.MenuItems.Find("Exit", false);

            notifyIcon1.ContextMenu = contextMenu1;
            */

            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            set_Crosshair();
        }

        void MdiListItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        void notifyIcon1_Click(object sender, EventArgs e)
        {
            
        }

        void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.Size.Width / 2 - pictureBox1.Width / 2 - 8 + forPayday_X + Move_X, this.Size.Height / 2 - pictureBox1.Height / 2 - 19 + forPayday_Y + Move_Y);
            Draw_Crosshair();
        }

        void set_Crosshair()
        {
            gp = new GraphicsPath();
            gp2 = new GraphicsPath();

            Point x1 = new Point(20, 0);
            Point x2 = new Point(20, 41);

            Point y1 = new Point(0, 20);
            Point y2 = new Point(41, 20);


            gp.AddLine(x1, x2);
            gp2.AddLine(y1, y2);

            Draw_Crosshair();
        }

        void Draw_Crosshair()
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.SystemColors.Control);
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(Color.Red);

            bm = new Bitmap(theCrosshairSize, theCrosshairSize);
            pictureBox1.Size = bm.Size;
            g = Graphics.FromImage(bm);
            g.DrawPath(pen2, gp);
            //g.DrawPath(pen1, gp);
            g.DrawPath(pen2, gp2);
            //g.DrawPath(pen1, gp2);

            g.FillRectangle(myBrush, new Rectangle(14, 14, 13, 13));
            //g.FillRectangle(myBrush2, new Rectangle(19, 19, 3, 3));

            pictureBox1.BackgroundImage = bm;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Move_Y--;
            Form1_SizeChanged(new object(), new EventArgs());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Move_X++;
            Form1_SizeChanged(new object(), new EventArgs());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Move_Y++;
            Form1_SizeChanged(new object(), new EventArgs());
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Move_X--;
            Form1_SizeChanged(new object(), new EventArgs());
        }

        private void 放到最大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  // 設定表單最大化
        }

        private void 縮到最小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void 一般大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;  // 設定表單預設大小
        }

        private void 設定上下ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
