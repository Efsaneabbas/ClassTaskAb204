using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class ClassRoom
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public ClassRoom(string Name, int Id)
        {
            _id++;
            Id = _id;
            Name = Name;

        }

        enum ClassType
        {
            Backend,
            Frontend

        };
        public StudentAdd(Student student)
        {

        }
        public StudentFintId(int id)
        {
            foreach (var student in Students)
            {
                if ( student.Id == id)
                {
                    return student;
                }
            }

        }
        public StudentDeletId(int id)
        {

            for (int i = 0; i < Students.Length; i++)
            {
                if ( Students[i].Id == id)
                {
                    Students[i] = Id;
                    return true;
                }
            }
            return false;

        }
    }

}
