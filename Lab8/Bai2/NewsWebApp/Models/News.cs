using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsWebApp.Models
{
    public interface INewsDAO
    {
        List<NewsCategory> GetAllCategories();
        NewsCategory GetCategory(int categoryId);
        List<NewsLocal> GetNewsByCategory(int categoryId);
        NewsLocal GetNews(int id);
    }

    public class NewsDAO : INewsDAO
    {
        private string ConnectionString;
        public NewsDAO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<NewsCategory> GetAllCategories()
        {
            return new NewsCategoryDAO(ConnectionString).GetAll();
        }

        public NewsCategory GetCategory(int categoryId)
        {
            return new NewsCategoryDAO(ConnectionString).GetById(categoryId);
        }

        public List<NewsLocal> GetNewsByCategory(int categoryId)
        {
            return new NewsLocalDAO(ConnectionString).GetAll(categoryId);
        }

        public NewsLocal GetNews(int id)
        {
            return new NewsLocalDAO(ConnectionString).GetById(id);
        }
    }
}