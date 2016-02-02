using ForumApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Services.Interfaces
{
    public interface IFakeService
    {
        string GrabAFakeModel();
    }
}