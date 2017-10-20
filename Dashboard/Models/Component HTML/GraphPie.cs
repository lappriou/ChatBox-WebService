using Chart.Mvc.SimpleChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dashboard.Models.Component_HTML
{
    public class GraphPie
    {
        public Chart.Mvc.SimpleChart.PieChart GraphElement { get; set; }

        public GraphPie(List<FieldElement> data)
        {
            var dataList = new List<SimpleData>();
            GraphElement = new PieChart();
            foreach(var item in data)
            {

                dataList.Add(new SimpleData() { Label = item.Key, Value = item.Value, Color = item.Color.Name });
            }
            GraphElement.ChartConfiguration.Responsive = true;
            GraphElement.Data = dataList;
        }
    }
}