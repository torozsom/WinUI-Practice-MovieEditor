using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieEditor.Models;

namespace MovieEditor.ViewModels;

[ObservableObject]
public partial class MovieEditorViewModel
{
    [ObservableProperty]
    private Movie _currentMovie = new("Movie", true);

    [RelayCommand]
    private void ResetMovie() => CurrentMovie.Seen = false;

}