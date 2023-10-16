using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Preschooler : Person
    {
        private string _favoriteToyName;
        private int _toothCount;
        public bool _canWalk { get; set; }

        /// <summary>
        /// Имя любимой игрушки
        /// </summary>
        public string FavoriteToyName
        {
            get 
            { 
                return _favoriteToyName;
            }
            set
            {
                _favoriteToyName =  utils.CheckForNonEmptyValue(value);
            }
        }

        /// <summary>
        /// Количество зубов
        /// </summary>
        public int ToothCount
        {
            get
            {
                return _toothCount;
            }
            set
            {
                if (value > 0 &&  value < 33)
                {
                    _toothCount = value;
                }
                else
                {
                    _toothCount = utils.incorrectValue;
                }
            }
        }

        /// <summary>
        /// Конструктор с параметрами для дошкольника(-цы)
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Электронная почта</param>
        /// <param name="address">Адрес</param>
        /// <param name="favoriteToyName">Имя любимой игрушки</param>
        /// <param name="toothCount">Количество зубов</param>
        /// <param name="canWalk">Умеет ли ходить</param>
        public Preschooler(string firstName, string secondName, double age, string phoneNumber, string email, string address, string? favoriteToyName, int toothCount, bool canWalk) : base(firstName, secondName, age, phoneNumber, email, address)
        {
            FavoriteToyName = favoriteToyName;
            ToothCount = toothCount;
            _canWalk = canWalk;
        }

        public override string ToString()
        {
            return $"Preschooler: {base.ToString()} Favorite toy: {_favoriteToyName}, Tooth count: {(_toothCount == utils.incorrectValue ? "Error, you entered an incorrect value" : _toothCount)}, Can walk: " + (_canWalk == false ? "No" : "Yes");
        }
    }
}
