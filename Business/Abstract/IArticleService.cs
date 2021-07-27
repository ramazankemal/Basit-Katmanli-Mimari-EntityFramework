using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        void Add(Article article);
        void Update(Article article);
        void Delete(Article article);
        Article GetById(int id);
        List<Article> GetAll();
    }
}
