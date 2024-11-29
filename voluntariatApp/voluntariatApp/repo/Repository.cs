using IronXL;
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
		WorkBook excelFile;
		WorkSheet entityTable;
		public Repository() {
			this.excelFile = WorkBook.Load(".\\Baza de date.xlsx");
			this.entityTable = this.excelFile
				.GetWorkSheet(TypeMatching
								.returnTableName(typeof(E)));
		}

		public E? Find(ID id)
		{
			if (id is Tuple<string, long> tupleID)
			{
				foreach (var row in this.entityTable.Rows)
				{
					if (row.ElementAt(0).Text == tupleID.Item1 &&
						row.ElementAt(1).Text == tupleID.Item2.ToString())
					{

					}
				}
			} else
			{
				foreach (var row in this.entityTable.Rows)
				{
					if (row.ElementAt(0).Text == id.ToString())
					{

					}
				}
			}
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
