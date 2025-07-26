using System;
using System.Collections.Generic;
using AgentProject.Models;

namespace AgentProject.Dao
{
    public class AgentDaoImpl : IAgentDao
    {
        static List<Agent> agentList;
        

        static AgentDaoImpl()
        {
            agentList = new List<Agent>();
        }

        public int GenerateAgent()
        {
            if(agentList.Count == 0)
            {
                return 1; 
            }
            else
            {
                return agentList[agentList.Count - 1].AgentId + 1; 
            }
        }
        public string AddAgentDao(Agent agent)
        {
            int id = GenerateAgent();
            agent.AgentId = id;// Auto-generate AgentId
            agentList.Add(agent);
            return "Agent Record Inserted with ID: " + agent.AgentId;
        }

        public Agent SearchAgentDao(int agentid)
        {
            foreach (Agent agent in agentList)
            {
                if (agent.AgentId == agentid)
                {
                    return agent;
                }
            }
            return null;
        }

        public List<Agent> ShowAgentDao()
        {
            return agentList;
        }
    }
}