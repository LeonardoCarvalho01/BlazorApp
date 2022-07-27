namespace BlazorAppButton.Data
{
    public class PizzaServices
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            return Task.FromResult<Pizza[]>(null);
        }
    }
}
