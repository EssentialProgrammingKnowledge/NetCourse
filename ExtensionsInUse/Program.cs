using ExtensionsInUse;

string text = "TestText";
text = text.AddExtraLine();
text = text.AddExtraLineWithText("text1234");
Console.WriteLine(text);