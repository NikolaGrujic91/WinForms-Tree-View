using System;
using System.Windows.Forms;

namespace WinFormsTreeView
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            var node = this.treeView.Nodes.Add("Fruits");
            node.Nodes.Add("Apple");
            node.Nodes.Add("Peach");

            node = this.treeView.Nodes.Add("Vegetables");
            node.Nodes.Add("Tomato");
            node.Nodes.Add("Eggplant");
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                MessageBox.Show(e.Node.FullPath);
            }
        }

        #endregion
    }
}
