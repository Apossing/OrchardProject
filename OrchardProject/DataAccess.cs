//This code was generated by a tool.
//Changes to this file will be lost if the code is regenerated.
// See the blog post here for help on using the generated code: http://erikej.blogspot.dk/2014/10/database-first-with-sqlite-in-universal.html

using System.Data.SQLite;

namespace OrchardProject
{
    public class SQLiteDb
    {
        string _path;

        public SQLiteDb(string path)
        {
            _path = path;
        }

        public void Create()
        {
            using (SQLiteConnection db = new SQLiteConnection(_path))
            {
            }
        }
    }
}