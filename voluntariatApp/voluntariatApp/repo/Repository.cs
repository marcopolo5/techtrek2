using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voluntariatApp.domain;

namespace voluntariatApp.repo
{
	internal class Repository<E, ID> where E : Entity<ID>
	{
		public Repository() {
			if (typeof(E) == typeof(User))
			{

			}
			else if (typeof(E) == typeof(Organiser))
			{

			}
			else if (typeof(E) == typeof(LoginEntity))
			{

			}
			else if (typeof(E) == typeof(Event))
			{

			}
			else if (typeof(E) == typeof(EventSignup))
			{

			}
			else if (typeof(E) == typeof(Participation))
			{

			}
		}

		public E? Find(ID id)
		{
		
			return null;

		}
		public IEnumerable<E>? FindAll()
		{
			return null;
		}
		public void Delete(ID id)
		{

		}
		public E? Update(E entity)
		{
			return null;
		}
	}
}
