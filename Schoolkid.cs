using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Schoolkid : Person
    {
        private string _schoolName;
        private string _favoriteLesson;
        private double _averageGrade;

        private double maximalScore = 100;

        /// <summary>
        /// Конструктор с параметрами для школьника(-цы)
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="address">Адрес</param>
        /// <param name="schoolName">Название школы</param>
        /// <param name="favoriteLesson">Любимый урок</param>
        /// <param name="averageGrade">Средняя оценка</param>
        public Schoolkid(string firstName, string secondName, double age, string phoneNumber, string email, string address, string schoolName, string favoriteLesson, double averageGrade) : base(firstName, secondName, age, phoneNumber, email, address)
        {
            SchoolName = schoolName;
            FavoriteLesson = favoriteLesson;
            AverageGrade = averageGrade;
        }

        /// <summary>
        /// Название школы
        /// </summary>
        public string SchoolName
        {
            get { return _schoolName; }
            set { _schoolName = utils.CheckForNonEmptyValue(value); }
        }

        /// <summary>
        /// Любимый урок
        /// </summary>
        public string FavoriteLesson 
        { 
            get { return _favoriteLesson; } 
            set { _favoriteLesson = utils.CheckForNonEmptyValue(value); } 
        }

        /// <summary>
        /// Средняя оценка
        /// </summary>
        public double AverageGrade
        {
            get { return _averageGrade; }
            set 
            { 
                if (value > 0 && value <= maximalScore)
                {
                    _averageGrade = value;
                }
                else
                {
                    _averageGrade = utils.incorrectValue;
                }
            }
        }

        public override string ToString()
        {
            return $"Schoolkid: {base.ToString()} School name: {_schoolName}, Favorite activity: {_favoriteLesson}, Average grade:" + (_averageGrade == utils.incorrectValue ? "Error, you entered an incorrect value" : _averageGrade);
        }
    }
}
