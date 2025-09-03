public class LinqProblems
{
    public static IEnumerable<int> FilterAndDouble(List<int> nums)
    {
        return nums.Where(x => x % 2 == 0 && x > 5).Select(x => x * 2);
    }

    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(x => x.Category).
        ToDictionary(
            g => g.Key,
            g => g.Sum(x => x.Amount)
            );

    }
}

public class Sale
{
    public int Amount { get; set; }
    public string Category { get; set; }
}