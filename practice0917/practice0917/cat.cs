using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0917
{
    //public
    public class cat
    {
       public string Name;
       public int Age;

        //play 함수를 통해서 happiness에 접근
       private int happiness = 50;

        public cat(string name, int age)
        {
           this.Name = name;
            this.Age = age;
        }

       public void play()
        {
            happiness = happiness + 10;

            if (happiness > 100)
                happiness = 100;

        }

        public void eat()
        {
            happiness = happiness + 20;
            if (happiness > 100)
                happiness = 100;
        }

        public void borded()
        {
            happiness = happiness - 10;
            if (happiness < 0)
                happiness = 0;
        }
        
        public string express()
        {
            string message = "";

            if (happiness > 80)
                message = "very happy";
            else if (happiness > 60)
                message = "happy";
            else if (happiness >= 40)
                message = "good";
            else if (happiness >= 20)
                message = "bad";
            else
                message = "very bad";

            return this.Name + " : " + message;
        }
    }
}
