﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp
{
    class Child : Parent
    {
        public Child() : base(100)
        {

        }

        public Child(int foo) : base(foo)
        {

        }
    }
}
