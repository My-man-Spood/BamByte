using Bambyte.InMemoryRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Bambyte.InMemoryRepo
{
    public class InMemoryDBRepo : IRepo
    {
        Dictionary<Type, List<object>> InMemoryArrays;

        public InMemoryDBRepo()
        {
            InMemoryArrays = new Dictionary<Type, List<object>>();
        }

        public T Create<T>(T model) where T : BaseModel
        {
            var type = model.GetType();

            if (!InMemoryArrays.ContainsKey(type))
            {
                InMemoryArrays.Add(model.GetType(), new List<object>());
            }

            var array = InMemoryArrays[type];
            array.Add(model);

            return model;
        }

        public T Get<T>(string id) where T : BaseModel
        {
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                foreach (var memory in InMemoryArrays[type])
                {
                    T model = (T)memory;
                    if (model.Id == id)
                    {
                        return model;
                    }
                }
            }

            return null;
        }

        public List<T> GetAll<T>() where T : BaseModel
        {
            var list = new List<T>();
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                foreach (var memory in InMemoryArrays[type])
                {
                    T model = (T)memory;
                    list.Add(model);                    
                }
            }

            return list;
        }

        public List<T> GetMultiple<T>(IEnumerable<string> ids) where T : BaseModel
        {
            var list = new List<T>();
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                foreach (var memory in InMemoryArrays[type])
                {                    
                    T model = (T)memory;
                    if (ids.Contains(model.Id))
                    {
                        list.Add(model);
                    }
                }
            }

            return list;
        }

        public bool Remove<T>(string id) where T : BaseModel
        {
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                foreach (var memory in InMemoryArrays[type])
                {
                    T model = (T)memory;
                    if (model.Id == id)
                    {
                        InMemoryArrays[type].Remove(model);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Remove<T>(T modelIn) where T : BaseModel
        {
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                foreach (var memory in InMemoryArrays[type])
                {
                    T model = (T)memory;
                    if (model == modelIn)
                    {
                        InMemoryArrays[type].Remove(model);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Update<T>(string id, T modelIn) where T : BaseModel
        {
            var type = typeof(T);

            if (InMemoryArrays.ContainsKey(type))
            {
                for (int i = 0; i < InMemoryArrays[type].Count; i++)
                {
                    T model = (T)InMemoryArrays[type][i];
                    if (model.Id == id)
                    {
                        InMemoryArrays[type][i] = modelIn;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
