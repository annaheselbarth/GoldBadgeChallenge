using ChallengeFourOutingsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFourOutingsConsole
{
    public class ProgramUI
    {
        private OutingRepo _outingRepo = new OutingRepo();
        List<Outing> outingList = new List<Outing>();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n *************************************** Komodo Company Outings **********************************\n\n" + "\n\n   Enter in the number from the list below of which option you chooose:  \n\n" + "\n\n   1. Show All Outings \n" + "\n\n   2. Add an Outing \n" + "\n\n   3. Outing Expenses \n" + "\n\n   4. Exit");
            

            string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        OutingList();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        OutingExpense();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine(" Please enter a valid response of a number between 1-4. ");
                        Console.ReadKey();
                        break;

                }
            }
        }

        public void OutingList()
        {
            Console.Clear();
            List<Outing> outingList = _outingRepo.OutingList();

            foreach (Outing outing in outingList)
            {
                DisplayOuting(outing);
            }

            Console.ReadKey();

        }

        public void DisplayOuting(Outing companyOuting)
        {
            Console.WriteLine($" Event Type: {companyOuting.TypeOfEvent} | Number of People who Attended: {companyOuting.NumberOfPeople} | Date of Event: {companyOuting.DateOfEvent} | Total Cost Per Person: {companyOuting.CostPerPerson} | Total Cost for the Event: {companyOuting.CostOfEvent}");
        }

        public void AddOuting()
        {

        }

        public void OutingExpense()
        {

        }


    }

   


}
