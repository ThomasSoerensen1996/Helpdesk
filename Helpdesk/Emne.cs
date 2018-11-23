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

        public Emne()
        private string _titel;
        private string _beskrivelse;
        private string _forklaring;
        private string _kodeEksempel;
        private string _semester;
        private Quiz Quiz;

        public Emne(string _titel, string _beskrivelse, string _forklaring, string _kodeEksempel, string _semester)
        {
            this._titel = Titel;
            this._beskrivelse = Beskrivelse;
            this._forklaring = Forklaring;
            this._kodeEksempel = KodeEksempel;
            this._semester = Semester;

        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public string Forklaring
        {
            get { return _forklaring; }
            set { _forklaring = value; }
        }

        public string KodeEksempel
        {
            get { return _kodeEksempel; }
            set { _kodeEksempel = value; }
        }

        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        public Quiz Quiz1
        {
            get { return Quiz; }
            set { Quiz = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set { Titel = value;  }
        }
    }
}
