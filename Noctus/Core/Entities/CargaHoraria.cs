using Noctus.Core.Common;
using Noctus.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noctus.Core.Entities
{
    public class CargaHoraria : Entity
    {
        public DateTime PrimeiraEntrada { get; set; }
        public DateTime PrimeiraSaida { get; set; }
        public DateTime SegundaEntrada { get; set; }
        public DateTime SegundaSainda { get; set; }
        public DateTime HorasDiarias { get; set; }
        public DateTime Pausa { get; set; }
        public TipoCargaHoraria Tipo { get; set; }

    }
}
