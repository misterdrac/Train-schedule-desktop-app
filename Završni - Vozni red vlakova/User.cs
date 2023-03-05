using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Završni___Vozni_red_vlakova
{
    internal class User
    {
		private string userName;
        private string userPass;
		private string userStatus;
		private DateTime userLoginDT;
		private string userEmail;

        public string UserName
		{
			get { return userName; }
			set { userName = value; }
		}
		public string UserPass
		{
			get { return userPass; }
			set { userPass = value; }
		}

		
		public User(string userName, string userPass)
		{ 
			this.userName = userName;
			this.userPass = userPass;	
		}
	}
}
