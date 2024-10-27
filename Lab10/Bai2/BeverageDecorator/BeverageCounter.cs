using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BeverageDecorator
{
    public partial class BeverageCounter : Form
    {
        Beverage selected;
        public BeverageCounter()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            var size = pnlMain.Width > pnlMain.Height ? pnlMain.Height : pnlMain.Width;
            if (selected != null)
            {
                selected.Draw(e.Graphics, new Point(pnlMain.Width / 2, 5), size - 5);
                lblSumCost.Text = $"Total: {selected.GetCost() / 1000f:#.0}k";
            }
        }

        private void BeverageSelect_Click(object sender, EventArgs e)
        {
            var type = int.Parse(((ToolStripButton)sender).Tag.ToString());
            selected = BeverageFactory.CreateBeverage(type);
            pnlMain.Invalidate();
        }

        private void CondimentSelect_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                var type = int.Parse(((ToolStripButton)sender).Tag.ToString());
                selected = BeverageFactory.CreateCondiment(type, selected);
                pnlMain.Invalidate();
            }
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            pnlMain.Invalidate();
        }
    }
}