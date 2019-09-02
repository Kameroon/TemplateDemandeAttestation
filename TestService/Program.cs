using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
namespace TestService
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            ServiceLocator.Init();
            Initiator initiator = DependencyInjector.Retrieve<Initiator>();

            //Invoke the method implemented in the initiator 
            try
            {
                logger.Info("Windows Service has started" + Environment.NewLine + Environment.MachineName + DateTime.Now);
                var person = new person
                {
                    AdditionalAddress = "",
                    Adress = "aez",
                    AnnualInterviewDate = " err",
                    BirthDate = DateTime.Now,
                    CompanyMail = "fghfg",
                    CompanyPassword = "fgfgh",
                    CompanyPhone = "gfgdfg",
                    FamilySituation = "fgdfgdf",
                    FirstName = "fgdfgdf",
                    LastConnexion = DateTime.Now,
                    LastName = "dfgdf",
                    LeavingDate = DateTime.Now,
                    NbChildren = 1,
                    PersonalMail = "dfgdfg",
                    Phone = "dghfgdfg",
                    PostalCode = "cvxcvdfsd",
                    Profile = "dfgdfgdfg",
                    RTTAcquired = 0,
                    RTTRemainig = 0,
                    RTTRemainingFromLastYear = 0,
                    RTTTaken = 0,
                    RTTToAquire = 0,
                    Serial = 0,
                    Sex = "f",
                    SSNumber = "fdgfg",
                    StartingDate = DateTime.Now,
                    Town = "fgf",
                    TrialPeriodStatus = "f",
                    VacationAquired = 0,
                    VacationRemaining = 0,
                    VacationRemainingFromLastYear = 0,
                    VacationTaken = 0,
                    VacationToAquire = 0
                };
               initiator.InsertPerson(person
                  );
                initiator.SavePerson(person);
              List<person> p=   initiator.GetPersonList().ToList();      
              
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                logger.Error(e, "Windows Service does not work" + Environment.NewLine + DateTime.Now + Environment.MachineName);
            }

        }
    }
}
