using Microsoft.UI.Xaml.Controls;
using MovieEditor.ViewModels;

namespace MovieEditor.Views;

public sealed partial class MovieEditor : Page
{
    public MovieEditorViewModel ViewModel { get; } = new();

    public MovieEditor() { InitializeComponent(); }

}