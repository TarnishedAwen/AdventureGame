using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplatoonFanGame
{
    public class Game
    {
        public Agent SelectedAgent { get; set; }

        public void ChooseAgent(Agent agent)
        {
            SelectedAgent = agent;
            // Implement any other logic needed when choosing an agent
        }
    }
}
