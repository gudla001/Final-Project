using System;
using SQLite;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
namespace FinalProject
{
    public class MessageModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Body { get; set; }
    }
}