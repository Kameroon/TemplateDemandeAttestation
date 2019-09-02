using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
namespace Repository.Contracts
{
    public interface IpersonRepository
    {

        /// <summary>
        /// GetPersonList returns the list of Afersys'employees
        /// </summary>
        /// <returns>List</returns>
        IEnumerable<person> GetPersonList();

        /// <summary>
        /// Adding a new employee
        /// </summary>
        /// <param name="person">Person</param>
        void InsertPerson(person person);

        /// <summary>
        /// Deleting the employee having this identifier
        /// </summary>
        /// <param name="personId">personId</param>
        void DeletePerson(int personId);

        /// <summary>
        /// Update the informations related to an existing employee
        /// </summary>
        /// <param name="person">person</param>
        void UpdatePerson(person person);

        /// <summary>
        /// SavePerson responsible of saving any changes concerning Person
        /// </summary>
        /// <param name="person">person</param>
        void SavePerson(person person);

    }
}
