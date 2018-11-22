using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    class Emne
    {
        private string Titel { get; set; }
        private string Beskrivelse { get; set; }
        private string Forklaring { get; set; }
        public string KodeEksempel { get; set; }
        private string Semester { get; set; }
        private Quizz Quizz { get; set; }

        public Emne()
        {
            
        }
    }
}
