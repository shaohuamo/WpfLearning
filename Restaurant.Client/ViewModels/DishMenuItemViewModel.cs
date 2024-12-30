using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.ViewModel;
using Restaurant.Client.Models;

namespace Restaurant.Client.ViewModels
{
    public class DishMenuItemViewModel : NotificationObject
    {
        public Dish Dish { get; set; }

        private bool isSelected;

        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                RaisePropertyChanged(nameof(IsSelected));
            }
        }
    }
}
