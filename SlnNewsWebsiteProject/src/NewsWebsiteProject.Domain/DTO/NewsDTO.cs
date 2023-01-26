using NewsWebsiteProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsiteProject.Domain.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Set a title, please.")]
        public string title { get; set; }

        [Required(ErrorMessage = "Set a description, please.")]
        [MinLength(5, ErrorMessage = "Description should bigger than 5 characters")]
        public string description { get; set; }

        [Required(ErrorMessage = "Set a content, please")]
        [MinLength(30, ErrorMessage = "Contents should bigger than 30 characters")]
        public string contents { get; set; }

        public DateTime? createdOn { get; set; }
        public bool published { get; set; }
        public int categoryId { get; set; }
        
        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                Contents = contents,
                CreatedOn = createdOn,
                Published = published,
                CategoryId = categoryId
            };
        }

        public NewsDTO mapToDTP(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                contents = news.Contents,
                createdOn = news.CreatedOn,
                published = news.Published,
                categoryId = news.CategoryId,
                category = new CategoryDTO()
                {
                    id = news.Category.Id,
                    name = news.Category.Name
                }
            };
        }
    }
}
