using ProtecoPOO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCaballos
{
    public class CaballoLeader : Caballo
    {
        public CaballoLeader(int id, string name) : base(id, name)
        {
            this.Icon = ProtecoPOO.Properties.Resources.leader;
        }
        public override void Avanzar(double distanciaMeta)
        {
            double progreso = PositionX / distanciaMeta;
            PositionX += 2.1 + (random.NextDouble()) * 1.0;

        }
    }
}
