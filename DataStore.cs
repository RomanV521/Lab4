using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class DataStore
    {
        Random random = new Random();

        //BaseInformation
        private string[] firstName = { "Richard", "Keith", "Eugene", "Donald", "Evelyn", "Tammy", "Betty", "Arlene" };
        private string[] secondName = { "Gregory", "Barber", "Rodriguez", "Phillips", "Barber", "Tate", "Johnson", "Huff" };
        private double[] age = { 1, 2, 4, 5, 9, 10, 12, 18, 19 };
        private string[] phoneNumber = { "1-485-568-5976", "1-383-891-3362", "+380994947155", "+380971582023", "+380987954825", "0677015957", "+380501219078", "0048 78 884 80 62", "+49 (0) 1962 422234", "+49(0) 186828713" };
        private string[] email = { "funommobauge-7443@yopmail.com", "gimeiteuveiffa-2619@email.jjj.ee", "myemail@vip.ep77.com", "fratrauqueuffeuha-3835@red.fr.cr", "quouyoufraunuddou-4334@ip11.tk", "zaudecutraugi-2232@zx81.ovh"};
        private string[] address = { "Weidnerplatz 4", "Königstraße 72", "avenue de Torres", "41, impasse de Berthelot", "26 Shaw Common", "Studio 90 Harrison Springs" };


        //Preschooler
        private string[] favoriteToyName = { "toy", "bear", "Teddy", "Tom" };
        private int[] toothCount = { 0, 1, 2, 5, 8, 10, 13, 28 };
        public bool[] canWalk = { true, false };

        //Schoolkid
        private string[] schoolName = { "Nikarda", "School", "National Lyceum", "Gymnasium #2"};
        private string[] favoriteLesson = { "German", "Geography", "Chemistry", "Algebra", "English"};
        private double[] averageGrade = {2, 4.5, 5, 7.3, 9, 10.2, 12};

        //Student
        private string[] universityName = { "National Pedagogical Dragomanov University", "Ukrainian Academy of Advocacy", "State University of Telecommunications", "Kyiv Banking Institute", "Odesа Polytechnic National University" };
        private string[] speciality = { "Design", "Philology", "Automation and computer-integrated technologies", "Materials Science", "System analysis" };
        private string[] studentID = { "A123B456C", "X789Y456Z", "M456N789P", "S987T654U", "Q123R456V"};

        /// <summary>
        /// Функция создает записи дошкольника со случайными значениями
        /// </summary>
        /// <returns>Новый объект типа Preschooler</returns>
        public Preschooler RecordGeneratorForPreschoolers()
        {
            return new Preschooler(firstName[random.Next(0, firstName.Length)], secondName[random.Next(0, secondName.Length)], age[random.Next(0, age.Length)], phoneNumber[random.Next(0, phoneNumber.Length)], email[random.Next(0, email.Length)], address[random.Next(0, address.Length)], favoriteToyName[random.Next(0, favoriteToyName.Length)], toothCount[random.Next(0, toothCount.Length)], canWalk[random.Next(0, canWalk.Length)]);
        }

        /// <summary>
        /// Функция создает записи школьника со случайными значениями
        /// </summary>
        /// <returns>Новый объект типа Schoolkid</returns>
        public Schoolkid RecordGeneratorForSchoolkid()
        {
            return new Schoolkid(firstName[random.Next(0, firstName.Length)], secondName[random.Next(0, secondName.Length)], age[random.Next(0, age.Length)], phoneNumber[random.Next(0, phoneNumber.Length)], email[random.Next(0, email.Length)], address[random.Next(0, address.Length)], schoolName[random.Next(0, schoolName.Length)], favoriteLesson[random.Next(0, favoriteLesson.Length)], averageGrade[random.Next(0, averageGrade.Length)]);
        }

        /// <summary>
        /// Функция создает записи студента со случайными значениями
        /// </summary>
        /// <returns>Новый объект типа Student</returns>
        public Student RecordGeneratorForStudent()
        {
            return new Student(firstName[random.Next(0, firstName.Length)], secondName[random.Next(0, secondName.Length)], age[random.Next(0, age.Length)], phoneNumber[random.Next(0, phoneNumber.Length)], email[random.Next(0, email.Length)], address[random.Next(0, address.Length)], universityName[random.Next(0, universityName.Length)], speciality[random.Next(0, speciality.Length)], studentID[random.Next(0, studentID.Length)]);
        }
    }

}
