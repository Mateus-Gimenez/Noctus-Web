using Noctus.Core.Common;
using Noctus.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Entities
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public Cargo Cargo { get; set; }
    }
}
