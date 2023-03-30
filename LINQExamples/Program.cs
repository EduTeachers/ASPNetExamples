// See https://aka.ms/new-console-template for more information

string[] names = { "Karel", "Josef", "Eva", "Alt", "Ash" };

// Select
List<string> selectedNames = names.Select(name => name.ToLower()).ToList();
Console.WriteLine(string.Join(", ", selectedNames));

// Where
List<string> updatedNames = names.Where(name => name.Length > 4).ToList();
// List<string> updatedNames = names.Where((name, index) => name.Length > 4).ToList();
Console.WriteLine(string.Join(", ", updatedNames));

// OrderBy
List<string> sortedNames = names.OrderBy(name => name.Length).ToList();
Console.WriteLine(string.Join(", ", sortedNames));

// OrderBy
List<IGrouping<int, string>> groupedNames = names.GroupBy(s => s.Length).ToList();
for (int groupIndex = 0; groupIndex < groupedNames.Count; groupIndex++)
{
    IGrouping<int, string> group = groupedNames[groupIndex];
    Console.WriteLine(group.Key + ": " + string.Join(", ", group));
}

// Take a skip
List<string> top3 = names.OrderBy(name => name.Length).Skip(1).Take(3).ToList();
Console.WriteLine(string.Join(", ", top3));

// All a any
bool larger = names.All(name => name.Length > 2);
// bool atLeastOne = names.Any(name => name.Length > 2);
Console.WriteLine(larger);

// Sum / Aggregate
int[] prices = { 100, 200, 300, 100 };
Console.WriteLine(prices.Sum());
Console.WriteLine(prices.Aggregate((c, v) => c + v));