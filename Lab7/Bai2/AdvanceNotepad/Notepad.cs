using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvanceNotepad
{
    public partial class Notepad : Form
    {
        private FontStyle selectedFontStyle;
        private string filename = "Untitled.txt";
        private string contentState;

        ICommand[] listCmd => new ICommand[]
        {
            new Command(saveBtn, saveMenuBtn), // 0
            new Command(copyBtn, copyMenuBtn), // 1
            new Command(pasteBtn, pasteMenuBtn), // 2
            new Command(deleteBtn, deleteMenuBtn) // 3
        };

        public Notepad()
        {
            InitializeComponent();

            foreach (var cmd in listCmd)
            {
                cmd.Disable();
            }
            contentState = "";
        }

        private void contentTbox_TextChanged(object sender, EventArgs e)
        {
            if (contentTbox.Text != "")
                listCmd[3].Enable();
            else
                listCmd[3].Disable();

            if (contentTbox.Text != contentState)
            {
                listCmd[0].Enable();
                this.Text = filename + " ✿";
            }
            else
            {
                listCmd[0].Disable();
                this.Text = filename;
            }
        }

        private void contentTbox_SelectionChanged(object sender, EventArgs e)
        {
            if (contentTbox.SelectedText.Length > 0)
                listCmd[1].Enable();
            else
                listCmd[1].Disable();
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
                contentState = contents;
                contentTbox.Rtf = contents;
                filename = file;
                this.Text = filename;
                if (contents != "")
                    listCmd[3].Enable();
                else
                    listCmd[3].Disable();
                listCmd[0].Disable();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string saveFileName;
            if (filename == "Untitled.txt")
            {
                saveFileDialog.FileName = "Untitled";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = saveFileDialog.FileName;
                    filename = Path.ChangeExtension(saveFileName, ".txt");
                    contentState = contentTbox.Text;
                    this.Text = filename;
                    listCmd[0].Disable();
                }
                else
                {
                    return;
                }
            }
            else
            {
                contentState = contentTbox.Text;
                this.Text = filename;
                listCmd[0].Disable();
            }

            File.WriteAllText(filename, contentTbox.Rtf);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            contentTbox.Text = null;
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (contentTbox.Text != contentState)
            {
                string message = $"Do you want to save changes to {filename}?";
                string caption = "Notepad";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFile_Click(sender, e);
                    e.Cancel = true;
                }
                else if (result == DialogResult.No)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void underLineBtn_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void highlightBtn_Click(object sender, EventArgs e)
        {
            ToggleHighlight();
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (contentTbox.SelectionFont != null)
            {
                FontStyle currentStyle = contentTbox.SelectionFont.Style;

                if (currentStyle.HasFlag(style))
                {
                    contentTbox.SelectionFont = new Font(contentTbox.SelectionFont, currentStyle & ~style);
                }
                else
                {
                    contentTbox.SelectionFont = new Font(contentTbox.SelectionFont, currentStyle | style);
                }
            }
        }

        private void ToggleHighlight()
        {
            if (contentTbox.SelectionBackColor == Color.Yellow)
            {
                contentTbox.SelectionBackColor = Color.White;
            }
            else
            {
                contentTbox.SelectionBackColor = Color.Yellow;
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            int selectionStart = contentTbox.SelectionStart;
            int selectionLength = contentTbox.SelectionLength;
            FontStyle selectionFontStyle = contentTbox.SelectionFont?.Style ?? FontStyle.Regular;

            Clipboard.SetText(contentTbox.SelectedText);

            listCmd[1].Disable();
            listCmd[2].Enable();

            contentTbox.Select(selectionStart, selectionLength);
            contentTbox.SelectionFont = new Font(contentTbox.Font, selectionFontStyle);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            int selectionStart = contentTbox.SelectionStart;

            contentTbox.Paste();

            contentTbox.Select(selectionStart, contentTbox.SelectionStart - selectionStart);
            contentTbox.SelectionFont = new Font(contentTbox.Font, contentTbox.SelectionFont.Style);
        }
    }
}