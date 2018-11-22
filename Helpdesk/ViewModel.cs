using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Helpdesk.Annotations;

namespace Helpdesk
{
    class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Emne> _emneListe = new ObservableCollection<Emne>();

        public ViewModel()
        {
            
            EmneListe.Add(new Emne() { Titel = "Test" });
            EmneListe.Add(new Emne() { Titel = "Test2" });
            EmneListe.Add(new Emne() { Titel = "Test3" });
        }

        public ObservableCollection<Emne> EmneListe
        {
            get { return _emneListe; }
            set { _emneListe = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Navigation til en andet page, via login.

        //public void checkLogin()
        //{
        //    foreach (var user in _users)
        //    {
        //        if (InputUsername == user.Username)
        //        {
        //            if (InputPassword == user.Password)
        //            {
        //                LoginCheck = "Access granted";
        //                Frame currentFrame = Window.Current.Content as Frame;
        //                currentFrame.Navigate(typeof("Page name"));
        //                break;
        //            }

        //            else
        //            {
        //                LoginCheck = "Wrong password";
        //                break;
        //            }



        //        }
        //        else LoginCheck = "Access denied";

        //    }
        //}
    }
}
