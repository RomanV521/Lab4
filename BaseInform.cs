using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BaseInform
    {
        private string _firstName;
        private string _secondName;
        private double _age;
        private string _phoneNumber;
        private string _email;
        private string _address;

        private double maximumAge = 290;
        
        public Utils utils = new Utils();

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            } 
            set
            {
                _firstName = utils.CheckForNonEmptyValue(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName
        {
            get
            {
                return _secondName;
            }
            set 
            { 
                _secondName = utils.CheckForNonEmptyValue(value);
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public double Age
        {
            get
            {
                return _age;
            }
            set 
            { 
                if(value>0 && value <= maximumAge)
                {
                    _age = value;
                }
                else
                {
                    _age = utils.incorrectValue;
                }
            }
        }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if(value.Length > 9 && value.Length < 21) 
                {
                    _phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                string[] tempEmail = value.Split('@', '.');
                if(tempEmail.Length > 2)
                {
                    _email = value;
                }
                else
                {
                    _email = "(Error, _email is incorrect)";
                }
            }
        }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = utils.CheckForNonEmptyValue(value);
            }
        }

        /// <summary>
        /// Конструктор с базовыми параметрами для каждого человека
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="address">Адрес</param>
        public BaseInform(string firstName, string secondName, double age, string phoneNumber, string email, string address)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"First name: {_firstName}, Second name: {_secondName}, Age: {(_age == utils.incorrectValue ? "(Error, age is incorrect)" : _age)}, Phone number: {_phoneNumber}, Email: {_email}, Address: {_address} ";
        }
    }
}
