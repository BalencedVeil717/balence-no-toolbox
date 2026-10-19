using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BalenceNoToolbox;

public class Todos : INotifyPropertyChanged
{

    public Todos()
    {
        _allTodos = new ObservableCollection<Todo>()
        {
            new Todo() { Title = "take out the thrash" },
            new Todo() { Title = "feed the zog", IsDone = true}
        };
    }
    public  event PropertyChangedEventHandler? PropertyChanged;

    private void onPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private ObservableCollection<Todo> _allTodos;

    public ObservableCollection<Todo> AllTodos
    {
        get { return _allTodos; }
        set
        {
            _allTodos = value;
            onPropertyChanged(nameof(AllTodos));
        }
    }
}