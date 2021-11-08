using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_with_ReactJS.Models
{
    public class EmployeeDataAccessLayer
    {
        DbTestContext db = new DbTestContext();

        public IEnumerable<TblEmployee> GetAllEmployees()
        {
            try
            {
                return db.TblEmployees.ToList();
            }
            catch
            {
                throw;
            }
        }

        // Add new employee record
        public int AddEmployee(TblEmployee employee)
        {
            try
            {
                db.TblEmployees.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public int UpdateEmployee(TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        // Get the details of a particular employee
        public TblEmployee GetEmployeeData(int id)
        {
            try
            {
                TblEmployee employee = db.TblEmployees.Find(id);
                return employee;
            }catch
            {
                throw;
            }
        }

        // To Delete the record of a paticularr employee
        public int DeleteEmployee(int id)
        {
            try
            {
                TblEmployee emp = db.TblEmployees.Find(id);
                db.TblEmployees.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public List<TblCity> GetCities()
        {
            List<TblCity> cities = new List<TblCity>();
            cities = (from CityList in db.TblCities select CityList).ToList();

            return cities;
        }
    }
}
