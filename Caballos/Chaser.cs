using ProtecoPOO.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCaballos
{
    public class Chaser : Caballo
    {
        public Chaser(int id, string name) : base(id, name)
        {
            this.Icon = Resources.chaser;
        }

        public override void Avanzar(double distanciaMeta)
        {
            double progreso = PositionX / distanciaMeta;

            if (progreso < 0.70)
            {
                PositionX += 1.6 + (random.NextDouble()) * 0.5;
            }
            else
            {
                PositionX += 5.0 + (random.NextDouble() * 3.0);
            }

        }
    }
}
