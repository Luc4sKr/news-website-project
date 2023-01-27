using NewsWebsiteProject.Domain.DTO;
using NewsWebsiteProject.Domain.IRepositories;
using NewsWebsiteProject.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsiteProject.Application.Services.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(news => new NewsDTO()
                {
                    id = news.Id,
                    title = news.Title,
                    description = news.Description,
                    contents = news.Contents,
                    published = news.Published,
                    createdOn = news.CreatedOn,
                    categoryId = news.CategoryId,
                    category = new CategoryDTO()
                    {
                        id = news.Category.Id,
                        name = news.Category.Name
                    }
                }).ToList();
        }

        public Task<NewsDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NewsDTO entityDTO)
        {
            entityDTO.createdOn = DateTime.Now;
            entityDTO.published = true;

            return _repository.Save(entityDTO.mapToEntity());
        }

        public Task<int> Update(NewsDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(NewsDTO entityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
