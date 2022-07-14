namespace meal_planning_api.Repositories
{
    public interface IMealsRepository
    {
        public Task<IEnumerable<Meal>> GetMeals();
    }
}
