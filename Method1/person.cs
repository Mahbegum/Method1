﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    abstract class person
    {
        public string firstName { get; set; }   //  Class member
        public string lastName { get; set; }    //  Class member

        public abstract void SayName();         //  Creted a method called SayName


    }
}
