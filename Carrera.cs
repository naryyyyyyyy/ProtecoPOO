using CarreraCaballos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtecoPOO;

public class Carrera : CarreraDeCaballos
{
    private List<Caballo> rooster;
    public List<Caballo> Competidores { get; set; }
    public List<Caballo> Podio { get; set; } = new List<Caballo>();
    public double DistanciaMeta { get; set; }
    public Carrera(string nombre, int juegoId, double distanciaMeta) : base(nombre, juegoId)
    {
        this.DistanciaMeta = distanciaMeta;
        this.Competidores = new List<Caballo>();

        LlenarRooster();
    }

    public void LlenarRooster()
    {
        rooster = new List<Caballo> {
        new CaballoChaser(1,"Great Grey Silf"),
        new CaballoChaser(2, "Furtive Pygmy"),
        new Goldship(3, "Gold Ship"),
        new CaballoBetweener(4, "Abyss Walker"),
        new CaballoBetweener(5, "Chaos Quelaag"),
        new CaballoBetweener(6, "Bed of Chaos"),
        new CaballoLeader(7, "Execution Smough"),
        new CaballoLeader(8, "Gravelord Nito"),
        new CaballoLeader(9, "Iron Golem"),
        new CaballoRunner(10, "Lord of Cinder"),
        new CaballoRunner(11, "Slayer Ornstein"),
        new CaballoRunner(12, "Father Manus")};
    }

    public void SelecRooster()
    {
        Competidores.Clear();
        Random rng = new Random();
        List<Caballo> temp = new List<Caballo>(rooster);
        for (int i = 0; i < 6; i++)
        {
            int num = rng.Next(temp.Count);
            Competidores.Add(temp[num]);
            temp.RemoveAt(num);
        }
    }
    public void Simular(double distanciaMeta)
    {
        foreach (var caballo in Competidores)
        {
            if (caballo.PositionX < distanciaMeta)
            {
                caballo.Avanzar(distanciaMeta);
            }
        }
    }
    public void PrepPista()
    {
        Podio.Clear();
        SelecRooster();
        foreach (var caballo in Competidores)
        {
            caballo.PositionX = 0;
        }
    }
}