using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsWebsiteProject.Domain.Entities
{
    [Table("News")]
    public class News
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("contents")]
        public string Contents { get; set; }

        [Column("createdOn")]
        public DateTime? CreatedOn { get; set; }

        [Column("published")]
        public bool Published { get; set; }

        [Column("CategoryId")]
        public int CategoryId { get; set; }
    
        public virtual Category? Category { get; set; }
    }
}
