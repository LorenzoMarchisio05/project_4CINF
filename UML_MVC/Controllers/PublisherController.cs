using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model.DTO;
using Model.Entity;
using Newtonsoft.Json;

namespace Controllers
{
    public sealed class PublisherController
    {
        private readonly List<Publisher> publishers;

        public PublisherController()
        {
            publishers = fetchData();
        }

        private List<Publisher> fetchData()
        {
            return JsonConvert.DeserializeObject<List<Publisher>>(File.ReadAllText("CasaEd.json"));
        }

        public Result<Publisher> GetPublisherById(string id) 
        {
            Publisher publisher = publishers.FirstOrDefault(p => p.IdCe == id);

            return publisher is null
                ? Result<Publisher>.Fail("No pubblisher found")
                : Result<Publisher>.Success(publisher);
        }

        public Result<Publisher> GetPublisherByIndex(int index)
        {
            if(index < 0 || index >= publishers.Count)
            {
                return Result<Publisher>.Fail("Index out of range");
            }

            return Result<Publisher>.Success(publishers[index]);
        }

        public IReadOnlyList<Publisher> GetAllPublisher() =>
            publishers.AsReadOnly();
    }
}