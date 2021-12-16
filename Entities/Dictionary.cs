using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EgyptianDictionary_SQLite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dictionary
    {
        private string glyph;
        private string unicode;
        private string categoria;
        private string gardiner;
        private string description;
        private string phonogram;
        private string transliteration;
        private string notes;
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
        public string Unicode
        {
            get { return unicode; }
            set
            {
                unicode = value;
                OnPropertyChanged("Unicode");
            }
        }
        public string Categoria
        {
            get { return categoria; }
            set
            {
                categoria = value;
                OnPropertyChanged("Categoria");
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
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public string Phonogram
        {
            get { return phonogram; }
            set
            {
                phonogram = value;
                OnPropertyChanged("Phonogram");
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
        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged("Notes");
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
