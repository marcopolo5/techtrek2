using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using voluntariatApp.domain;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

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
            if (Entity == null)
                throw new ArgumentNullException("Entity cannot be null.");
            if (this.Find(Entity.getId()) != null)
                throw new ArgumentNullException("Entity with id " + Entity.getId().ToString() + " already exists.");

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
			if (id == null)
				throw new ArgumentNullException("Id cannot be null.");
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
							List<string> resultlist = new List<string>();
							for (int i = 0; i < reader.FieldCount; i++)
								resultlist.Add(reader[i].ToString());
							return TypeMatching<E, ID>.createEntityFromList(typeof(E), resultlist);
						}
					}
				}
			}
			return null;
		}
		public IEnumerable<E> FindAll()
		{
			List<E> resultlist = new List<E>();
			using (var connection = this.getConnection())
			{
				connection.Open();
				string query = $"SELECT * FROM {this.tableName};";
				using (var command = new NpgsqlCommand(query, connection))
				{
					var result = command.ExecuteReader();
					while (result.Read())
					{
						List<string> entityList = new List<string>();
						for (int i = 0; i < result.FieldCount; i++)
							entityList.Add(result[i].ToString()!);
						resultlist.Add(TypeMatching<E, ID>.createEntityFromList(typeof(E), entityList)!);
					}
				}
			}
			return resultlist;
		}

		public void Delete(ID id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id), "Id cannot be null.");
			if (this.Find(id) == null)
				throw new ArgumentException(id + " entity not found.");

			using (var connection = this.getConnection())
			{
				connection.Open();
				string query = "";
				if (id is Tuple<string, long> tupleID)
					query = $"DELETE FROM " + this.tableName + $" WHERE cnp = \'{tupleID.Item1}\' AND id_event = {tupleID.Item1};";
				else query = $"DELETE FROM " + this.tableName + $" WHERE " + TypeMatching<E, ID>.returnIdCondition(typeof(E), id) + ";";
				using (var command = new NpgsqlCommand(query, connection))
				{
					if (command.ExecuteNonQuery() <= 0)
						throw new Exception("The entity was found but couldn't be deleted.");
				}
			}
		}

        public E? Update(E entity)
		{
			return null;
		}

    }
}
