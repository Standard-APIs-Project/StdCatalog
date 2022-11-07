using Domain.Entities;
using Microsoft.Extensions.Configuration;
using StandardAPIs.DomainBase;
using StdCatalog.Domain.Entities;
using System.Text.Json;


namespace StdFilePersistence
{
    public class EntityToFile : IEntityToFile
    {

        private readonly IConfiguration _configuration;

        private string _filePath;

        public EntityToFile(IConfiguration configuration)
        {
            _configuration=configuration;

            _filePath = _configuration.GetSection("StdFilePersistence").GetSection("FilePath").Value;

        }

        public void Write<T>(T entity) where T : IEntity
        {
            string json;            
            string fullfilename;

            
            fullfilename = _filePath + typeof(T).Name + "\\" + entity.Id.ToString() + ".json";

            json = JsonSerializer.Serialize(entity);

            File.WriteAllText(fullfilename, json);

            //Todo: Proper error handling
            //Todo: Locking?
            //Todo: Make it async
            //Todo: Logging
        }

        public T Read<T>(Guid id)  where T : IEntity
        {
            string json;            
            string fullfilename;
            
            fullfilename = _filePath + typeof(T).Name + "\\" + id.ToString() + ".json";

            json = File.ReadAllText(fullfilename);

            var x = JsonSerializer.Deserialize<T>(json);

            return x;

            //Todo: Possible null reference return
            //Todo: Proper error handling
            //Todo: Make it async
            //Todo: Logging

        }

        public List<T> ReadAll<T>() where T : IEntity
        {
            string directoryToRead;
                        

            directoryToRead = _filePath + typeof(T).Name + "\\";
                        

            List<T> list = new List<T>();


            string[] fileEntries = Directory.GetFiles(directoryToRead);
            
            foreach (string fileName in fileEntries)
            {
                var guidstring = Path.GetFileNameWithoutExtension(fileName);                                

                list.Add(Read<T>(Guid.Parse(guidstring)));

            }

            return list;

        }


    }
}