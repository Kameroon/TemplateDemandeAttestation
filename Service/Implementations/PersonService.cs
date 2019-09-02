using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using Repository.Contracts;
namespace Service.Implementations
{
    public class PersonService : IPersonService
    {
        #region Declarations
        private IpersonRepository _personRepository;
        #endregion

        #region Constructors
        public PersonService()
        {

        }
        public PersonService(IpersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        #endregion

        #region Implementations
        public void DeletePerson(int personId)
        {
            _personRepository.DeletePerson(personId);
        }

        public IEnumerable<person> GetPersonList()
        {
            return _personRepository.GetPersonList();
        }

        public void InsertPerson(person person)
        {
            _personRepository.InsertPerson(person);
        }

        public void SavePerson(person person)
        {
            _personRepository.SavePerson(person);
        }

        public void UpdatePerson(person person)
        {
            _personRepository.UpdatePerson(person);
        }

        #endregion

    }
}
