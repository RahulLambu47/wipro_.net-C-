using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentProject.Models
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public double PremiumAmount { get; set; }

        public Agent() { }

        public Agent(string FName, string LName, string city, string gender, double amount)
        {
              
            FirstName = FName;
            LastName = LName;
            City = city;
            Gender = gender;
            PremiumAmount = amount;




        }

        public override string ToString()
        {
            return "Agent ID: " + AgentId +
                   ", Name: " + FirstName + " " + LastName +
                   ", City: " + City +
                   ", Gender: " + Gender +
                   ", Premium Amount: " + PremiumAmount;
        }
    }
}
    
    