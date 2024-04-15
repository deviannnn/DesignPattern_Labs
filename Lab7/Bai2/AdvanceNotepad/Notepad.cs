using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvanceNotepad
{
    public partial class Notepad : Form
    {
        string? filename = null;
        ICommand SaveCmd, CopyCmd, PasteCmd, DeleteCmd;

        public Notepad()
        {
            InitializeComponent();

            SaveCmd = new Command(saveToolStripButton, saveToolStripMenuItem);
            CopyCmd = new Command(copyToolStripButton, copyToolStripMenuItem);
            PasteCmd = new Command(pasteToolStripButton, pasteToolStripMenuItem);
            DeleteCmd = new Command(deleteToolStripButton, deleteToolStripMenuItem);
            
            DisableAllButtons();
        }

        private void DisableAllButtons()
        {
            SaveCmd.Disable();
            CopyCmd.Disable();
            PasteCmd.Disable();
            DeleteCmd.Disable();
        }

        private void contentTbox_TextChanged(object sender, EventArgs e)
        {
            if (contentTbox.Text != "")
            {
                SaveCmd.Enable();
                DeleteCmd.Enable();
            }
            else
            {
                DeleteCmd.Disable();
            }
        }

        private void contentTbox_SelectionChanged(object sender, EventArgs e)
        {
            CopyCmd.Enable();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            new Notepad().Show();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(contentTbox.SelectedText);
            CopyCmd.Disable();
            PasteCmd.Enable();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            contentTbox.Text = contentTbox.Text.Insert(contentTbox.SelectionStart, Clipboard.GetText());
            contentTbox.Focus();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            contentTbox.Text = null;
        }

        public void OpenFile()
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

        public void SaveFile()
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
    }
}