using Noctus.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Entities
{
    public class Alfabeto : Entity
    {
        public string Letra { get; set; }
        public string Codigo { get; set;}
        public int Celas { get; set;}
    }
}
