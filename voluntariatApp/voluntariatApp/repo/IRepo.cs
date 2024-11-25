using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voluntariatApp.repo
{
	internal interface IRepo<Entity, ID>
	{
		public Entity Save(Entity entity);
		public Entity Find(ID id);
		public IEnumerable<Entity> FindAll();
		public void Delete(ID id);
		public Entity Update(Entity entity);
	}
}
