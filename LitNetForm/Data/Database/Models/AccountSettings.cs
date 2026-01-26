using LitPulse.Bots;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LitPulse.Bots.Scroll_model;

namespace LitPulse.Data.Database.Models
{
    [Table("AccountSettings")]
    public class AccountSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool ReadBook { get; set; } = true;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool AddToLibrary { get; set; } = false;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool LikeTheBook { get; set; } = true;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool SubscribeToTheAuthor { get; set; } = false;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool PostComment { get; set; } = false;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool MakeADonationToTheAuthor { get; set; } = false;

        [Required]
        [Column(TypeName = "BOOLEAN")]
        public bool BuyABook { get; set; } = false;

        [Required]
        [Column(TypeName = "INTEGER")]
        public int ConstantDelay { get; set; } = 1000;

        [Required]
        [Column(TypeName = "INTEGER")]
        public int FloatingIncrementalDelay { get; set; } = 500;

        [Required]
        public Profile ReadProfile { get; set; } = Scroll_model.Profile.DeepReader;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Навигационные свойства
        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        public ICollection<ProfileSettings> ProfileSettings { get; set; } = new List<ProfileSettings>();
    }
}
