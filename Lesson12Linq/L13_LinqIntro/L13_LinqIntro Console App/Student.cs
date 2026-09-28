using System;
using System.Collections.Generic;
using System.Text;

namespace L13_LinqIntro_Console_App
{
    public class Student
    {
        public string Name { get; set; } = "No Name"; 
        public int Mark { get; set; }

        public Student(string name, int mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
