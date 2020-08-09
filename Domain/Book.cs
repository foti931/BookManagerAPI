using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [NotNull]
        public string Title { get; set; }

        public string Gerne { get; set; }

        public string Detail { get; set; }

        public string Other { get; set; }
        [NotNull]
        public string JAN { get; set; }
        [NotNull]
        public bool IsRental { get; set; }
        [NotNull]
        public DateTime InsTime { get; set; }
        [NotNull]
        public DateTime UpdTime { get; set; }   
    }
}
