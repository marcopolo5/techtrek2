using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;

namespace voluntariatApp.repo
{
	internal interface IRepo<E, ID> where E : Entity<ID>
	{
		public E Save(E entity);
		public E Find(ID id);
		public IEnumerable<E> FindAll();
		public void Delete(ID id);
		public E Update(E entity);
	}
}
