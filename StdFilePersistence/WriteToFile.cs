using Domain.Entities;
using StandardAPIs.DomainBase;
using StdCatalog.Domain.Entities;
using System.Text.Json;


namespace StdFilePersistence
{
    public class WriteToFile
    {

        public void Execute<T>(string repoName, T entity)
        {
            string json;

            json = JsonSerializer.Serialize(entity);

            Console.WriteLine(json);
        }
    }
}