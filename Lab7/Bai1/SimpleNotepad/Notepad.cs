using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Notepad : Form
    {
        string? filename = null;

        public Notepad()
        {
            InitializeComponent();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            new Notepad().Show();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                var contents = File.ReadAllText(file);
                contentTbox.Text = contents;
                filename = file;
                this.Text = filename;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (filename == null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var file = saveFileDialog.FileName;
                    filename = file;
                    this.Text = filename;
                }
            }
            File.WriteAllText(filename, contentTbox.Text);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(contentTbox.SelectedText);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            contentTbox.Text += Clipboard.GetText();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            contentTbox.Text = null;
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Do you want to save changes to?";
            const string caption = "Notepad";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void contentTbox_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}