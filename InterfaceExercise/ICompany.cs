using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface ICompany
    {
        //Create 2 members that are specific to each company

        public string Logo { get; set; }
        public bool EVOnly { get; set; }
    }
}
