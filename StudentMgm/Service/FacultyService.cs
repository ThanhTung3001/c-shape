using StudentMgm.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMgm.Service
{
    class FacultyService
    {
        UniversityService universityService = new UniversityService();
        UniversityModel universityModel = new UniversityModel();
        public void add(FacultyModel facurityModel)
        {
            universityModel.facultyList.Add(facurityModel);
          
        }
        public void delete(int id)
        {
            int index = 0;
            foreach(FacultyModel facultyModel in universityModel.facultyList){
                if(id == facultyModel.id)
                {
                    universityModel.facultyList.RemoveAt(index);
                }
                index++;
            }
        }
        public void show()
        {
            foreach (FacultyModel facultyModel in universityModel.facultyList)
            {
                Console.WriteLine("ID {0} Name {1}  ",facultyModel.id,facultyModel.nameFacultyModel);
            }
        }
    }
}
