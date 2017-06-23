using System;
using SQLite;
namespace ToDo
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}
