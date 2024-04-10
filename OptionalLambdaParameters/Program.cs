var func1 = (string a) => Console.WriteLine(a);
var func2 = (string a = "test123") => Console.WriteLine(a);

func1("a");
func2();
func2("a");
