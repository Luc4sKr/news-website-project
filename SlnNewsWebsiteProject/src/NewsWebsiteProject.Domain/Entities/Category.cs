using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsWebsiteProject.Domain.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<News> NewsList { get; set; }
    }
}
