using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Nisse_oppgave.Models
{
    public class SantaHelper
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public List<string> Gift {get; set;}
        public List<UserInfo> MyProperty { get; set; }
    }
}