using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EgyptianDictionary_SQLite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pharaoh
    {
        private string name;
        private string birthname;
        private string birthdescription;
        private string thronename;
        private string thronedescription;
        private string dynasty;
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
        public string BirthName
        {
            get { return birthname; }
            set
            {
                birthname = value;
                OnPropertyChanged("BirthName");
            }
        }
            
        public string BirthDescription
        {
            get { return birthdescription; }
            set
            {
                birthdescription = value;
                OnPropertyChanged("BirthDescription");
            }
        }
        public string ThroneName
        {
            get { return thronename; }
            set
            {
                thronename = value;
                OnPropertyChanged("ThroneName");
            }
        }
        public string ThroneDescription
        {
            get { return thronedescription; }
            set
            {
                thronedescription = value;
                OnPropertyChanged("ThroneDescription");
            }
        }
        public string Dynasty
        {
            get { return dynasty; }
            set
            {
                dynasty = value;
                OnPropertyChanged("Dynasty");
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
