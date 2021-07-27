using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager()
        {
            _articleDal = new ArticleDal();
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);
        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }

        public List<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public Article GetById(int id)
        {
            return _articleDal.Get(a=>a.ID==id);
        }

        public void Update(Article article)
        {
            _articleDal.Update(article);
        }
    }
}
