using ProtecoPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarreraCaballos
{
    public class Betweener : Caballo
    {
        public Betweener(int id, string name) : base(id, name)
        {
            this.Icon = ProtecoPOO.Properties.Resources.between;
        }
        public override void Avanzar(double distanciaMeta)
        {
            double progreso = PositionX / distanciaMeta;

            if (progreso < 0.55)
            {
                PositionX += 1.8 + (random.NextDouble()) * 0.8;
            }
            else
            {
                PositionX += 3.5 + (random.NextDouble() * 1.5);
            }

        }
    }
}
