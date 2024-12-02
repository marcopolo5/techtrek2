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
				.GetWorkSheet(TypeMatching<E, ID>
								.returnTableName(typeof(E)));
		}

		public E? Find(ID id)
		{
			Entity<ID>? result;
			bool found = false;
			if (id == null)
				throw new ArgumentNullException("Id cannot be null.");
			foreach (var row in this.entityTable.Rows)
			{
				if (id is Tuple<string, long> tupleID)
				{
					if (row.ElementAt(0).Text == tupleID.Item1 &&
						row.ElementAt(1).Text == tupleID.Item2.ToString())
					{
						found = true;
					}
				} else if(row.ElementAt(0).Text == id.ToString()) found = true;

				if (found)
				{
					List<string> rowList = new List<string>();
					foreach (var cell in row)
						rowList.Add(cell.StringValue);
					result = TypeMatching<E, ID>.createEntityFromList(
							typeof(E),
							rowList
						);
					if ( result != null )
						result.setId(id);
					return (E?)result;
				}
			}
			return null;
		}
        public IEnumerable<E> FindAll()
        {
            var resultList = new List<E>();

            foreach (var row in this.entityTable.Rows.Skip(1))  // Skip the header row
            {
                var rowList = row.Select(cell => cell.StringValue).ToList();

                var entity = TypeMatching<E, ID>.createEntityFromList(typeof(E), rowList);

                if (entity != null)
                {
                    resultList.Add(entity);
                }
            }
            return resultList;
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
