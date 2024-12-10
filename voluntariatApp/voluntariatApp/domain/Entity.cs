using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.domain
{
	internal class Entity<ID>
	{
		private ID id;
		public ID getId() => this.id;
		public void setId(ID id_) => this.id = id_;
	}
}
