using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMgm.Model
{
    class ClassModel
    {
        public int id { get; set; }
        public string className { get; set; }
        public List<studentModel> listStudent { get; set; }
    }
}
