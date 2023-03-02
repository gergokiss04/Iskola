using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola
{
    //2.Feladat:Fájl beolvasása és tárolása
    public class Students
    {
        public int schoolstartedyear { get; private set; }
        public string sign { get; private set; }
        public string studentname { get; private set; }

        public Students(string sor)
        {
            this.schoolstartedyear =Convert.ToInt32(sor.Split(';')[0]);
            this.sign = sor.Split(';')[1];
            this.studentname = sor.Split(';')[2];
        }

        //4.Feladat:Azonosító létrehozása:

        public string azonosito()
        {
            string year =Convert.ToString(schoolstartedyear.ToString().Last());
            string character = sign.ToString();
            string firstname = studentname.Substring(0, 3);
            string lastname = studentname.Split(' ')[1].Substring(0, 3);
            string value = (year+""+character+""+firstname+""+lastname).ToLower();
            return value;
        }

        
    }

}
