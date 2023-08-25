using Noctus.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Entities
{
    public class CargoFuncionario : Entity
    {
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public Guid CargaHorariaId { get; set; }
        public CargaHoraria CargaHoraria { get; set; }

        public string Cargo { get; set; }


    }
}
