using System.Collections;

var list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);

var hashtable = new Hashtable();
hashtable.Add(2, "dwa");
hashtable.Add(1, "jeden");

var sortedList = new SortedList();
sortedList.Add(2, "dwa");
sortedList.Add(1, "jeden");
sortedList.Add(3, "trzy");

var listGeneric = new List<decimal>();
listGeneric.Add(1);
listGeneric.Add(200);
listGeneric.Add(100);
listGeneric.Add(5);

var dicitionary = new Dictionary<string, string>();
dicitionary.Add("1", "1");
dicitionary.TryAdd("1", "1");
dicitionary["2"] = "2";

Console.WriteLine(dicitionary.ContainsKey("2"));

var queue = new Queue<string>();
queue.Enqueue("1");
queue.Enqueue("2");
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());

var stack = new Stack<string>();
stack.Push("1");
stack.Push("2");
stack.Push("3");
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine();

var enumerator = listGeneric.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

var enumerable = GetTestData();
foreach(var i in enumerable)
{
    Console.WriteLine(i);
}

static IEnumerable<int> GetTestData()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
}