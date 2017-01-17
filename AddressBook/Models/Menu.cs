using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
    public class Menu
    {
        public string Nombre { get; set; }
        public string Seccion { get; set; }

        public static List<Menu> Menus { get; set; }

        public static List<Menu> GetMenus()
        {
            if (Menus == null)
            {
                Menus = new List<Menu>();
            }

            Menus.Add(new Menu() { });
            Menus.Add(new Menu() { });
            Menus.Add(new Menu() { });

            return Menus;
        }
    }
}