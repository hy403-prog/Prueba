using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppApi
{
    public class Pais
    {
        public NombrePais name { get; set; }
        public List<string> capital { get; set; }
        public string region { get; set; }
        public long population { get; set; }
    }
}
