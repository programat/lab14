using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Tree
    {
        public TreeNode root;

        public Tree() { }
        public Tree(int n)
        {
            this.root = new TreeNode(n, 1);
        }
        public void insert(int n)
        {
            if (root == null)
            {
                root = new TreeNode(n, 1); return;
            }
            TreeNode ta = new TreeNode(n, 1);
            root.to_add(ta);
        }
        public void insert (TreeNode t)
        {
            if (root == null)
            {
                root = t; return;
            }
            root.to_add(t);
        }
        public void gl_mod()
        {
            root.gl_mod();
        }
        public int pr_level()
        {
            int lev = -1;
            int[] pr_count = new int[root.depth_check()];
            root.pr_level_searh(ref pr_count);
            for(int i = 0; i < pr_count.Length;i++)
            {
                if ((pr_count[i] == lev ) && (lev != -1)){ lev = -2;break; }
                if ((pr_count[i] > 0) && (pr_count[i] > lev)) { lev = pr_count[i]; }
            }
            return lev;
        }
    }
}