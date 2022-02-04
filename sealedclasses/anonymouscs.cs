using System;
using System.Collections.Generic;
using System.Text;

namespace sealedclasses
{
    class anonymous
    {
        static public void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.S_name);
            Console.WriteLine(val.langauge);
            Console.WriteLine(val.nested_ob.email);
        }
        public static void Main4()
        {

            var anony_Object = new
            {
                s_id = 188810298,
                S_name = "AKSHITHA PINNISHETTY",
                langauge = "English",
                nested_ob = new { email = "akshithapalli68@gmail.com" }
            };
            sampleMethod(anony_Object);
        }
    }
}

