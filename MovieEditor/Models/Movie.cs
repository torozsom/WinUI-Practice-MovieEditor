using CommunityToolkit.Mvvm.ComponentModel;

namespace MovieEditor.Models;

public partial class Movie : ObservableObject
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