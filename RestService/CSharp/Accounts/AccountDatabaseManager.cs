using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestService.CSharp.Accounts
{
	public static class AccountDatabaseManager
	{
		public static void RegisterNewAccount(string connection_string, Account account)
		{
			SqlConnection connection = new SqlConnection(connection_string);

			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand("sp_create_user_account", connection);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.AddWithValue("@Username", account.getUsername());
				command.Parameters.AddWithValue("@Password", account.getPassword());
				command.Parameters.AddWithValue("@IdentificationNumber", account.getIdNumber());
				command.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}
	}
}