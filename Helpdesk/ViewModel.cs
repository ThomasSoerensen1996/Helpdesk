using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using Helpdesk.Annotations;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;

namespace Helpdesk
{
    class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Emne> _emneListe = new ObservableCollection<Emne>();
        private RelayCommand seMereCommand;

        public ViewModel()
        {
            EmneListe.Add(new Emne() { Titel = "Test", Beskrivelse = "Test beskrivelse"});
            EmneListe.Add(new Emne() { Titel = "Test2", Beskrivelse = "Test beskrivelse2"});
            EmneListe.Add(new Emne() { Titel = "Test3", Beskrivelse = "Test beskrivelse3"});
            seMereCommand = new RelayCommand(SeMere);
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

        public RelayCommand SeMereCommand
        {
            get => seMereCommand;
            set => seMereCommand = value;
        }

        public void SeMere()
        {

        }
        //Save and restore info
        public void SerializeObject<T>(T serializableObject, string filename)
        {
            if (serializableObject == null) { return;}

            try
            {
                XmlDocument document = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream,serializableObject);
                    stream.Position = 0;
                    document.Load(stream);
                    document.Save(stream);
                    
                }
            }
            catch (Exception e)
            {
                if (e == null)
                {
                    //blabla
                }
                throw;
            }   
            
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
