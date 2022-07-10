namespace WordProcessor
{
    public partial class WordProcessor : Form
    {
        List<string> autocompleteList;
        public WordProcessor()
        {
            InitializeComponent();
            listBox.Hide();
        }

        private void createDictionary_Click(object sender, EventArgs e)
        {
            FileController.CreateDictionary();
            updateDictionary.Enabled = true;

        }

        private void updateDictionary_Click(object sender, EventArgs e)
        {
            FileController.UpdateDictionary();
        }

        private void removeDictionary_Click(object sender, EventArgs e)
        {
            DictionaryController.RemoveDictionary();
            updateDictionary.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextController.RemoveEmptyEntriesForDot(textBox);
        }

        private void WordProcessor_Load(object sender, EventArgs e)
        {
            autocompleteList = DictionaryController.ChangeAutoCompleteData();
            if (DictionaryController.IsDictionatyExists())
            {
                updateDictionary.Enabled = true;
            }
        }

        private void CreateCustomListBox()
        {
            var x = textBox.Left;
            var y = textBox.Top + textBox.Height;
            var width = textBox.Width + 20;
            const int height = 200;
            listBox.SetBounds(x, y, width, height);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            CreateCustomListBox();
            string lastWord = TextController.GetLastWord(textBox.Text);

            autocompleteList = DictionaryController.ChangeAutoCompleteData(lastWord);
            if (autocompleteList.Any() && !string.IsNullOrEmpty(lastWord))
            {
                listBox.DataSource = autocompleteList;
                listBox.Show();
            }
            else
            {
                listBox.Hide();
            }
        }

        private void listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                listBox_SelectedIndexChanged();
            }
        }

        private void listBox_SelectedIndexChanged()
        {
            string word = listBox.SelectedItem.ToString();
            DictionaryController.UpdateDictionaryItem(word);
            TextController.RemovePrefix(textBox);
            textBox.Text += word + " ";
            textBox.Select(textBox.Text.Length, 0);
            listBox.Hide();
        }
    }
}