using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSISSystem.DAL
{
    internal class FSISContext : DBContext
    {
        public FSISContext() : base("FSIS")
        {

        }
        public FSISSet<Guardian> Regions { get; set; }
        public FSISSet<Player> Player { get; set; }
        public FSISSet<Team> Team { get; set; }
    }
}