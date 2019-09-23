using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0923
{
    public class cat
    {
        public int PetId;
        
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public cat(int petId, string name, string color, string gender)
        {
            Name = name;
            Color = color;
            Gender = gender;
        }

        public string MakeSound()
        {
            return "야용";
        }

        public string Scratch()
        {
            return "할퀴기";
        }
    }
}
