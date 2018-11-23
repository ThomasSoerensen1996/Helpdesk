using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    class Emne
    {
        public string Titel { get; set; }
        public string Beskrivelse { get; set; }
        private string Forklaring { get; set; }
        private string KodeEksempel { get; set; }
        private string Semester { get; set; }
        private Quiz Quiz { get; set; }
    }
}
