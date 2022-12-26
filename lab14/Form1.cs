using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab14
{
    public partial class Form1 : Form
    {
        Tree tr;    
        Font draw_font = new Font("Arial", 10);
        StringFormat drawFormat = new StringFormat();
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        Pen draw_pen = new Pen(Color.Black, 1);
        public float len;
        public float heigh;
        string tr_str;
        
        FileInfo file = new FileInfo(@"tree.res");
        public Form1()
        {
            InitializeComponent();
            len = pictureBox1.Size.Width;
            heigh = pictureBox1.Size.Height/(float)1.5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error_box.Visible = false;
            try {
                Graphics gr = Graphics.FromHwnd(pictureBox1.Handle);
                gr.Clear(Color.White);
                tr = new Tree();
                tr_str = String_box.Text;
                if (tr_str == "") { return; }
                string[] tr_ar = tr_str.Split(' ');
                TreeNode last;
                for (int i = 0; i < tr_ar.Length; i++)
                {
                    if (tr_ar[i] != "")
                    {
                        last = new TreeNode(Convert.ToInt32(tr_ar[i]));
                        tr.insert(last);
                    }
                }
                int depth = tr.root.depth_check();

                display(draw_pen, depth, tr.root, gr, 1, len / 2.0F);
                status_upd();
            }
            catch (FormatException) { Error_box.Visible = true; Pr_level_box.Text = ""; Status_box.Text = ""; }
        }
        
        void display(Pen dp, int depth, TreeNode cur, Graphics g, int d_lev, float x_spot)
        {
            if (cur == null) { return; }
            float centery = (heigh / depth + 3) * d_lev;
            float centerx = x_spot;

            if (cur.Left != null) {
                g.DrawLine(dp, centerx, centery + 10, (float)(x_spot - (float)(len / (Math.Pow(2, d_lev) + 1) / 2)), (float)((heigh / depth + 3) * (d_lev + 1) - 10));
            }
            if (cur.Right != null)
            {
                g.DrawLine(dp, centerx, centery + 10, (float)(x_spot + (float)(len / (Math.Pow(2, d_lev) + 1) / 2)), (float)((heigh / depth + 3) * (d_lev + 1) - 10));
            }
            g.DrawEllipse(dp, centerx - 10, centery - 10, 20, 20);
            display(dp, depth, cur.Left, g, d_lev + 1, x_spot - (float)(len / (Math.Pow(2, d_lev) + 1) / 2)); display(dp, depth, cur.Right, g, d_lev + 1, x_spot + (float)(len / (Math.Pow(2, d_lev) + 1) / 2));
            g.DrawString(Convert.ToString(cur.num), draw_font, drawBrush, centerx - 5, centery - 5, drawFormat);
        }
        
        private void button3_Click(object sender, EventArgs e) //modify button
        {
            Graphics gr = Graphics.FromHwnd(pictureBox1.Handle);
            gr.Clear(Color.White);
            tr.gl_mod();
            int depth = tr.root.depth_check();
            if (depth == 0) { return; }
            display(draw_pen, depth, tr.root, gr, 1, len / 2.0F);
            status_upd();
        }
        public void status_upd() //text results
        {
            if (tr.root == null) { Pr_level_box.Text = ""; Status_box.Text = ""; }
            if (tr.root.check_c()) { Status_box.Text = "This tree is a tree"; }
            else { Status_box.Text = "this tree is not a tree"; }
            int max_level = tr.pr_level();
            if (max_level == -1) { Pr_level_box.Text = "Something\nwent wrong"; }
            else
            {
                if (max_level == -2) { Pr_level_box.Text = "Tree has multiple\nmax levels"; }
                else { Pr_level_box.Text = "Max level is \n" + max_level; }
            }
        }

        private void button2_Click(object sender, EventArgs e) //save button
        {
            StreamWriter output = file.CreateText();
            if (tr.root.fib_checker() != 0) {
                string[] tr_ar = tr_str.Split(' ');
                string tr_new = "";
                for (int i = 0; i < tr_ar.Length; i++) {
                    if (tr_ar[i] != "")
                        tr_ar[i] = Convert.ToString(Math.Abs(Convert.ToInt32(tr_ar[i])));
                    tr_new += " " + tr_ar[i];
                }
                output.WriteLine(tr_new);
            }
            else {
                output.WriteLine(tr_str);
            }
            Pr_level_box.Text = "Successfully saved";
            output.Close();
        }
    }
}