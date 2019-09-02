using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using NLog;
using System.Data.Entity;

namespace Repository.Implmentations
{
    public class PersonRepository : IpersonRepository
    {
        private aferbaseEntities _context = new aferbaseEntities();
        private static Logger logger = LogManager.GetCurrentClassLogger();


        /// <summary>
        /// GetPersonList returns the list of Afersys'employees
        /// </summary>
        /// <returns>List</returns>
        public IEnumerable<person> GetPersonList()
        {

            try
            {

                logger.Info("PersonRepository ==> GetPersonList : Début: heure = " + 
                    Environment.NewLine + Environment.MachineName + DateTime.Now);
                var personList = _context.person.ToList();
                logger.Info("PersonRepository ==> GetPersonList : Terminé: heure = " + 
                    Environment.NewLine + Environment.MachineName + DateTime.Now);
                return personList;
            }
            catch (Exception e)
            {
                logger.Error(e, "Windows Service does not work : PersonRepository ==> GetPersonList" + 
                    Environment.NewLine + DateTime.Now + Environment.MachineName);
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// Adding a new employee
        /// </summary>
        /// <param name="person">person</param>
        public void InsertPerson(person person)
        {
            try
            {
                logger.Info("PersonRepository ==> InsertPerson : Début: heure = " + 
                    Environment.NewLine + Environment.MachineName + DateTime.Now);
                _context.person.Add(person);
                _context.SaveChanges();
                logger.Info("PersonRepository ==> InsertPerson : Terminé: heure = " + 
                    Environment.NewLine + Environment.MachineName + DateTime.Now);
            }
            catch (Exception e)
            {
                logger.Error(e, "Windows Service does not work : PersonRepository ==> InsertPerson" + 
                    Environment.NewLine + DateTime.Now + Environment.MachineName);
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// SavePerson responsible of saving any changes concerning Person
        /// </summary>
        /// <param name="personId">personId</param>
        public void DeletePerson(int personId)
        {
            try
            {
                logger.Info("PersonRepository ==> DeletePerson : Début: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
                person person = _context.person.Find(personId);
                _context.person.Remove(person);
                logger.Info("PersonRepository ==> DeletePerson : Terminé: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
            }
            catch (Exception e)
            {
                logger.Error(e, "Windows Service does not work : PersonRepository ==> DeletePerson" + Environment.NewLine + DateTime.Now + Environment.MachineName);
                throw new Exception(e.Message);
            }

        }


        /// <summary>
        /// Update the informations related to an existing employee
        /// </summary>
        /// <param name="person">person</param>
        public void UpdatePerson(person person)
        {
            try
            {
                logger.Info("PersonRepository ==> UpdatePerson : Début: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
                _context.Entry(person).State = EntityState.Modified;
                logger.Info("PersonRepository ==> UpdatePerson : Terminé: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
            }
            catch (Exception e)
            {
                logger.Error(e, "Windows Service does not work : PersonRepository ==> UpdatePerson" + Environment.NewLine + DateTime.Now + Environment.MachineName);
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// SavePerson responsible of saving any changes concerning Person
        /// </summary>
        /// <param name="person">person</param>
        public void SavePerson(person person)
        {
            try
            {
                logger.Info("PersonRepository ==> SavePerson : Début: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
                _context.SaveChanges();
                logger.Info("PersonRepository ==> SavePerson : Terminé: heure = " + Environment.NewLine + Environment.MachineName + DateTime.Now);
            }
            catch (Exception e)
            {
                logger.Error(e, "Windows Service does not work : PersonRepository ==> SavePerson" + Environment.NewLine + DateTime.Now + Environment.MachineName);
                throw new Exception(e.Message);
            }

        }


    }
}
