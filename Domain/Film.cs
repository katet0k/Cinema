using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain
{
    public class Film : INotifyPropertyChanged
    {
        private string ?_name;
        private string ?_photo;
        private string ?_rating;

        public string? Name
        {
            get { return _name; }
            set
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }
        public string? Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                OnPropertyChanged("Rating");
            }
        }
        public Film(string? name, string? photo, string? rating)
        {
            Name = name;
            Photo = photo;
            Rating = rating;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
