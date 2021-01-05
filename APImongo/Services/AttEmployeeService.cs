
using MongoDB.Driver;
using APImongo.Model;
using System.Collections.Generic;
using System.Linq;




namespace APImongo.Services
{
    public class AttEmployeeService
    {
        private readonly IMongoCollection<AttEmployees> _employees;
        public AttEmployeeService(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employees = database.GetCollection<AttEmployees>(settings.EmployeesCollectionName);

        }

        public List<AttEmployees> Get()
        {
            List<AttEmployees> employees;
            employees = _employees.Find(emp => true).ToList();
            return employees;
        }

        public AttEmployees Get(string id) =>
            _employees.Find<AttEmployees>(emp => emp.EmployeeCode == id).FirstOrDefault();

    }
}