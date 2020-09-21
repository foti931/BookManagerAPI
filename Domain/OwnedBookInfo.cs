using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    /// <summary>
    /// 所有情報
    /// </summary>
    public class OwnedBookInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public DateTime InsTime { get; set; }
        [Required]
        public DateTime UpdTime { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }
    }
}
