using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
namespace Service.Interfaces
{
    public interface IPersonService
    {
        /// <summary>
        /// returns the list of afersys's employees
        /// </summary>
        /// <returns>List</returns>
        IEnumerable<person> GetPersonList();

        /// <summary>
        /// Remove the specified person
        /// </summary>
        /// <param name="personId">personId</param>
        void DeletePerson(int personId);

        /// <summary>
        /// Add a specified employee
        /// </summary>
        /// <param name="person">person</param>
        void InsertPerson(person person);

        /// <summary>
        /// save the changes related to a person
        /// </summary>
        /// <param name="person">person</param>
        void SavePerson(person person);

        /// <summary>
        /// Update an employee's information
        /// </summary>
        /// <param name="person">person</param>
        void UpdatePerson(person person);

    }
}
