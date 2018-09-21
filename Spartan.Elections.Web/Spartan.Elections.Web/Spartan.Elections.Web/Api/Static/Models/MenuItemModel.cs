using System;

namespace Spartan.Elections.Web.Api.Static.Models
{
    public sealed class MenuItemModel
    {
        public string Label { get; set; }
        public string Url { get; set; }

        public MenuItemModel[] MenuItems { get; set; } = Array.Empty<MenuItemModel>();
    }
}
