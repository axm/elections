using System;

namespace Spartan.Elections.Web.Api.v1.Static.Models
{
    public sealed class MenuModel
    {
        public MenuItemModel[] MenuItems { get; set; } = Array.Empty<MenuItemModel>();
    }
}
