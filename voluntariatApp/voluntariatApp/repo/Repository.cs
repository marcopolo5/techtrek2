using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using voluntariatApp.domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace voluntariatApp.repo
{
	internal class Repository<E, ID> where E : Entity<ID>
	{
		ExcelPackage excelFile;
		ExcelWorksheet entityTable;
		public Repository() {
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			this.excelFile = new ExcelPackage(new FileInfo(".\\Baza de date.xlsx"));
			this.entityTable = this.excelFile
				.Workbook
				.Worksheets[TypeMatching<E, ID>
								.returnTableName(typeof(E))];
		}

		public E? Save (E Entity)
		{
			if ( Entity == null)
				throw new ArgumentNullException("Entity cannot be null.");
			if (this.Find(Entity.getId()) != null)
				return null;
			int firstEmpty = this.entityTable.Dimension.End.Row + 1;

			var data = TypeMatching<E, ID>.createListFromEntity(Entity);

			this.entityTable.Cells[firstEmpty, 1, firstEmpty, data.Count].LoadFromCollection(data);

			excelFile.Save();
			return Entity;
		}

		public E? Find(ID id)
		{
			Entity<ID>? result;
			bool found = false;
			if (id == null)
				throw new ArgumentNullException("Id cannot be null.");

			for (int rowIndex = 2; rowIndex <= this.entityTable.Dimension.End.Row; rowIndex ++)
			{
				var row = this.entityTable.Cells[rowIndex, 1, rowIndex, this.entityTable.Dimension.End.Column];

				if (id is Tuple<string, long> tupleID)
				{
					if (row.ElementAt(1).Text == tupleID.Item1 &&
						row.ElementAt(2).Text == tupleID.Item2.ToString())
					{
						found = true;
					}
				}
				else if (row.ElementAt(1).Text == id.ToString()) found = true; 

				if (found)
				{
					List<string> rowList = new List<string>();
					for (int columnIndex = 1; columnIndex <= this.entityTable.Dimension.End.Column; columnIndex++)
						rowList.Add(row[1, columnIndex].Text);
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

			for (int rowIndex = 2; rowIndex <= entityTable.Dimension.End.Row; rowIndex++)
			{
				var row = this.entityTable.Cells[rowIndex, 1, rowIndex, this.entityTable.Dimension.End.Column];

				var rowList = row.Select(cell => cell.Text).ToList();

				if (rowList.Any(cell => string.IsNullOrWhiteSpace(cell)))
					continue;

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
            if (id == null)
                throw new ArgumentNullException(nameof(id), "Id cannot be null.");

			var found = false;

			for (int rowIndex = 2; rowIndex <= entityTable.Dimension.End.Row; rowIndex++)
			{
				var row = this.entityTable.Cells[rowIndex, 1, rowIndex, this.entityTable.Dimension.End.Column];

				var rowId = row.ElementAt(1).Text;

				if (id is Tuple<string, long> tupleID)
				{
					if (row.ElementAt(1).Text == tupleID.Item1 &&
						row.ElementAt(2).Text == tupleID.Item2.ToString())
					{
						found = true;
					}
				}
				else if (row.ElementAt(1).Text == id.ToString()) found = true;


				if (found)
                {
                    for (int colIndex = 1; colIndex <= row.Count(); colIndex++)
                    {
                        row.ElementAt(colIndex).Value = null; 
                    }
                    break;  
                }
            }
			if (!found)
                throw new InvalidOperationException("Row with the given ID not found.");
			this.excelFile.Save(); 
        }

        public E? Update(E entity)
		{
			return null;
		}
	}
}
