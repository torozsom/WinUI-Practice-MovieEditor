using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieEditor.Models;

namespace MovieEditor.ViewModels
{
    public partial class MovieEditorViewModel : ObservableObject
    {
        [ObservableProperty]
        private Movie _currentMovie = new("Movie", true);

        [RelayCommand]
        public void ResetMovie()
        {
            CurrentMovie = new Movie(_currentMovie.Description, false);
        }
    }
}