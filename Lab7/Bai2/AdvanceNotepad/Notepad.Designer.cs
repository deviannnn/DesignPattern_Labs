namespace AdvanceNotepad
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copyBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.italicBtn = new System.Windows.Forms.ToolStripButton();
            this.underLineBtn = new System.Windows.Forms.ToolStripButton();
            this.highlightBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contentTbox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuBtn,
            this.openMenuBtn,
            this.toolStripSeparator,
            this.saveMenuBtn,
            this.toolStripSeparator1,
            this.exitMenuBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMenuBtn
            // 
            this.newMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("newMenuBtn.Image")));
            this.newMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMenuBtn.Name = "newMenuBtn";
            this.newMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuBtn.Size = new System.Drawing.Size(223, 34);
            this.newMenuBtn.Text = "&New";
            this.newMenuBtn.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // openMenuBtn
            // 
            this.openMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("openMenuBtn.Image")));
            this.openMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openMenuBtn.Name = "openMenuBtn";
            this.openMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuBtn.Size = new System.Drawing.Size(223, 34);
            this.openMenuBtn.Text = "&Open";
            this.openMenuBtn.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(220, 6);
            // 
            // saveMenuBtn
            // 
            this.saveMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuBtn.Image")));
            this.saveMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveMenuBtn.Name = "saveMenuBtn";
            this.saveMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuBtn.Size = new System.Drawing.Size(223, 34);
            this.saveMenuBtn.Text = "&Save";
            this.saveMenuBtn.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.Size = new System.Drawing.Size(223, 34);
            this.exitMenuBtn.Text = "E&xit";
            this.exitMenuBtn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuBtn,
            this.redoMenuBtn,
            this.toolStripSeparator2,
            this.copyMenuBtn,
            this.pasteMenuBtn,
            this.deleteMenuBtn,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoMenuBtn
            // 
            this.undoMenuBtn.Name = "undoMenuBtn";
            this.undoMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.undoMenuBtn.Text = "&Undo";
            // 
            // redoMenuBtn
            // 
            this.redoMenuBtn.Name = "redoMenuBtn";
            this.redoMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.redoMenuBtn.Text = "&Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // copyMenuBtn
            // 
            this.copyMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyMenuBtn.Image")));
            this.copyMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyMenuBtn.Name = "copyMenuBtn";
            this.copyMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.copyMenuBtn.Text = "&Copy";
            this.copyMenuBtn.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteMenuBtn
            // 
            this.pasteMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteMenuBtn.Image")));
            this.pasteMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteMenuBtn.Name = "pasteMenuBtn";
            this.pasteMenuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.pasteMenuBtn.Text = "&Paste";
            this.pasteMenuBtn.Click += new System.EventHandler(this.Paste_Click);
            // 
            // deleteMenuBtn
            // 
            this.deleteMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteMenuBtn.Image")));
            this.deleteMenuBtn.Name = "deleteMenuBtn";
            this.deleteMenuBtn.Size = new System.Drawing.Size(219, 34);
            this.deleteMenuBtn.Text = "&Delete";
            this.deleteMenuBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.toolStripSeparator5,
            this.copyBtn,
            this.pasteBtn,
            this.deleteBtn,
            this.toolStripSeparator6,
            this.boldBtn,
            this.italicBtn,
            this.underLineBtn,
            this.highlightBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1143, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(34, 29);
            this.newBtn.Text = "&New";
            this.newBtn.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // openBtn
            // 
            this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(34, 29);
            this.openBtn.Text = "&Open";
            this.openBtn.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(34, 29);
            this.saveBtn.Text = "&Save";
            this.saveBtn.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 34);
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyBtn.Image")));
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(34, 29);
            this.copyBtn.Text = "&Copy";
            this.copyBtn.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteBtn.Image")));
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(34, 29);
            this.pasteBtn.Text = "&Paste";
            this.pasteBtn.Click += new System.EventHandler(this.Paste_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(34, 29);
            this.deleteBtn.Text = "toolStripButton1";
            this.deleteBtn.ToolTipText = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 34);
            // 
            // boldBtn
            // 
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldBtn.Image")));
            this.boldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(34, 29);
            this.boldBtn.Text = "B";
            this.boldBtn.ToolTipText = "Bold";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicBtn.Image")));
            this.italicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(34, 29);
            this.italicBtn.Text = "I";
            this.italicBtn.ToolTipText = "Italic";
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // underLineBtn
            // 
            this.underLineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underLineBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("underLineBtn.Image")));
            this.underLineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underLineBtn.Name = "underLineBtn";
            this.underLineBtn.Size = new System.Drawing.Size(34, 29);
            this.underLineBtn.Text = "U";
            this.underLineBtn.ToolTipText = "Under Line";
            this.underLineBtn.Click += new System.EventHandler(this.underLineBtn_Click);
            // 
            // highlightBtn
            // 
            this.highlightBtn.BackColor = System.Drawing.Color.Yellow;
            this.highlightBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.highlightBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highlightBtn.Image = ((System.Drawing.Image)(resources.GetObject("highlightBtn.Image")));
            this.highlightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.highlightBtn.Name = "highlightBtn";
            this.highlightBtn.Size = new System.Drawing.Size(34, 29);
            this.highlightBtn.Text = "a";
            this.highlightBtn.ToolTipText = "High Light";
            this.highlightBtn.Click += new System.EventHandler(this.highlightBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1143, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1122, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Row: 1, Col: 1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Untitled";
            this.openFileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // contentTbox
            // 
            this.contentTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTbox.Location = new System.Drawing.Point(0, 69);
            this.contentTbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentTbox.Name = "contentTbox";
            this.contentTbox.Size = new System.Drawing.Size(1143, 649);
            this.contentTbox.TabIndex = 3;
            this.contentTbox.Text = "";
            this.contentTbox.SelectionChanged += new System.EventHandler(this.contentTbox_SelectionChanged);
            this.contentTbox.TextChanged += new System.EventHandler(this.contentTbox_TextChanged);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.contentTbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMenuBtn;
        private ToolStripMenuItem openMenuBtn;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveMenuBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenuBtn;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoMenuBtn;
        private ToolStripMenuItem redoMenuBtn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem copyMenuBtn;
        private ToolStripMenuItem pasteMenuBtn;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton newBtn;
        private ToolStripButton openBtn;
        private ToolStripButton saveBtn;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton copyBtn;
        private ToolStripButton pasteBtn;
        private ToolStripButton highlightBtn;
        private ToolStripButton deleteBtn;
        private ToolStripMenuItem deleteMenuBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private RichTextBox contentTbox;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton boldBtn;
        private ToolStripButton italicBtn;
        private ToolStripButton underLineBtn;
    }
}