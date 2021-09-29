using Bambyte.InMemoryRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bambyte.InMemoryRepo
{
    public interface IRepo
    {
        T Create<T>(T model)
           where T : BaseModel;

        T Get<T>(string id)
            where T : BaseModel;

        List<T> GetAll<T>()
            where T : BaseModel;

        List<T> GetMultiple<T>(IEnumerable<string> ids)
            where T : BaseModel;

        bool Remove<T>(string id)
            where T : BaseModel;

        bool Remove<T>(T modelIn)
            where T : BaseModel;

        bool Update<T>(string id, T modelIn)
            where T : BaseModel;
    }
}
