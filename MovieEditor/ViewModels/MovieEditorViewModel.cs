using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieEditor.Models;

namespace MovieEditor.ViewModels;

public partial class MovieEditorViewModel : ObservableObject
{
    [ObservableProperty]
    private Movie _currentMovie = new("Movie", true);

    [RelayCommand]
    private void ResetMovie()
    {
        CurrentMovie = new Movie(CurrentMovie.Description, false);
    }
}