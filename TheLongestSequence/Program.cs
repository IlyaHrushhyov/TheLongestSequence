// See https://aka.ms/new-console-template for more information

var str = "Carramba doom EeefeeTttstt";
var result = StringHelper.StringSequenceHelper.FindMaxSequenceForEveryWord(str);

foreach (var item in result)
{
    Console.WriteLine($"{item.Character}: {item.Count}");
}

Console.WriteLine();
