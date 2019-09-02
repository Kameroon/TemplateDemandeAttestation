using DataAccessLayer.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public class Initiator
    {

        #region Variable declaration
        IPersonService _personService;
          #endregion

        #region Constructor
        public Initiator(IPersonService personService)
        {
            _personService = personService;
           
        }
        #endregion

        #region Implementations PersonService

        public IEnumerable<person> GetPersonList()
        {
            return _personService.GetPersonList();
        }

        public void InsertPerson(person person)
        {
            _personService.InsertPerson(person);
        }
        public void DeletePerson(int personId)
        {
            _personService.DeletePerson(personId);
        }

        public void UpdatePerson(person person)
        {
            _personService.UpdatePerson(person);
        }

        public void SavePerson(person person)
        {
            _personService.SavePerson(person);
        }
        #endregion
    }
}
