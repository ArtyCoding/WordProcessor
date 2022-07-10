namespace WordProcessor
{
    internal class TextController
    {
        public static bool IsMoreThenOneWords(string text)
        {
            var words = text.
                Split(new[] { ' ', '.', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length > 1;
        }

        public static void RemovePrefix(TextBox textBox)
        {
            if (!IsMoreThenOneWords(textBox.Text))
            {
                textBox.Clear();
            }
            else
            {
                int startIndex = textBox.Text.LastIndexOf(" ");
                textBox.Text = textBox.Text.Remove(startIndex + 1);
            }
        }


        //couldn't think of anything better :(
        public static void RemoveEmptyEntriesForDot(TextBox textBox)
        {
            string text = textBox.Text;
            if ((!string.IsNullOrEmpty(text) && textBox.Text.Any()) && textBox.Text.Length > 2)
            {
                if (text[^1].ToString() == "." || text[^1].ToString() == ",")
                {
                    if (text[^2].ToString() == " ")
                    {
                        if (text[^3].ToString() != " ")
                        {
                            int index = text.LastIndexOf(" ");
                            textBox.Text = text.Remove(index, 1);
                            textBox.Select(textBox.Text.Length, 0);
                        }
                    }
                }
            }
        }

        public static string GetLastWord(string text)
        {
            var lastWord = text.Split(new char[] { ' ', '.', ',' })[^1];
            return lastWord;
        }

    }
}
