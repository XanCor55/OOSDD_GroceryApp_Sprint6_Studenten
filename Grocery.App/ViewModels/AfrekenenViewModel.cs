using CommunityToolkit.Mvvm.ComponentModel;
using Grocery.Core.Data.Repositories;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using Grocery.Core.Services;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public partial class AfrekenenViewModel : BaseViewModel
    {
        public ObservableCollection<GroceryList> GroceryLists { get; set; }
        private readonly IGroceryListService _groceryListService;
        public ObservableCollection<GroceryListItem> MyGroceryListItems { get; set; } = [];

        public AfrekenenViewModel(IGroceryListService groceryListService)
        {
            _groceryListService = groceryListService;
            GroceryLists = new(_groceryListService.GetAll());
        }
    }
}
