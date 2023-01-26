using NewsWebsiteProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsiteProject.Domain.DTO
{
    public class CategoryDTO
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Set a name, please.")]
        public string name { get; set; }

        public virtual ICollection<NewsDTO> newsList { get; set; }

        public Category mapToEntity()
        {
            return new Category
            {
                Id = id,
                Name = name
            };
        }

        public CategoryDTO mapToDTO(Category category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                name = category.Name,
                newsList = category.NewsList.Select(n => new NewsDTO()
                {
                    id = n.Id,
                    title = n.Title,
                    description = n.Description,
                    contents = n.Contents,
                    createdOn = n.CreatedOn,
                    published = n.Published,
                    categoryId = n.CategoryId,
                    category = new CategoryDTO()
                    {
                        id = n.Category.Id,
                        name = n.Category.Name
                    }
                }).ToList()
            };
        }
    }
}
