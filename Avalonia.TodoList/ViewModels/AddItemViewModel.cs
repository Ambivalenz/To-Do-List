using System.Reactive;
using Avalonia.TodoList.Models;
using ReactiveUI;

namespace Avalonia.TodoList.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    private string? _description;

    public AddItemViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrEmpty(x));

        Ok = ReactiveCommand.Create(
            () => new TodoItem() {Description = Description},
            okEnabled);
        Cancel = ReactiveCommand.Create(() => { });
        
    }

    private string? Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }
    
    public ReactiveCommand<Unit, TodoItem> Ok { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }
}