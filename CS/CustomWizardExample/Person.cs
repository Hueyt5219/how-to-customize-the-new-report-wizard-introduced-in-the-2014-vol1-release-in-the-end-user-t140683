using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomWizardExample {
    public class Person {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Second Name")]
        public string SecondName { get; set; }
    }
    public class PersonsSource {
        public IList<Person> GetXmlPersons() {
            var root = System.Xml.Linq.XDocument.Load("Data.xml").Root;
            List<Person> persons = new List<Person>();
            foreach(var item in root.Elements()) {
                var firstName = GetAttributeValue(item, "FirstName");
                var secondName = GetAttributeValue(item, "SecondName");

                var person = new Person() { FirstName = firstName, SecondName = secondName };
                persons.Add(person);
            }
            return persons;
        }
        static string GetAttributeValue(XElement element, string attributeName) {
            XAttribute attrbute = element.Attribute(attributeName);
            return attrbute == null ? null : attrbute.Value;
        }
        public IList<Person> GetStaticPersons() {
            return new List<Person>(new[] { 
                        new Person() { FirstName = "John", SecondName = "Abbot" }, 
                        new Person() { FirstName = "Paul", SecondName = "Bass" },
                        new Person() { FirstName = "George", SecondName = "Chance" }});
        }
    }
}
