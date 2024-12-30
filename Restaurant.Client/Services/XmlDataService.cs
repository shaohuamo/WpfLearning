using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Restaurant.Client.Models;

namespace Restaurant.Client.Services
{
    public class XmlDataService : IDataService
    {
        public List<Dish> GetAllDishes()
        {
            List<Dish> dishList = new List<Dish>();
            string xmlFileName = System.IO.Path.Combine(Environment.CurrentDirectory, @"Data\Data.xml");
            XDocument xDoc = XDocument.Load(xmlFileName);
            var dishes = xDoc.Descendants("Dish");
            foreach (var d in dishes)
            {
                string score = d.Element("Score")?.Value;
                Dish dish = new Dish
                {
                    Name = d.Element("Name")?.Value,
                    Category = d.Element("Category")?.Value,
                    Comment = d.Element("Comment")?.Value,
                    Score = double.Parse(score ?? "0")
                };
                dishList.Add(dish);
            }

            return dishList;
        }
    }
}
