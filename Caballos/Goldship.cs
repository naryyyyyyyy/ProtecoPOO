using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCaballos
{
    public class Goldship : Caballo
    {
        public Goldship(int id, string name) : base(id, name)
        {
            this.Icon = ProtecoPOO.Properties.Resources.goldship;
        }

        public override void Avanzar(double distanciaMeta)
        {
            double progreso = PositionX / distanciaMeta;

            if (progreso < 0.80)
            {
                PositionX += 1.0 + (random.NextDouble()) * 0.8;
            }
            else
            {
                PositionX += 7.0 + (random.NextDouble() * 3.0);
            }

        }
    }
}
