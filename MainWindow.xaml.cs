using Cinema.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cinema
{
    public partial class MainWindow : Window
    {
        FilmsList list;
        public MainWindow()
        {
            list = new FilmsList();
            list.AddFilm(new Film("Mavka1", @"C:\Users\Kpojl\Source\Repos\Cinema\Assets\FilmMavka.jpg", "1"));
            list.AddFilm(new Film("Mavka2", @"C:\Users\Kpojl\Source\Repos\Cinema\Assets\FilmMavka.jpg", "2"));
            list.AddFilm(new Film("Mavka3", @"C:\Users\Kpojl\Source\Repos\Cinema\Assets\FilmMavka.jpg", "3"));
            list.AddFilm(new Film("Mavka4", @"C:\Users\Kpojl\Source\Repos\Cinema\Assets\FilmMavka.jpg", "4"));
            InitializeComponent();
            LVFilms.ItemsSource = list.films;
        }
    }
}
