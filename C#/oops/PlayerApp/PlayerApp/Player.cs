using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Player
    {
        private int id;
        private string name;
        private int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("Created");
        }

        public Player Whoiselder(Player secondPlayer)
        {
            if (secondPlayer.age > this.age)
            {
                return secondPlayer;
            }
            return this;
        }

        public Player(int id, string name) : this(id, name, 27)
        {

        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }
    }
}
