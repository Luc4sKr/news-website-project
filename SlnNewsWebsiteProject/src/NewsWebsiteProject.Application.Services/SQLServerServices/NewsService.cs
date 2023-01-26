using NewsWebsiteProject.Domain.DTO;
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
        public Task<int> Delete(NewsDTO entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<NewsDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<NewsDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NewsDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NewsDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
