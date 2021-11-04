using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFourOutingsLibrary
{
   
    
     public enum EventType { Golf = 1, Bowling, AmusementPark, Concert };
    

    public class Outing
    {
        public EventType typeOfEvent { get; set; }
        public int numberOfPeople { get; set; }
        public DateTime dateOfEvent { get; set; }
        public decimal costPerPerson { get; set; }
        public decimal costOfEvent { get; set; }

        public Outing()
        {

        }


        public Outing(EventType typeOfEvent, int numberOfPeople, DateTime dateOfEvent, decimal costPerPerson, decimal costOfEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            CostOfEvent = costOfEvent;

        }




    }

   

}


