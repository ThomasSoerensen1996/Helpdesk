using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using Windows.Devices.AllJoyn;
using Windows.Storage;
using Windows.UI.Popups;
using Newtonsoft.Json;
namespace Helpdesk
{
    class PersistencyService
    {

        private static string _jsonFileName = "Notes.json";

        public static string JsonFileName
        {
            get { return _jsonFileName; }
            set { _jsonFileName = value; }
        }

        public static async void SaveNotesAsJsonAsync(ObservableCollection<Emne> notes)
        {
            string notesJsonString = JsonConvert.SerializeObject(notes);
            //SerializeNotesFileAsync(notesJsonString, JsonFileName);
        }

        public static async Task<List<Emne>> LoadNotesFromJsonAsync()
        {
            string notesJsonString = await DeserializeNotesFileAsync(JsonFileName);
            if (notesJsonString != null)
            {
                return (List<Emne>) JsonConvert.DeserializeObject(notesJsonString, typeof(List<Emne>));
                return null;
            }
        }

        private static async void SerializeNotesFileAsync(string notesJsonString, string filename)
        {
            StorageFile localFile =
                await ApplicationData.Current.LocalFolder.CreateFileAsync(filename,
                    CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, JsonFileName);
        }

        public static async Task<string> DeserializeNotesFileAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException e)
            {
                MessageDialogHelper.Show("Loading for the first time? - Try Add and Save some Notes before trying to Save for the first time", "File not Found");
                return null;
                
            }
        }

        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();

            }
        }



    }
}
