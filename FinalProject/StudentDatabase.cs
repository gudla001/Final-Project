using System;
using System.Threading.Tasks;
using SQLite;
namespace FinalProject
{
    public class StudentDataBase
    {
        readonly SQLiteAsyncConnection database;

        public StudentDataBase(string path)
        {
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<Student>().Wait();
        }
        public Task<int> InsertStudentIntoDatabase(Student student)
        {
            if (student.Id != 0)
            {
                return database.UpdateAsync(student);
            }
            return database.InsertAsync(student);
        }
        public Task<List><Student> GetAllStudents()
        {
            return database.QueryAsync<Student>("SELECT * FROM");
        }
    }
}
