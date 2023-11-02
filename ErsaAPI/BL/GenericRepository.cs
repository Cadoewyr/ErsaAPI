using Dapper;
using ErsaAPI.DAL.Entities;
using ErsaAPI.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;
using static Dapper.SqlMapper;

namespace ErsaAPI.BL
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        readonly string connectionString;

        public GenericRepository()
        {
            connectionString = "Server=.;Database=Library;Trusted_Connection=True;TrustServerCertificate=True";
        }

        //Done
        public IEnumerable<T> GetAll()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<T>($"select * from {typeof(T).Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Done
        public T GetByID(int id)
        {
            IEnumerable<T> result = null;
            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {typeof(T).Name} WHERE ID = '{id}'";

                    result = connection.Query<T>(query);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result.FirstOrDefault();
        }

        //Done
        public bool Add(T entity)
        {
            bool added = false;

            try
            {
                var props = typeof(T).GetProperties().Where(p => p.Name != "ID").ToArray();
                var columnNames = string.Join(", ", props.Select(p => p.Name));
                var paramNames = string.Join(", ", props.Select(p => "@" + p.Name));

                var query = $"insert into {typeof(T).Name} ({columnNames}) values ({paramNames})";
                Console.WriteLine(query);

                using (var connection = new SqlConnection(connectionString))
                {
                    added = connection.Execute(query, entity) >= 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return added;
        }

        //Done
        public bool Update(int id, T entity)
        {
            bool updated = false;
            try
            {
                var props = typeof(T).GetProperties().Where(p => p.Name != "ID").ToArray();
                var columnNames = string.Join(", ", props.Select(p => $"{p.Name} = @{p.Name}"));

                var query = $"UPDATE {typeof(T).Name} SET {columnNames} WHERE ID = '{id}'";

                using (var connection = new SqlConnection(connectionString))
                {
                    updated = connection.Execute(query, entity) >= 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return updated;
        }

        //Done
        public bool Delete(int id)
        {
            bool deleted = false;
            try
            {
                var query = $"DELETE FROM {typeof(T).Name} WHERE ID = '{id}'";

                using (var connection = new SqlConnection(connectionString))
                {
                    deleted = connection.Execute(query) >= 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return deleted;
        }
    }
}
