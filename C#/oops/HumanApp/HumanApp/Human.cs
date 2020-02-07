using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Human
    {
        private string _name;
        private float _height;
        private float _weight;
        private int _age;
        private GenderType _gender;


        public Human(string Name, GenderType gender, float Height, int Weight, int Age)
        {
            _name = Name;
            _height = Height;
            _weight = Weight;
            _age = Age;
            _gender = gender;
            Console.WriteLine("Object Created");
        }

        public Human(string Name, GenderType gender) : this(Name, gender, 5.11f, 50, 30)
        {

        }

        public string Name()
        {
            return _name;
        }

        public float Heigth()
        {
            return _height;
        }

        public float Weight()
        {
            return _weight;
        }

        public int Age()
        {
            return _age;
        }

        public GenderType Gender()
        {
            return _gender;
        }

        public void weightloss()
        {
            _weight = _weight * 50 / 100;
        }
    }
}
