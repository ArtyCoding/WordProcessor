namespace WordProcessor
{
    partial class WordProcessor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dictionaryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dictionaryMenu
            // 
            this.dictionaryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDictionary,
            this.updateDictionary,
            this.removeDictionary});
            this.dictionaryMenu.Name = "dictionaryMenu";
            this.dictionaryMenu.Size = new System.Drawing.Size(84, 24);
            this.dictionaryMenu.Text = "Словарь";
            // 
            // createDictionary
            // 
            this.createDictionary.Name = "createDictionary";
            this.createDictionary.Size = new System.Drawing.Size(246, 26);
            this.createDictionary.Text = "Создание словаря";
            this.createDictionary.Click += new System.EventHandler(this.createDictionary_Click);
            // 
            // updateDictionary
            // 
            this.updateDictionary.Enabled = false;
            this.updateDictionary.Name = "updateDictionary";
            this.updateDictionary.Size = new System.Drawing.Size(246, 26);
            this.updateDictionary.Text = "Обновление словаря";
            this.updateDictionary.Click += new System.EventHandler(this.updateDictionary_Click);
            // 
            // removeDictionary
            // 
            this.removeDictionary.Name = "removeDictionary";
            this.removeDictionary.Size = new System.Drawing.Size(246, 26);
            this.removeDictionary.Text = "Очистить словарь";
            this.removeDictionary.Click += new System.EventHandler(this.removeDictionary_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 31);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(502, 79);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(159, 116);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(150, 104);
            this.listBox.TabIndex = 3;
            this.listBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_KeyPress);
            // 
            // WordProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 278);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WordProcessor";
            this.Text = "WordProcessor";
            this.Load += new System.EventHandler(this.WordProcessor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dictionaryMenu;
        private ToolStripMenuItem createDictionary;
        private ToolStripMenuItem updateDictionary;
        private ToolStripMenuItem removeDictionary;
        private TextBox textBox;
        private ListBox listBox;
    }
}