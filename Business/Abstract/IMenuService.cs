using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMenuService
    {
        void Add(Menu menu);
        void Update(Menu menu);
        void Delete(Menu menu);
        Menu GetById(int id);
        List<Menu> GetAll();
    }
}
