using AliasAnyType;
using Marks = System.Collections.Generic.List<AliasAnyType.Mark>;

Marks marksAlias = [ new Mark(5), new Mark(4) ];
marksAlias.ForEach(Console.WriteLine);
