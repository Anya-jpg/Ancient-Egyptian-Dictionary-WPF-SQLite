using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EgyptianDictionary_SQLite
{
    public partial class Categoria
    {
        private string name;
        private short amount;
        private string categoria;
        public int Id { get; set; }
        public string Categoria1
        {
            get { return categoria; }
            set
            {
                categoria = value;
                OnPropertyChanged("Categoria");
            }
        }
        public Nullable<short> Amount
        {
            get { return amount; }
            set
            {
                amount = (short)value;
                OnPropertyChanged("Amount");
            }
        }
        public string Name {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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
