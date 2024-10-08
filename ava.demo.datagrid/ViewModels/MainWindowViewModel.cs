using System.Collections.ObjectModel;
using System.Linq;
using ava.demo.datagrid.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ava.demo.datagrid.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [RelayCommand]
    private void ItemSelect(int id)
    {
        var item = Items.FirstOrDefault((DataModel o) => o.Id == id);
        if (item == null)
        {
            return;
        }

        if (SetSelectedBeforeRemove)
        {
            item.IsSelected = false;
        }

        Items.Remove(item);
    }

    [RelayCommand]
    private void Reset()
    {
        Items =
        [
            new DataModel
            {
                Id = 1,
                IsSelected = true
            },

            new DataModel
            {
                Id = 2,
                IsSelected = true
            },

            new DataModel
            {
                Id = 3,
                IsSelected = true
            },

            new DataModel
            {
                Id = 4,
                IsSelected = true
            },

            new DataModel
            {
                Id = 5,
                IsSelected = true
            },

            new DataModel
            {
                Id = 6,
                IsSelected = true
            }
        ];
        
        DataGridHeight = 190;
    }


    [ObservableProperty]
    private ObservableCollection<DataModel> _items =
    [
        new DataModel
        {
            Id = 1,
            IsSelected = true
        },

        new DataModel
        {
            Id = 2,
            IsSelected = true
        },

        new DataModel
        {
            Id = 3,
            IsSelected = true
        },

        new DataModel
        {
            Id = 4,
            IsSelected = true
        },

        new DataModel
        {
            Id = 5,
            IsSelected = true
        },

        new DataModel
        {
            Id = 6,
            IsSelected = true
        }
    ];

    [ObservableProperty]
    private bool _setSelectedBeforeRemove;


    [ObservableProperty]
    private int _dataGridHeight = 190;
}