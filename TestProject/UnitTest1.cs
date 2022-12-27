namespace TestProject;
using lab14;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestTree()
    {
        //-1 -2 -3 -5 1 3 4 1 8 9 0 data in tree.res to testing
        StreamReader file = new StreamReader(@"../../../../tree.res");
        string tr_str = file.ReadToEnd();
        string[] tr_ar = tr_str.Split(' ');
        Tree tr = new Tree();
        foreach(string i in tr_ar)
        {
            if (i != "")
                    tr.insert(Convert.ToInt32(i));
        }
        tr.gl_mod();
        Assert.AreEqual(1, tr.root.num);
    }
}