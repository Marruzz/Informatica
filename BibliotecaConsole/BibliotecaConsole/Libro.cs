using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConsole
{
    class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Pagine { get; set; }
        public decimal Prezzo { get; set; }
        private int CodiceSegreto { get; set; }

        // costruttore
        public Libro() 
        {
            //questo è un blocco di codice che viene eseguito alla creazione degli oggetti di questa classe
            CodiceSegreto = 321;
        }
        
    }
}