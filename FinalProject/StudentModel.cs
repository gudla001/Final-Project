using System;
using SQLite;
namespace FinalProject
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id 
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Class
        {
            get;
            set;
        }
        public string Grade
        {
            get;
            set;
        }
    }
}
