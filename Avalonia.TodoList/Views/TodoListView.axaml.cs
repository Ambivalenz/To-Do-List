using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Avalonia.TodoList.Views;

public partial class TodoListView : UserControl
{
    public TodoListView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}