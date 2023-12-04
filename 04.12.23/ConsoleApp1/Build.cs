using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс описывающий строение
    /// </summary>
    class Build
    {

        /// <summary>
        /// Создание поля имени
        /// </summary>
        public string name;
        /// <summary>
        /// Создание поля площади
        /// </summary>
        public double area;
        /// <summary>
        /// Создание поля кол-ва жильцов
        /// </summary>
        public int kvo;
        /// <summary>
        /// Создания поля этажей
        /// </summary>
        public int floor;


        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Build()
        {
        }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>

        public Build(string name, double area, int kvo)

        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }


        public Build(string name, double area, int kvo, int floor):this(name, area, kvo)
        {

        
            this.floor = floor;
            
        }

        public override string ToString()
        {
            return $"Имя - {name}\nПлощадь - {area}\nКол-во жильцов - {kvo}\nПлощадь на одного жильца - {area/kvo}\nКол-во этажей - {floor}";
        }






    }
}
