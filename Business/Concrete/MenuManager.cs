using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;

        public MenuManager()
        {
            _menuDal = new MenuDal();
        }

        public void Add(Menu menu)
        {
            _menuDal.Add(menu);
        }

        public void Delete(Menu menu)
        {
            _menuDal.Delete(menu);
        }

        public List<Menu> GetAll()
        {
           return _menuDal.GetAll();
        }

        public Menu GetById(int id)
        {
            return _menuDal.Get(m=>m.ID==id);
        }

        public void Update(Menu menu)
        {
            _menuDal.Update(menu);
        }
    }
}
