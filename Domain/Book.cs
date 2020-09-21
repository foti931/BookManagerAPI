using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Description("本")]
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [MaxLength(13)]
        public string JanCode1 { get; set; }
        [MaxLength(13)]
        public string JanCode2 { get; set; }
        [MaxLength(15)]
        public string IsbnCode { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        public DateTime InsTime { get; set; }
        [Required]
        public DateTime UpdTime { get; set; }

        /// <summary>
        /// 所有情報
        /// </summary>
        public List<OwnedBookInfo> OwnedBooks { get; set; }
    }
}
