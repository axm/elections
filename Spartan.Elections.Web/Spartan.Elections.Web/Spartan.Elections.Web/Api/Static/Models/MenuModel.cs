using System;

namespace Spartan.Elections.Web.Api.Static.Models
{
    public sealed class MenuModel
    {
        public MenuItemModel[] MenuItems { get; set; } = Array.Empty<MenuItemModel>();
    }
}
