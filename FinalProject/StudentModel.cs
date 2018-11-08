using System;
using SQLite;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
namespace FinalProject
{
    public class StudentModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Grade { get; set; }
    }
}