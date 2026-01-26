using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LitPulse.Bots.Scroll_model;

namespace LitPulse.Data.Database.Models
{
    [Table("ProfileSettings")]
    public class ProfileSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int AccountSettingsId { get; set; }

        [Required]
        public Profile ProfileType { get; set; }

        /// <summary>
        /// Шанс регрессии (%)
        /// </summary>
        [Required]
        [Range(0, 100)]
        [Column(TypeName = "INTEGER")]
        public uint ChanceOfRegression { get; set; }

        /// <summary>
        /// Мин/макс шаг прокрутки (px)
        /// </summary>
        [Required]
        [Range(50, 1500)]
        [Column(TypeName = "INTEGER")]
        public uint MinMaxScrollStep { get; set; }

        /// <summary>
        /// Мин/макс длительность прокрутки (мс)
        /// </summary>
        [Required]
        [Range(300, 5000)]
        [Column(TypeName = "INTEGER")]
        public uint MinMaxScrollDuration { get; set; }

        /// <summary>
        /// Мин/макс пауза после прокрутки (мс)
        /// </summary>
        [Required]
        [Range(200, 5000)]
        [Column(TypeName = "INTEGER")]
        public uint MinMaxPauseAfterScrolling { get; set; }

        // Навигационные свойства
        [ForeignKey("AccountSettingsId")]
        public AccountSettings AccountSettings { get; set; }
    }
}
