using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using Restaurant.Client.Services;
using Restaurant.Client.Models;

namespace Restaurant.Client.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get => count;
            set
            {
                count = value;
                RaisePropertyChanged(nameof(Count));
            }
        }

        private RestaurantDataModel _restaurant;

        public RestaurantDataModel Restaurant
        {
            get => _restaurant;
            set
            {
                _restaurant = value;
                RaisePropertyChanged(nameof(Restaurant));
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get => dishMenu;
            set
            {
                dishMenu = value;
                RaisePropertyChanged(nameof(DishMenu));
            }
        }

        public MainWindowViewModel()
        {
            LoadRestaurant();
            LoadDishMenu();
            PlaceOrderCommand = new DelegateCommand(new Action(PlaceOrderCommandExecute));
            SelectMenuItemCommand = new DelegateCommand(new Action(SelectMenuItemExecute));
        }

        private void LoadRestaurant()
        {
            Restaurant = new RestaurantDataModel
            {
                Name = "Crazy大象",
                Address = "北京市海淀区万泉河路紫金庄园1号楼 1层 113室（亲们：这地儿特难找！）",
                PhoneNumber = "15210365423 or 82650336"
            };
        }

        private void LoadDishMenu()
        {
            IDataService ds = new XmlDataService();
            var dishes = ds.GetAllDishes();
            DishMenu = new List<DishMenuItemViewModel>();
            foreach (var dish in dishes)
            {
                DishMenuItemViewModel item = new DishMenuItemViewModel
                {
                    Dish = dish
                };
                DishMenu.Add(item);
            }
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = DishMenu.
                Where(i => i.IsSelected == true).
                Select(i => i.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功！");
        }

        private void SelectMenuItemExecute()
        {
            Count = DishMenu.Count(i => i.IsSelected == true);
        }
    }
}
