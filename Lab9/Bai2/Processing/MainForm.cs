using System.Windows.Forms;

namespace Processing
{
    public partial class MainForm : Form, IObserver
    {
        MySubject mySubject;

        public MainForm()
        {
            InitializeComponent(); // already set visible = false
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                var n = int.Parse(tbxInput.Text);
                lblProcess.Visible = progressBar1.Visible = true;
                lblProcess.Text = "Processing ...";
                mySubject = new WorkingSubject(n);
                mySubject.RegisterObserver(this);
                progressBar1.Value = 0;
                progressBar1.Maximum = n;
                tbxInput.Enabled = btnStart.Enabled = false;
                ((WorkingSubject)mySubject).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                tbxInput.Text = null;
            }

        }

        private void MyUpdate(int val)
        {
            progressBar1.Value = val;
            lblProcess.Text = $"Processing: {val}/{progressBar1.Maximum}";
            if (val == progressBar1.Maximum)
            {
                lblProcess.Visible = progressBar1.Visible = false;
                tbxInput.Enabled = btnStart.Enabled = true;
            }
        }

        public void Update(int val)
        {
            Invoke(new Action<int>(MyUpdate), new object[] { val });
        }
    }
}