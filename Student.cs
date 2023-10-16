using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student : Person
    {
        private string universityName;
        private string speciality;
        private string studentID { get; set; }

        /// <summary>
        /// Конструктор с параметрами для студента(-цы)
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="address">Адрес</param>
        /// <param name="universityName">Название университета</param>
        /// <param name="speciality">Специальность</param>
        /// <param name="studentID">Студенческое Id</param>
        public Student(string firstName, string secondName, double age, string phoneNumber, string email, string address, string universityName, string speciality, string studentID):base(firstName, secondName, age, phoneNumber, email, address)
        {
            UniversityName = universityName;
            Speciality = speciality;
            StudentID = studentID;
        }

        /// <summary>
        /// Название университета
        /// </summary>
        public string UniversityName
        {
            get { return universityName; }
            set { universityName = utils.CheckForNonEmptyValue(value); }
        }

        /// <summary>
        /// Специальность
        /// </summary>
        public string Speciality
        {
            get { return speciality; }
            set { speciality = utils.CheckForNonEmptyValue(value); }
        }

        /// <summary>
        /// Студенческое Id
        /// </summary>
        public string StudentID
        {
            get { return studentID; }
            set { studentID = utils.CheckForNonEmptyValue(value); }
        }

        public override string ToString()
        {
            return $"Student: {base.ToString()} University Name: {universityName}, Speciality: {speciality}, StudentID: {studentID}";
        }
    }
}
