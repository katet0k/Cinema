using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain
{
    public class FilmsList : INotifyPropertyChanged
    {
        public List<Film>? films = null;
        private Film selectedFilm;
        public Film SelectedFilm
        {
            get { return selectedFilm; }
            set 
            {
                selectedFilm = value;
                OnPropertyChanged("Film");
            }
        }

        public FilmsList()
        {
            films = new List<Film>();
        }
        public void AddFilm(Film film)
        {
            films?.Add(film);
        }
        public void RemoveFilm(Film film)
        {
            films?.Remove(film);
        }
        public void RemoveFilm(int index)
        {
            films?.RemoveAt(index);
        }
        public void RemoveAllFilms()
        {
            films?.Clear();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
