using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DataAccess
    {
        SqlConnection sqlConnection = null;

        public DataAccess(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = createCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            addParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                parameters.Add(parameter.Key, parameter.Value);
            }
        }
    }
}
