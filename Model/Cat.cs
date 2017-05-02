using System;

namespace Model
{
    public class Cat
    {
        public Cat(int age)
        {
            _age = age;
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(_name)) _name = value;
            }
        }

        private int _age;

        private int Health { get; set; }

        public string Color
        {
            get
            {
                if (Health < 3) { return "Красный"; }
                if (Health > 5) { return "Зеленый"; }
                else return "Желтый";
            }
        }

        public void Feed()
        {
            Health++;
        }

        public void Punish()
        {
            Health--;
        }
    }
}
