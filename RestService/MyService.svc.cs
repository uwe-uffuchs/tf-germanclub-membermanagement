using System;
using System.IO;
using System.Text;
using RestService.CSharp.Accounts;

namespace RestService
{
	public class MyService : IService
	{
		public Stream Authenticate(string username, string password)
		{
			if (username == "Evan")
				return new MemoryStream(Encoding.UTF8.GetBytes("Success"));
			else return new MemoryStream(Encoding.UTF8.GetBytes("Failed"));
		}

		public Stream Register(string username, string password, string identification)
		{
			try
			{
				Account account = new Account(username, password, identification);
				DAL.Instance().RegisterNewAccount(account);
			}
			catch (Exception ex)
			{
				return new MemoryStream(Encoding.UTF8.GetBytes("Error - " + ex.Message));
			}
			return new MemoryStream(Encoding.UTF8.GetBytes("Success"));
		}
	}
}