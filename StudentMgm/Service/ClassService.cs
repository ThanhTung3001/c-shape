using StudentMgm.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMgm.Service
{
    class ClassService
    {
        FacultyModel facultyModel = new FacultyModel();
        public void add(ClassModel classModel)
        {
            facultyModel.classList.Add(classModel);
        }
        public void delete(int id)
        {
            int index = 0;
            foreach (ClassModel classModel in facultyModel.classList)
            {
                if (id == classModel.id)
                {
                    facultyModel.classList.RemoveAt(index);
                    index++;
                }
            }
        }
        public void show()
        {
            foreach (ClassModel classModel in facultyModel.classList)
            {
                Console.WriteLine("ID:{0} Name: {1}", classModel.id, classModel.className);
            }
        }

    }
}
