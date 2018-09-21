using Microsoft.AspNetCore.Mvc;
using Spartan.Elections.Web.Api.Static.Models;
using Spartan.Elections.Web.Static.Requests;
using System.Threading.Tasks;

namespace Spartan.Elections.Web.Static.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticDataController : ControllerBase
    {
        [HttpGet("Menu")]
        public async Task<GetMenuResponse> GetMenu()
        {
            return await Task.FromResult(new GetMenuResponse
            {
                Menu = new MenuModel
                {
                    MenuItems = new[]
                    {
                        new MenuItemModel
                        {
                            Label = "Alex",
                        },
                        new MenuItemModel
                        {
                            Label = "Vlad",
                        }
                    }
                }
            });
        }
    }
}