using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models;

namespace Data_Access_Layer.Data.Repository.Interface
{
    public interface ITodoAppRepository
    {
      public Todo ?GetById(Guid id);
        public List<Todo> GetAll();
        public int Add(Todo todo);
        public int Update(Todo todo);
        public int Delete(Todo todo);


    }
}

