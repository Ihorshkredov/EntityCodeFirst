using EntityCodeFirst.Entities;

namespace EntityCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new FactoriesContext();

            var facility1 = new Facility
            {
                Id = 2232,
                Address = "Ukraine , Kyiv , Ukrainsjka str. 23",
                Area = 5000
            };

            var employ1 = new Emploee
            {
                FirstName = "Bob",
                LastName = "Marley",
                Salary = 5000,
                Phone = 5567,
                
                
                
            
            };
            var employ2 = new Emploee
            {
                FirstName = "Steave",
                LastName = "Rojers",
                Salary = 99999,
                Phone = 5523,
                
                
            };


            var facility2 = new Facility()
            {
                Id = 2234,
                Address = "USA , Detroyt, Freedom str. 4",
                Area = 2300
            };

            var managerOccupation = new Occupation
            {
                ID = 1,
                Name = "Manager",
                Grade = 30

            };

            var engineerOccupation = new Occupation
            {
                ID = 2,
                Name = "Engineer",
                Grade= 20
            };


            context.Employees.Add(employ1);
            context.Employees.Add(employ2);

            context.SaveChanges();

          

        }
    }
}