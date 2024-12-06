using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODV2202_FinalProject_Group7
{
    public class Player
    {
        public string Name { get; set; }
        public int Lives { get; set; }
        public bool Eliminated { get; set; }
        public List<int> Cards { get; set; }    
        public int PickCard {  get; set; }
    }
}
