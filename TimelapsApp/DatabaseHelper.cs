using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Database.Sqlite;
using Android.Database;

namespace TimelapsApp
{
    class DatabaseHelper : SQLiteOpenHelper
    {
        public static string DATABASE_NAME = "userdb.db";
        public static string TABLE_NAME = "users";
        //public static string COL_1 = "ID";
        //public static string COL_2 = "ProjectName";
        //public static string COL_3 = "AlarmTime";
        //public static string COL_4 = "PictureAmount";

        public DatabaseHelper(Context context) : base(context, DATABASE_NAME, null,1)
        {
            SQLiteDatabase db = this.WritableDatabase;          
        }

        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL("create table " + TABLE_NAME + " (ID INTEGER PRIMARY KEY AUTOINCREMENT, ProjectName varchar(20), PictureAmount INTEGER)");
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            db.ExecSQL("DROP TABLE IF EXISTS" + DATABASE_NAME);
            OnCreate(db);
        }
    }
}