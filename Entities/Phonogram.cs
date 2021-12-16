using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EgyptianDictionary_SQLite
{
    
    public partial class Phonogram
    {
        private string glyph;
        private string gardiner;
        private string transliteration;
        private string manuel;
        private string type;
        public int Id { get; set; }
        public string Glyph
        {
            get { return glyph; }
            set
            {
                glyph = value;
                OnPropertyChanged("Glyph");
            }
        }
        public string GardinerCode
        {
            get { return gardiner; }
            set
            {
                gardiner = value;
                OnPropertyChanged("GardinerCode");
            }
        }
        public string Transliteration
        {
            get { return transliteration; }
            set
            {
                transliteration = value;
                OnPropertyChanged("Transliteration");
            }
        }
        public string ManuelCotage
        {
            get { return manuel; }
            set
            {
                manuel = value;
                OnPropertyChanged("ManuelCotage");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
