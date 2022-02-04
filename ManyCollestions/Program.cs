/*
 Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и 
вещественные значения, по типу «счет предприятия – доступная сумма» соответственно. 
 */

var collectionOne = new Dictionary<int, decimal>();

var collectionTwo = new SortedDictionary<int, decimal>();

var collectionThree = new SortedList<int, decimal>();

var collectionFour = new List<KeyValuePair<int, decimal>>();

