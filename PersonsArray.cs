using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class PersonsArray
    {
        public Person[] _persons;

        /// <summary>
        /// Конструктор класса PersonsArray, который инициализирует массив Persons
        /// </summary>
        /// <param name="persons">Массив из элементов типа Person</param>
        public PersonsArray(params Person[] persons)
        {
            Persons = persons;
        }

        public Person[] Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        /// <summary>
        /// Добавление элемента Person в массив
        /// </summary>
        /// <param name="person">Новый объект класса Person</param>
        public void AddPerson(Person person) 
        {
            Array.Resize(ref _persons, _persons.Length + 1);
            _persons[_persons.Length - 1] = person;
        }

        /// <summary>
        /// Удаление элемента Person из массив при помощи объекта
        /// </summary>
        /// <param name="person">Удаляемый объект класса Person</param>
        public void RemovePerson(Person person) 
        {
            for(int i = 0; i < _persons.Length; i++) 
            {
                if (_persons[i] == person)
                {
                    for (int j = i; j < _persons.Length - 1; j++)
                    {
                        _persons[j] = _persons[j + 1];
                    }
                    Array.Resize(ref _persons, _persons.Length - 1);
                    break;
                }
            }
        }

        /// <summary>
        /// Удаление элемента Person из массив при помощи его Id
        /// </summary>
        /// <param name="id">Id удаляемого объекта Person</param>
        public void RemovePerson(int id)
        {
            if(id >=0 &&  id < _persons.Length) 
            {
                for(int i = id; i < _persons.Length-1; i++)
                {
                    _persons[i] = _persons[i+1]; 
                }
                Array.Resize(ref _persons, _persons.Length - 1);
            }
            else
            {
                Console.WriteLine("Error, there is no value under that id");
            }
        }

        /// <summary>
        /// Редактирование объекта класса Person по его Id
        /// </summary>
        /// <param name="id">Id редактируемого объекта</param>
        /// <param name="person">Новые данные для Person</param>
        public void EditPerson(int id, Person person)
        {
            if (id >= 0 && id < _persons.Length)
            {
                _persons[id] = person;
            }
            else
            {
                Console.WriteLine("Error, there is no value under that id");
            }
        }

        /// <summary>
        /// Редактирование объекта класса Person по его текущим данным
        /// </summary>
        /// <param name="editablePerson">Текущие данные Person</param>
        /// <param name="person">Новые данные для Person</param>
        public void EditPerson(Person editablePerson, Person person)
        {
            for (int i = 0; i < _persons.Length; i++)
            {
                if (_persons[i] == editablePerson)
                {
                    _persons[i] = person;
                    break;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Person person in _persons)
            {
                sb.AppendLine(person.ToString());
            }
            return sb.ToString();
        }
    }
}
