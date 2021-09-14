using StudentMgm.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMgm.Service
{
    class StudentService
    {
        ClassModel classModel = new ClassModel();
        public void add(studentModel studentModel)
        {
            classModel.listStudent.Add(studentModel);

        }
        public void delete(int id)
        {
            int index = 0;
            foreach (studentModel studentModel in classModel.listStudent)
            {
                if (id == studentModel.id)
                {
                    classModel.listStudent.RemoveAt(index);
                  
                }
                index++;
            }
           
        }
        public void show()
        {
            foreach (studentModel studentModel in classModel.listStudent)
            {
                Console.WriteLine("ID: {0} Name: {1} Score:{2} ", studentModel.id, studentModel.studentName, studentModel.score);
            }
        }
    }
}
