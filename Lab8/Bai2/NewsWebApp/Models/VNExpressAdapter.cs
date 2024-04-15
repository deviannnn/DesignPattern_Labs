using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsWebApp.Models
{
    public class VNExpressAdapter : INewsDAO
    {
        private VNExpressService.VNExpressService service = new VNExpressService.VNExpressService();

        public List<NewsCategory> GetAllCategories()
        {
            return service.RetriveCats()
                          .Select(category => new NewsCategory { Id = category.CatId, Name = category.Title })
                          .ToList();
        }

        public NewsCategory GetCategory(int categoryId)
        {
            var category = service.RetriveCats().FirstOrDefault(c => c.CatId == categoryId);
            return category != null ? new NewsCategory { Id = category.CatId, Name = category.Title } : null;
        }

        public List<NewsLocal> GetNewsByCategory(int categoryId)
        {
            return service.RetriveNews(categoryId)
                          .Select(newsItem => new NewsLocal { Id = newsItem.Id, Title = newsItem.Headline, Content = newsItem.Content })
                          .ToList();
        }

        public NewsLocal GetNews(int id)
        {
            var newsItem = service.RetriveNewsById(id);
            return newsItem != null ? new NewsLocal { Id = newsItem.Id, Title = newsItem.Headline, Content = newsItem.Content } : null;
        }
    }
}