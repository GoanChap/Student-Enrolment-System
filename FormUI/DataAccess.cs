using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    // Data Access is to talk to my SQL Server
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            // this is the part where we connect to SQL server
            //using is used for connections. It makes sure its destroyed after. It hence doesnt leaves connections open to our server

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //direct SQL route- unsafe
                //var output = connection.Query<Person>($"select * from Person where LastName = '{lastName}'").ToList();

                //Stored Procedure route- safe
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName}).ToList(); //dbo. is a stored procedure in his DB
                return output;
            }
        }

        public List<Person> GetPersonByFirstNameAndLastName(string firstName, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = connection.Query<Person>($"select * from Person where FirstName = '{firstName}' AND LastName = '{lastName}' ").ToList();
                //return output;

                var output = connection.Query<Person>("dbo.People_GetPersonByFirstNameAndLastName @FirstName, @LastName", new { FirstName = firstName , LastName = lastName }).ToList(); //dbo. is a stored procedure in his DB
                return output;

            }
        }

        internal void Person_Delete(string id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                connection.Execute("dbo.Person_Delete @id", new { id = Int16.Parse(id) });
            }
        }

        internal void UpdatePerson(string id, string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { id = Int16.Parse(id), FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                connection.Execute("dbo.Person_Update @id, @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }

        public void InsertPerson( string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person {  FirstName = firstName, LastName = lastName , EmailAddress = emailAddress, PhoneNumber = phoneNumber});
                connection.Execute("dbo.Person_Insert  @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
