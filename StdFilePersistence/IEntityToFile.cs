using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdFilePersistence
{
    public interface IEntityToFile
    {
        
        public void Write<T>(T entity) where T : IEntity;

        public T Read<T>(Guid id) where T : IEntity;

        public List<T> ReadAll<T>() where T : IEntity;



    }
}
