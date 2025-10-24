using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public partial class AfrekenenViewModel : BaseViewModel
    {
        private readonly IGroceryListService _groceryListService;
        private readonly IGroceryListItemsService _myGroceryListItems;
        public ObservableCollection<GroceryList> GroceryLists { get; set; }
        public ObservableCollection<GroceryListItem> MyGroceryListItems { get; set; }
        

        public AfrekenenViewModel(IGroceryListService groceryListService, IGroceryListItemsService myGroceryListItems)
        {
            _groceryListService = groceryListService;
            _myGroceryListItems = myGroceryListItems;
            GroceryLists = new(_groceryListService.GetAll());
            MyGroceryListItems = new(_myGroceryListItems.GetAll());

        }
    }
}
