using System;
using System.Collections.Generic;
using System.Xml;

namespace XMLParseHomeWork
{
    class Program
    {
        public static readonly int ROUTE_ELEMENT_POSITION = 0;

        static void Main(string[] args)
        {
            /*
            var list = new List<Item>();
            var xmlDocument = new XmlDocument();

            xmlDocument.Load("https://habrahabr.ru/rss/interesting/");
            var ItemListElement = xmlDocument.GetElementsByTagName("channel")[ROUTE_ELEMENT_POSITION];

            foreach (XmlElement itemElement in ItemListElement.ChildNodes)
            {
                var item = new Item();
                item.Title = itemElement.GetAttribute("title");
                item.Link = itemElement.GetAttribute("link");
                item.Description = itemElement.GetAttribute("description");
                item.PubDate = itemElement.GetAttribute("pubDate");
                
                list.Add(item);
            }

            Console.ReadLine();
            */

            // 2. С помощью класса XmlDocument создать класс который будет описывать студента
            // и вывести его на консоль или сохранить в текстовый файл

            var studentList = new List<Student> 
            { 
                new Student
                {
                    Id = 1,
                    Name = "Ivan",
                    Group = "201",
                    AvgMark = 4.5
                },
                new Student
                {
                    Id = 2,
                    Name = "Nikolay",
                    Group = "202",
                    AvgMark = 4.9
                },
                new Student
                {
                    Id = 57,
                    Name = "Nurbek",
                    Group = "196-1",
                    AvgMark = 4.2
                },
                new Student
                {
                    Id = 57,
                    Name = "Muhammed",
                    Group = "198-2",
                    AvgMark = 4.7
                },

            };
            var xmlDocument = new XmlDocument();

            var xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", string.Empty);
            xmlDocument.AppendChild(xmlDeclaration);

            var routeElement = xmlDocument.CreateElement("StudentList");
            xmlDocument.AppendChild(routeElement);

            foreach (var student in studentList)
            {
                var studentElement = xmlDocument.CreateElement("Student");
                studentElement.SetAttribute("Id", student.Id.ToString());
                studentElement.SetAttribute("Name", student.Name);
                studentElement.SetAttribute("Group", student.Group);
                studentElement.SetAttribute("AvgMark", student.AvgMark.ToString());


                routeElement.AppendChild(studentElement);

            }

            xmlDocument.Save("Student.txt");

        }
    }
}
