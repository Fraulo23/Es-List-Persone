using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_List_Persone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Persona> persone = new List <Persona> ();
            Console.WriteLine("Quante persone si vogliono inserire nella lista?");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string nome=Console.ReadLine();
                int eta=int.Parse(Console.ReadLine());
                persone.Add(new Persona(nome,eta));
            }
            foreach (Persona p in persone)
            {
                if (p.Eta >= 18)
                {
                    Console.WriteLine(p);
                }
            }
            Console.ReadLine();
        }
    }
}
