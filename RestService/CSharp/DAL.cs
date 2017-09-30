using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RestService.CSharp.Accounts;

namespace RestService
{
	public class DAL
	{
		private static DAL _instance = null;
		private static string _CONNECTION_STRING = "Data Source=RREAPERX;Initial Catalog=DragNote;Integrated Security=True";
		public static DAL Instance()
		{
			if (_instance == null)
			{
				_instance = new DAL();
			}
			return _instance;
		}
		public void RegisterNewAccount(Account account)
		{
			AccountDatabaseManager.RegisterNewAccount(_CONNECTION_STRING, account);
		}
	}
}