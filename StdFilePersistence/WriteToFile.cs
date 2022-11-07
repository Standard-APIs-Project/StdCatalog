using Domain.Entities;
using Microsoft.Extensions.Configuration;
using StandardAPIs.DomainBase;
using StdCatalog.Domain.Entities;
using System.Text.Json;


namespace StdFilePersistence
{
    public class WriteToFile
    {

        private readonly IConfiguration _configuration;


        public WriteToFile(IConfiguration configuration)
        {
            _configuration=configuration;

        }

        public void Execute<T>(string repoName, T entity) where T : IEntity
        {
            string json;
            string filePath;
            string fullfilename;

            filePath = _configuration.GetSection("StdFilePersistence").GetSection("FilePath").Value;

            fullfilename = filePath + repoName + "\\" + entity.Id.ToString() + ".json";

            json = JsonSerializer.Serialize(entity);

            File.WriteAllText(fullfilename, json);

            //Todo: Proper error handling
            //Todo: Locking?
            //Todo: Make it async
            //Todo: Logging
        }

        public T Read<T>(string repoName,Guid id)  where T : IEntity
        {
            string json;
            string filePath;
            string fullfilename;

            filePath = _configuration.GetSection("StdFilePersistence").GetSection("FilePath").Value;

            fullfilename = filePath + repoName + "\\" + id.ToString() + ".json";

            json = File.ReadAllText(fullfilename);

            var x = JsonSerializer.Deserialize<T>(json);

            return x;

            //Todo: Possible null reference return
        }


    }
}