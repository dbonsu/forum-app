using ForumApp.DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.Repository
{
    public class BaseRepository : IBaseRepository
    {
        protected ForumAppEntities _context;
    }
}