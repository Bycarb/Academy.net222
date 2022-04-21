using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities
{
    public class Student : Person
    {
        public string School
            { get; set; }
        public Student(string school, string name) : base(name)
        {
            School = school;
        }
        public override string SayHello()
        {
            return "I'm a student";
        }
        public void setStudyTitle(string title)
        {
            base.StudyTitle = title;
        }
    }
}
