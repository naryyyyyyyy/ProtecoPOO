using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCaballos
{
    public class CaballoRunner : Caballo
    {
        public CaballoRunner(int id, string name) : base(id, name)
        {
            this.Icon = ProtecoPOO.Properties.Resources.runner;
        }
        public override void Avanzar(double distanciaMeta)
        {
            double progreso = PositionX / distanciaMeta;

            if (progreso < 0.65)
            {
                PositionX += 3.2 + (random.NextDouble()) * 1.2;
            }
            else
            {
                PositionX += 1.2 + (random.NextDouble() * 0.8);
            }
        }
    }
}

