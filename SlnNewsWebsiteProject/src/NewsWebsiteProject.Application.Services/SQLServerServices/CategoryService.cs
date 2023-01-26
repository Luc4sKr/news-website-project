using NewsWebsiteProject.Domain.DTO;
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
        public Task<int> Delete(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryDTO> FindAll()
        {
            throw new NotImplementedException();
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
    }
}
