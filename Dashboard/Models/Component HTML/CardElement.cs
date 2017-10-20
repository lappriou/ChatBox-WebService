using ChatBot.PCL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Dashboard.Models.Component_HTML
{
    public class CardElement
    {
        public string Title { get; set; }
        public List<FieldElement> NumberResult { get; set; }

        public GraphPie GraphResult { get; set; }
    }


}