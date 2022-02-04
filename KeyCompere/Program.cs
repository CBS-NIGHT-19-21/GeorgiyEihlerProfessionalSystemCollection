/*
 Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений 
ключей.
 */

using Newtonsoft.Json;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

var od = new OrderedDictionary(new CustomEqualyComparer());


class CustomEqualyComparer : IEqualityComparer
{
    public new bool Equals(object? x, object? y) =>
        x.GetHashCode() == y.GetHashCode();

    public int GetHashCode([DisallowNull] object obj) =>
        obj.GetHashCode();
}

class CustomEqualyComparerSerel : IEqualityComparer
{
    public new bool Equals(object? x, object? y) =>
       JsonConvert.SerializeObject(x) == JsonConvert.SerializeObject(y);

    public int GetHashCode([DisallowNull] object obj) =>
        obj.GetHashCode();
}