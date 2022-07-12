using WordProcessor.Models;

namespace WordProcessor
{
    public class DictionaryController
    {
        public static bool IsDictionatyExists()
        {
            bool isExsists = false;
            using (ApplicationContext context = new ApplicationContext())
            {
                isExsists = context.DictionaryModels.Any();
            }
            return isExsists;
        }
        public static async void LoadDictionary(string filename)
        {
            List<DictionaryModel> dictionaryModels = await PrepareData(filename);
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var word in dictionaryModels)
                {
                    db.DictionaryModels.Add(word);
                    await db.SaveChangesAsync();
                }
            }
        }

        private static async Task<List<DictionaryModel>> PrepareData(string path)
        {
            List<DictionaryModel> dictionaryModels = new List<DictionaryModel>();
            string? line;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    dictionaryModels.Add(new DictionaryModel() { Word = line, Count = 0 });
                }
            }
            return dictionaryModels;
        }

        public static async void UpdateDictionary(string path)
        {
            List<DictionaryModel> newData = await PrepareData(path);
            var strNewData = newData.Select(x => x.Word).ToList();

            using (ApplicationContext db = new ApplicationContext())
            {
                var oldData = db.DictionaryModels.Select(w => w.Word).ToList();
                var updateData = strNewData.Except(oldData);
                foreach (var word in updateData)
                {
                    db.DictionaryModels.Add(new DictionaryModel { Word = word, Count = 0 });
                    await db.SaveChangesAsync();
                }
            }
        }

        public static void RemoveDictionary()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.DictionaryModels.RemoveRange(db.DictionaryModels);
                db.SaveChangesAsync();
            }
        }

        public static List<string> ChangeAutoCompleteData(string text = "")
        {
            if (string.IsNullOrEmpty(text))
            {
                return new List<string>();
            }
            text = text.Trim();
            List<string> words = new List<string>();
            using (ApplicationContext db = new ApplicationContext())
            {
                words = db.DictionaryModels
                    .Where(w => w.Word.ToLower().StartsWith(text.ToLower()))
                    .OrderByDescending(w => w.Count)
                    .ThenBy(w => w.Word)
                    .Select(w => w.Word)
                    .Take(5)
                    .ToList();
            }
            return words;
        }

        public static void UpdateDictionaryItem(string word)
        {
            word = word.Trim();
            using (ApplicationContext db = new ApplicationContext())
            {
                var item = db.DictionaryModels
                    .Where(w => w.Word == word)
                    .FirstOrDefault();
                if (item != null)
                {
                    int updateCount = item.Count + 1;
                    item.Count = updateCount;
                }
                db.SaveChanges();
            }
        }
    }
}
