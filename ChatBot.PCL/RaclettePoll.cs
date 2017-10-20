using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.PCL
{
    public class RaclettePoll
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Client { get; set; }
        public bool Like { get; set; }
        public string Favorite { get; set; }
        public DateTime Date { get; set; }
    }
}
