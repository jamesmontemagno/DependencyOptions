using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DependencyOptions;

public partial class CounterViewModel : ObservableObject
{
    [ObservableProperty]
    int count;


    [RelayCommand]
    void IncreaseCount() => Count++;
}
