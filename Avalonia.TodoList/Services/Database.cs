using System.Collections.Generic;
using Avalonia.TodoList.Models;

namespace Avalonia.TodoList.Services;

public class Database
{
    public static IEnumerable<TodoItem> GetItems() => new[]
    {
        new TodoItem { Description = "Walk the cat" },
        new TodoItem { Description = "Buy some milk" },
        new TodoItem { Description = "Learn Avalonia", IsChecked = true }
    };
}