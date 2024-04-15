using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThanhNienService;

namespace NewsWebApp.Models
{
    public class ThanhNienAdapter : INewsDAO
    {
        private ThanhNienService.ThanhNienService service = new ThanhNienService.ThanhNienService();

        public List<NewsCategory> GetAllCategories()
        {
            return service.GetCategories()
                          .Select(category => new NewsCategory { Id = category.Id, Name = category.Title })
                          .ToList();
        }

        public NewsCategory GetCategory(int categoryId)
        {
            var category = service.GetCategories().FirstOrDefault(c => c.Id == categoryId);
            return category != null ? new NewsCategory { Id = category.Id, Name = category.Title } : null;
        }

        public List<NewsLocal> GetNewsByCategory(int categoryId)
        {
            return service.GetNewsList(categoryId)
                          .Select(newsItem => new NewsLocal { Id = newsItem.Id, Title = newsItem.Title, Content = newsItem.Content })
                          .ToList();
        }

        public NewsLocal GetNews(int id)
        {
            var newsItem = service.GetNewsById(id);
            return newsItem != null ? new NewsLocal { Id = newsItem.Id, Title = newsItem.Title, Content = newsItem.Content } : null;
        }
    }
}