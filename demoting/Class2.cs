using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoting
{


    class Class2
    {
        public static int nyeTal = 300;
        
        public bool MyBool { get; private set; }

        string[] arr = new string[10];

        List<string> Collection = new List<string>
        {
            "hej",
            "med",
            "dig",
        };

        double notanint = 1.0;
        float notastring = 1.0f;
        

        public string SomeMethod() => "hej";

        bool meth()
        {
            var wat = Collection[1];
            
            bool retval = false;
            foreach(var s in Collection)
            {
                if(s == "dig")
                    continue;

                if (s is int)
                    break;

                switch (s)
                {
                    case "hej":
                        {
                            retval = true;
                            break;
                        }
                    default:
                        {
                            retval = false;
                            break;
                        }
                }
            }
            return retval;
        }
    }
}
