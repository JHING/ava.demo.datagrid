using CommunityToolkit.Mvvm.ComponentModel;

namespace ava.demo.datagrid.Models;

public partial class DataModel : ObservableObject
{
    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private bool _isSelected;
}