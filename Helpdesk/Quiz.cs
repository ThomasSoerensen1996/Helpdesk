using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk
{
    class Quiz
    {
        //Q = Question
        //Qa = Question answer

        //Måske skal det laves på en anden måde? TEMP
        private string _q1;
        private string _qa1;
        private string _q2;
        private string _qa2;
        private string _q3;
        private string _qa3; 

        public Quiz(string _q1, string qa1, string _q2, string qa2, string _q3, string qa3)
        {
            this._q1 = Q1;
            this._qa1 = Qa1;
            this._q2 = Q2;
            this._qa2 = Qa2;
            this._q3 = Q3;
            this._qa3 = Qa3;

        }

        public string Q1
        {
            get { return _q1; }
            set { _q1 = value; }
        }

        public string Qa1
        {
            get { return _qa1; }
            set { _qa1 = value; }
        }

        public string Q2
        {
            get { return _q2; }
            set { _q2 = value; }
        }

        public string Qa2
        {
            get { return _qa2; }
            set { _qa2 = value; }
        }

        public string Q3
        {
            get { return _q3; }
            set { _q3 = value; }
        }

        public string Qa3
        {
            get { return _qa3; }
            set { _qa3 = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("");

            return sb.ToString();
        }
    }
}
