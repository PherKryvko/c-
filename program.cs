//Variables are strongly typed, unlike python's dynamically typed
int x = 100;
decimal d = 100m; 
float f = 100f;

//Execution stuff
//src for one-2-many csprojs
//csproj has configuration/runtime/target info
//bin has temp build, obj has runtime temp files
//code -> compiler -> IL -> runtime -> JIT -> CPU


x = (int) d; //casting trunctates the value, no rounding 



///Strings
/// Are immutable
/// 

string example = " EEE  eee ee ";
example = example.Trim().ToLower();

string[] examplesSplit = example.Split(" ");


foreach (string word in examplesSplit)
{
    Console.WriteLine($"word: {word}");
}

example = example.Replace("E", "e");

if (example.Contains("e"))
{
    Console.Write($"E found {example.IndexOf("e")}");
}
