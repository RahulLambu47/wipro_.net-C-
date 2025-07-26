using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentProject.Models;
using AgentProject.Bal;
using AgentProject.Exceptions;

namespace AgentProject.Main
{
    internal class Program
    {
        static AgentBal agentBal;

        static Program()
        {
            agentBal = new AgentBal();
        }

        public static void AddAgentMain()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter Gender (MALE/FEMALE):");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Premium Amount:");
            double premiumAmount = Convert.ToDouble(Console.ReadLine());

            Agent agent = new Agent(firstName, lastName, city, gender, premiumAmount);

            string result = agentBal.AddEmployBal(agent);
            Console.WriteLine(result);
        }

        public static void ShowAgentsMain()
        {
            List<Agent> agents = agentBal.ShowAgentBal();
            Console.WriteLine("\nAgent Records:");
            foreach (Agent agent in agents)
            {
                Console.WriteLine(agent);
            }
        }

        public static void SearchAgentMain()
        {
            Console.WriteLine("Enter Agent ID to Search:");
            int agentId = Convert.ToInt32(Console.ReadLine());

            Agent agent = agentBal.SearchAgentBal(agentId);
            if (agent != null)
            {
                Console.WriteLine("Agent Found:");
                Console.WriteLine(agent);
            }
            else
            {
                Console.WriteLine("*** Agent Not Found ***");
            }
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nAGENT MANAGEMENT");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. Add Agent");
                Console.WriteLine("2. Show All Agents");
                Console.WriteLine("3. Search Agent by ID");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddAgentMain();
                        }
                        catch (AgentException e)
                        {
                            Console.WriteLine("Validation Error: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;

                    case 2:
                        ShowAgentsMain();
                        break;

                    case 3:
                        SearchAgentMain();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 4);
        }
    }
}


