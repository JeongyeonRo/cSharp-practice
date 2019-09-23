using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0923
{ 
    //열거형 데이터 타입을 이용해서 강아지 죵류 설정
    public enum DogBreed {Mixed, Bulldog, Jindo, Yorkshire}

    public class dog
    {
        public string Name;
        public string Color;
        public string Gender;
        public DogBreed Breed;
        public string Description;

        public dog(string name, string color, string gender, DogBreed breed)
        {
            Name = name;
            Color = color;
            Gender = gender;
            Breed = breed; 

        }

        public string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물기";
        }
    }
}

