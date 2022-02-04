/*
    Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар 
    «ключ- значение» сначала в алфавитном порядке, а затем в обратном.
 */


var sl = new SortedList<string, string>();
for (int i = 0; i < 11; i++)
{
    sl.Add(new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMM"), 
        new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMMM"));
}

foreach (var item in sl)
{
    Console.WriteLine($"{item.Key}-{item.Value}");
}

sl = new SortedList<string, string>(new CustomsCompere<string>());
for (int i = 0; i < 11; i++)
{
    sl.Add(new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMM"),
        new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMMM"));
}
foreach (var item in sl)
{
    Console.WriteLine($"{item.Key}-{item.Value}");
}



class CustomsCompere<T> : IComparer<T>
    where T : IComparable
{
    public int Compare(T? x, T? y) =>
        y.CompareTo(x);
}