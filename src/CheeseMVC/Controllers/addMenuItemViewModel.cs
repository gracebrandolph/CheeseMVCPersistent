using CheeseMVC.Models;
using System.Collections.Generic;

namespace CheeseMVC.Controllers
{
    internal class addMenuItemViewModel
    {
        private Menu theMenu;
        private List<Cheese> cheeses;

        public addMenuItemViewModel(Menu theMenu, List<Cheese> cheeses)
        {
            this.theMenu = theMenu;
            this.cheeses = cheeses;
        }
    }
}