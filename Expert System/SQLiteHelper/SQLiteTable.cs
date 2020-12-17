using System;

namespace System.Data.SQLite
{
    public class SQLiteTable
    {
        public string TableName = string.Empty;
        public SQLiteColumnList Columns = new SQLiteColumnList();

        public SQLiteTable()
        { }

        public SQLiteTable(string name)
        {
            TableName = name;
        }
    }
}