using System;
using SQLite;
namespace FinalProject
{

        public class MessageModel
        {
           //[PrimaryKey, AutoIncrement]

            public string Name { get; set; }
            public string Number { get; set; }
            public string Message { get; set; }
        }
    }
