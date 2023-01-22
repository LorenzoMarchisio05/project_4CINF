using System.Collections.Generic;
using System.Linq;
using Model;
using Model.DTO;
using Model.Entity;

namespace Controllers
{
    public sealed class PublisherController
    {
        private readonly List<Publisher> publishers;

        public PublisherController()
        {
            publishers = new List<Publisher>();
        }

        public Result<Publisher> GetPublisherById(string id) 
        {
            Publisher publisher = publishers.FirstOrDefault(p => p.Id == id);

            return publisher is null
                ? Result<Publisher>.Fail("No pubblisher found")
                : Result<Publisher>.Success(publisher);
        }
           
        
    }
}