using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.CSharp.Accounts
{
	public class Account
	{
		private string _username;
		private string _password;
		private string _identificationNumber;

		public Account(string username, string password, string identificationNumber)
		{
			_username = username;
			_password = password;
			_identificationNumber = identificationNumber;
		}

		public void setUsername(string username)
		{
			_username = username;
		}
		public string getUsername()
		{
			return _username;
		}
		public void setPassword(string password)
		{
			_password = password;
		}
		public string getPassword()
		{
			return _password;
		}
		public void setIdNumber(string idNo)
		{
			_identificationNumber = idNo;
		}
		public string getIdNumber()
		{
			return _identificationNumber;
		}
	}
}