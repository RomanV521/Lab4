using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4
{
    internal class Person
    {
        public Utils utils = new Utils();
        private BaseInform baseInform;


        /// <summary>
        /// Конструктор в котором реализована проверка корректности возраста
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="secondName"></param>
        /// <param name="age"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        public Person(string firstName, string secondName, double age, string phoneNumber, string email, string address)
        {
            if (this.GetType().Name == "Preschooler")
            {
                age = age < 6 ? age : utils.incorrectValue;
            }
            else if (this.GetType().Name == "Schoolkid")
            {
                age = age > 6 && age < 19  ? age : utils.incorrectValue;
            }
            else if (this.GetType().Name == "Student")
            {
                age = age > 17 ? age : utils.incorrectValue;
            }
            baseInform = new BaseInform(firstName, secondName, age, phoneNumber, email, address);
        }

        public override string ToString()
        {
            return baseInform.ToString();
        }
    }
}
