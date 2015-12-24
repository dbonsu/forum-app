using ForumApp.DataModel.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}