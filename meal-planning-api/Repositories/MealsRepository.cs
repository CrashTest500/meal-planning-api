namespace meal_planning_api.Repositories
{
    public class MealsRepository : IMealsRepository
    {
        public async Task<IEnumerable<Meal>> GetMeals()
        {
            try
            {
                Meal[] meals =
                {
                    new() { Id = 1, Name = "Spaghetti" },
                    new() { Id = 2, Name = "Pizza" },
                    new() { Id = 3, Name = "Steak" },
                    new() { Id = 4, Name = "Porkchops" },
                    new() { Id = 5, Name = "Hamburgers" },
                    new() { Id = 6, Name = "Meatball Subs" },
                    new() { Id = 7, Name = "Pancakes" },
                    new() { Id = 8, Name = "Salmon" },
                    new() { Id = 9, Name = "Chicken Fried Rice" },
                    new() { Id = 10, Name = "BBQ Chicken" },
                    new() { Id = 11, Name = "Pancakes" },
                    new() { Id = 12, Name = "Tacos" },
                    new() { Id = 13, Name = "Chicken Alfredo" },
                    new() { Id = 14, Name = "Chicken Bacon Ranch Pasta" },
                    new() { Id = 15, Name = "Chicken Noodle Soup" },
                    new() { Id = 16, Name = "Biscuits and Gravy" },
                    new() { Id = 17, Name = "Lo Mein" },
                    new() { Id = 18, Name = "Sweet and Sour Chicken" },
                    new() { Id = 19, Name = "Grilled Cheese" },
                    new() { Id = 20, Name = "Lasagna" }
                };

                return await Task.Run(() => meals);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error retreiving Meals", e);
                return null;
            }
        }
    }
}
