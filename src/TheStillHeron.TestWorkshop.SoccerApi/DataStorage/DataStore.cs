using System.Collections.Generic;

namespace TheStillHeron.TestWorkshop.SoccerApi.DataStorage
{
    public interface IDataStore
    {
        void Put(string tableName, IStorable storableItem);

        T Get<T>(string tableName, System.Guid id) where T : IStorable;

        ICollection<T> Get<T>(string tableName) where T : IStorable;
    }

    public class DataStore : IDataStore
    {
        // This is a very rudimentary datbase - it has "tables" and you can store/retrieve things by id
        // We'll use this as a super-simple in-memory database to keep this api streamlined
        private IDictionary<string, IDictionary<System.Guid, IStorable>> _database;

        private void PutTable(string tableName)
        {
            if (!_database.ContainsKey(tableName))
            {
                _database.Add(tableName, new Dictionary<System.Guid, IStorable>());
            }
        }

        public DataStore()
        {
            _database = new Dictionary<string, IDictionary<System.Guid, IStorable>>();
        }

        public void Put(string tableName, IStorable storableItem)
        {
            PutTable(tableName);
            _database[tableName].Add(storableItem.Id, storableItem);
        }

        public T Get<T>(string tableName, System.Guid id) where T : IStorable
        {
            PutTable(tableName);
            if (!_database[tableName].ContainsKey(id))
            {
                return default(T);
            }
            return (T)_database[tableName][id];
        }

        public ICollection<T> Get<T>(string tableName) where T : IStorable
        {
            PutTable(tableName);
            return (ICollection<T>)_database[tableName].Values;
        }
    }
}