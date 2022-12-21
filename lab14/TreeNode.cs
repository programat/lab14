using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class TreeNode
    {
        public TreeNode Left, Right;
        public int num;
        public int level;
        
        public TreeNode(int n)
        {
            level = 1;
            this.num = n;
            this.Left = null;
            this.Right = null;
        }
        public TreeNode(int n, int lev)
        {
            level = lev;
            this.num = n;
            this.Left = null;
            this.Right = null;
        }
        public static bool operator <(TreeNode first, TreeNode second)
        {
            if (first.num < second.num) { return true; }
            else { return false; }
        }
        public static bool operator >(TreeNode first, TreeNode second)
        {
            if (first.num > second.num) { return true; }
            else { return false; }
        }

        public void to_add(TreeNode td)
        {
            td.level += 1;
            if (td < this)
            {
                if (this.Left == null) { this.Left = td; }
                else { this.Left.to_add(td); }
            }
            if (td > this)
            {
                if (this.Right == null) { this.Right = td; }
                else { this.Right.to_add(td); }
            }
        }

        public void gl_mod()
        {
            if (this == null) { return;}
            if ((Right != null) && (Left != null))
            {
                if (Right.num * Left.num < 0) { this.num = 0; }
                Right.gl_mod();
                Left.gl_mod();
            }
        }
        public int depth_check()
        {
            if ((Left == null) && (Right == null)) { return level; }
            if (Right == null) { return Left.depth_check(); }
            if (Left == null) { return Right.depth_check(); }
            return Math.Max(Right.depth_check(), Left.depth_check());
        }
        public int prime_lev_c(int lev)
        {
            if (level != lev) { return Left.prime_lev_c(lev) + Right.prime_lev_c(lev); }
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) { return 0; }
            }
            return 1;
        }
        public string print_l(int l)
        {
            if (this.level == l)
            {
                return Convert.ToString(this.num) + " ";
            }
            return (this.Left.print_l(l) + this.Right.print_l(l));
        }
        public bool check_c()
        {
            if (this==null) { return true; }
            if (this.Left != null)
            {
                if (this < this.Left) { return false; }
                if (this.Left.check_c() == false) { return false; }
            }
            if (Right != null)
            {
                if (this>this.Right) { return false; }
                if (this.Right.check_c() == false) { return false; }
            }
            return true;
        }
        public void pr_level_searh(ref int[] pr_ar)
        {
            bool flag = true;
            for(int i = 2; i <= this.num / 2; i++) { if (this.num % i == 0) { flag = false;break; } }
            if (flag==true) { pr_ar[this.level-1] += 1; }
            if (this.Right != null) { this.Right.pr_level_searh(ref pr_ar); }
            if (this.Left != null) { this.Left.pr_level_searh(ref pr_ar); }
        }
    }
}