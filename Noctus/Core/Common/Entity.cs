using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Common
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime Alteracao { get; set; }
        public bool Excluido { get; set; }

    }
}
