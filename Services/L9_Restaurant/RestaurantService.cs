namespace allforone.Services.L9_Restaurant;
public class RestaurantService : IRestaurantService
{
    public string Choose(string category)
    {
        string[] pizzaCategory = { "Dominoes", "Mountain Mikes", "Costco Pizza", "Pizza Hut", "Papa Johns", "Little Cesears", "Dante's Pizza & Cafe", "Round Table", "Blaze Pizza", "Pieology" };
        string[] sushiCategory = { "Sushi Kinoya", "Shogun", "Shirasoni", "Domo Sushi Grill", "Sushi Villa Buffet", "ShoMi Japanese Cuisine", "Hana Sushi", "Toyo Sushi", "Matsuyama", "Sushi Hub" };
        string[] burgersCategory = { "In N Out", "The Habit", "Five Star Burger", "Moo Moo's Burger Barn", "Squeeze Burger and Brew", "Carl's Jr.", "Wendy's", "Burger King", "Five Guys", "Jack in the Box" };

        Random randChoice = new Random();
        int numChoice = randChoice.Next(10);

        switch (category.ToLower())
        {
            case "pizza":
                return pizzaCategory[numChoice];
            case "sushi":
                return sushiCategory[numChoice];
            case "burgers":
                return burgersCategory[numChoice];
            default:
                return "Error: Please choose one of the valid categories (pizza, sushi, or burgers)";
        }
    }
}
