using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace attendance.data.DbContext
{
    public class AppDbContext
    {
        #region PRIVATE FIELDS

        private IDbConnection _connection;

        #endregion

        #region CONSTRUCTOR

        public AppDbContext(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        #endregion

        #region PUBLIC METHODS

        public async Task<IEnumerable<T>> Query<T>(string query, object parameters, CommandType commandType = CommandType.StoredProcedure, int? timeout = null)
        {
            return await _connection.QueryAsync<T>(query, parameters, commandType: commandType, commandTimeout: timeout);
        }

        public async Task<int> Execute(string query, object parameters, CommandType commandType = CommandType.StoredProcedure, int? timeout = null)
        {
            return await _connection.ExecuteAsync(query, parameters, commandType: commandType, commandTimeout: timeout);
        }

        #endregion
    }
}
