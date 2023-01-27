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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public List<CategoryDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(category => new CategoryDTO()
                {
                    id = category.Id,
                    name = category.Name
                }).ToList();
        }

        public Task<CategoryDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
