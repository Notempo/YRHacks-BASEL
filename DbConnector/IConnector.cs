using System.Data;
using System.Data.Common;
using System.Diagnostics.Contracts;

namespace DbConnector;

public interface IConnector
{
    Task<List<T>> QueryAsync<T, TU>(string sql, TU parameters, string connectionString);
    Task ExecuteAsync<T>(string sql, T parameters, string connectionString);
    [Pure]
    public DbDataReader GetBlob(string sql, string connectionString);
}