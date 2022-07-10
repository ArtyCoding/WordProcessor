using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WordProcessor.Models
{
    [Table("Dictionary")]
    internal class DictionaryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Word { get; set; }
        public int Count { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DictionaryModel model &&
                   Word == model.Word;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Word);
        }
    }
}
