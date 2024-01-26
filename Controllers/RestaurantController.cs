using allforone.Services.L9_Restaurant;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    
    [HttpGet]
    [Route("ChoosePizzaSushiOrBurgers/{category}")]
    public string Choose(string category)
    {
        return _restaurantService.Choose(category);
    }
}
