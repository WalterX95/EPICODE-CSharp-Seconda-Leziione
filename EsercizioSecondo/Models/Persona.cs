using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSecondo.Models
{
    public class Persona
    {
        private string _nome = string.Empty;
        private string _cognome = string.Empty;
        private int _eta;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Cognome { get { return _cognome; } set { _cognome = value; } }

        public int Eta { get { return _eta; } set { _eta = value; } }

     
        public string GetNome()
        {
            return Nome;  
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public void GetDettagli()
        {
            Console.WriteLine("Nome : " + GetNome());
            Console.WriteLine("Cognome :" + GetCognome());
            Console.WriteLine("Età : " + GetEta());
        }

    }
}
