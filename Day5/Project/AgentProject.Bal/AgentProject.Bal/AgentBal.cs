using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentProject.Dao;
using AgentProject.Models;
using AgentProject.Exceptions;  

namespace AgentProject.Bal
{
    public class AgentBal
    {
        public static StringBuilder sb = new StringBuilder();
        public static AgentDaoImpl daoImpl;

        static AgentBal()
        {
            daoImpl = new AgentDaoImpl();
        }

        public List<Agent> ShowAgentBal()
        {
            return daoImpl.ShowAgentDao();
        }

        public Agent SearchAgentBal(int agentid)
        {
            return daoImpl.SearchAgentDao(agentid);
        }

        public string AddEmployBal(Agent agent)
        {
            if (ValidateAgent(agent) == true)
            {
                return daoImpl.AddAgentDao(agent);
            }
            throw new AgentException(sb.ToString());
        }

        public static bool ValidateAgent(Agent agent)
        {

            bool flag = true;
            if (agent.FirstName.Length < 3)
            {
                sb.Append("Name Contains Min. 3 characters...\n");
                flag = false;
            }
            if (agent.LastName.Length < 3)
            {
                sb.Append("Name Contains Min. 3 characters...\n");
                flag = false;
            }
            if (agent.PremiumAmount < 10000)
            {
                sb.Append("Premiumamount Must be greater than 10000...\n");
                flag = false;
            }
            return flag;
        }
    }
}
    
    
