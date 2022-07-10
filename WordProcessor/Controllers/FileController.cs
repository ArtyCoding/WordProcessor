namespace WordProcessor
{
    internal class FileController
    {
        private static string? PathFile { get; set; }
        public static void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathFile = openFileDialog.FileName;
            }

        }

        public static void CreateDictionary()
        {
            OpenFile();
            if (!string.IsNullOrEmpty(PathFile))
            {
                DictionaryController.LoadDictionary(PathFile);
            }
        }

        public static void UpdateDictionary()
        {
            OpenFile();
            if (!string.IsNullOrEmpty(PathFile))
            {
                DictionaryController.UpdateDictionary(PathFile);
            }

        }
    }
}
