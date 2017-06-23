using System;
using System.IO;
using ToDo.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Sqlite_iOS))]

namespace ToDo.iOS
{
	public class Sqlite_iOS : ISqlite
	{
		public SQLite.SQLiteConnection GetConnection() {
			var path = "/Users/panchamkhaitan/Desktop/ToDo.db";
			File.Open(path, FileMode.OpenOrCreate);
			var connection = new SQLite.SQLiteConnection(path);
			return connection;
		}
		public Sqlite_iOS()
		{
		}
	}
}
