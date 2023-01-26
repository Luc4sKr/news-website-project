using NewsWebsiteProject.Domain.Entities;
using NewsWebsiteProject.Domain.IRepositories;
using NewsWebsiteProject.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebsiteProject.Infra.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context;

        public NewsRepository(SQLServerContext context) : base(context) 
        {
            _context = context;
        }
    }
}
