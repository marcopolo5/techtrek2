using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using voluntariatApp.domain;
using Npgsql;
using System.ComponentModel.DataAnnotations;

namespace voluntariatApp.repo
{
	internal class Repository<E, ID> where E : Entity<ID>
	{
		private string tableName;
		private string connectionString;
		public Repository(string connectionString_) {
			this.connectionString = connectionString_;
			this.tableName = TypeMatching<E, ID>
								.returnTableName(typeof(E));
		}

		private NpgsqlConnection getConnection()
		{
			return new NpgsqlConnection(this.connectionString);
		}

		public E? Save (E Entity)
		{
			if ( Entity == null)
				throw new ArgumentNullException("Entity cannot be null.");
			if (this.Find(Entity.getId()) != null)
				return null;

			int rowsAffected = 0;
			using (var connection = this.getConnection())
			{
				connection.Open();
				string query = $"INSERT INTO " + this.tableName + $" VALUES " + TypeMatching<E, ID>.createListFromEntity(Entity) + ";";
				using (var command = new NpgsqlCommand(query, connection))
				{
					rowsAffected = command.ExecuteNonQuery();
				}
			}
			if (rowsAffected > 0) 
				return Entity;
			return null;
		}
		
		public E? Find(ID id)
		{
			Entity<ID>? result;
			bool found = false;
			if (id == null)
				throw new ArgumentNullException("Id cannot be null.");
			int rowsAffected = 0;
			using (var connection = this.getConnection())
			{
				connection.Open();
				string query = "";
				if (id is Tuple<string, long> tupleID)
					query = $"SELECT * FROM " + this.tableName + $" WHERE cnp = \'{tupleID.Item1}\' AND id_event = {tupleID.Item1};";
				else query = $"SELECT * FROM " + this.tableName + $" WHERE " + TypeMatching<E, ID>.returnIdCondition(typeof(E), id) + ";";
				using (var command = new NpgsqlCommand(query, connection))
				{
					using (var reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							
						}
					}
				}
			}
			return null;
		}
		/*
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
		}*/
	}
}
