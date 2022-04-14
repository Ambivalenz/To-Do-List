using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.TodoList.Models;

namespace Avalonia.TodoList.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public TodoListViewModel(IEnumerable<TodoItem> items)
    {
        Items = new ObservableCollection<TodoItem>(items);
    }
    
    public ObservableCollection<TodoItem> Items { get; }
}