using System.Dynamic;
using api.interfaces;
using System.Collections.Generic;
using WebPractice;
using api.data;

namespace api.Data
{
    public class PersonDataHandler : IPersonDataHandler
    {
       private Database database;
        public PersonDataHandler()
        {
            db = new Database();
        }
         public List<Person> Select(){
             List<PersonDataHandler> myPeople = new List<Person>();
             string sql = "SELECT * from person";
            db.Open();
            List<ExpandoObject> results = db.Select(sql);
            foreach(dynamic item in results){
                Person temp = new Person(){ID = item.id, 
                FirstName = item.first_name, 
                LastName = item.last_name,
                Major = item.major,
                Minor = item.minor,
                PledgeClass = item.pledge_class,
                GraduatingSemester = item.graduating_semester,
                GradSchool = item.grad_school,
                GradSchoolName = item.grad_school_name,
                Employed = item.employed,
                Position = item.position,
                Company = item.company,
                City = item.city,
                Email = item.email};
            myPeople.Add(temp);
            }
            db.Close();

             return myPeople;
         }
         public void Delete(Person person);
         public void Insert(Person person){
         System.Console.WriteLine("Made it to the insert");
         }
         public void Update(Person person);
    }
}