///// Momento Pattern


using Momento_Pattern.src.Momento_Pattern;

var editor = new Editor();
var history = new History(editor);

history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "Hello, My name is Muhammad Abdullah";
history.BackUp();
editor.Title = "The Life of a dev: My mementos";


System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.ShowHistory();

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");