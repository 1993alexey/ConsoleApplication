using System;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class JournalModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Book { get; set; }

        [Required]
        [Range(1, 100)]
        public int Chapter { get; set; }

        [Required]
        [Range(1, 100)]
        public int Verse { get; set; }
        public string Notes { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreatedAt { get; set; }
    }
}
