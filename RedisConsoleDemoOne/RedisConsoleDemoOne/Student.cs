using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisConsoleDemoOne
{
    public class Student
    {
        public string  id { get; set; }
        public string  name { get; set; }

        Singleton s = Singleton.Instance;
    }
}
