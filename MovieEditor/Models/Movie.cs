using CommunityToolkit.Mvvm.ComponentModel;

namespace MovieEditor.Models;

[ObservableObject]
public partial class Movie
{
    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private bool _seen;

    public Movie(string description, bool seen)
    {
        _description = description;
        _seen = seen;
    }
}