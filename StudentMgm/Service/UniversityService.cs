using StudentMgm.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMgm.Service
{
    class UniversityService
    {
        static List<UniversityModel> listUniver;


        public void add(UniversityModel university)
        {
            listUniver.Add(university);
        }
        public void delete(int id)
        {
            int index = 0;

            foreach (UniversityModel item in listUniver)
            {
                if (item.id == id)
                {
                    listUniver.RemoveAt(index);
                }
                index++;
            }
        }
        public void printList()
        {
            foreach (UniversityModel item in listUniver)
            {
                Console.WriteLine("ID:{0}  Name:{1}", item.id ,item.nameUniversity);
               
            }
        }
       
    }
}
