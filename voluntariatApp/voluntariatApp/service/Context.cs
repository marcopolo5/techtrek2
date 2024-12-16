using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;

namespace voluntariatApp.service
{
	internal class Context
	{
		private LoginEntity? loginEntity;
		public bool setLogin(LoginEntity loginEntity_)
		{
			this.loginEntity = loginEntity_;
			//verifica parola, username
			return true;
		}

		public void clearLogin() => this.loginEntity = null;
	}
}
