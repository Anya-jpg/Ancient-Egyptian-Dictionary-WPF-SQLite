using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EgyptianDictionary_SQLite
{


    public partial class God
    {
        private string name;
        private string gardinergode;
        private string hieroglyphic;
        private string transliteration;
        private string type;
        private string description;
        private string view;
        public int Id { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string GardinerCode {
            get { return gardinergode; }
            set
            {
               gardinergode = value;
                OnPropertyChanged("GardinerCode");
            }
        }
        public string Hieroglyphic {
            get { return hieroglyphic; }
            set
            {
                hieroglyphic = value;
                OnPropertyChanged("Hieroglyphic");
            }
        }
        public string Transliteration {
            get { return transliteration; }
            set
            {
               transliteration = value;
                OnPropertyChanged("Transliteration");
            }
        }
        public string Type {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public string Description {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public string View {
            get { return view; }
            set
            {
                view = value;
                OnPropertyChanged("View");
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
