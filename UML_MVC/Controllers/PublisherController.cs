using System.Collections.Generic;
using System.Linq;
using Model;
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

        public Publisher GetPublisherById(string id) => 
            publishers.FirstOrDefault(publisher => publisher.Id == id);

    }
}