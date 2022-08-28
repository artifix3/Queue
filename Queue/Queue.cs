//Creating Queue 
Queue<string> classes = new Queue<string>();

// Adding classes to our queue

classes.Enqueue("11");
classes.Enqueue("10");
classes.Enqueue("9");
classes.Enqueue("8");

// Print all Queue elements 

foreach (var item in classes)
{
    Console.WriteLine(item + " ");
}

//POP method -> print first added element and remove it . If our Queue is empty we will get InvalidOperationException. 
Console.WriteLine("------------------------ Using POP method -----------------------------");
if (classes.Count > 0) // classes.Count function return count of elements 
{

    Console.WriteLine("The first added elemet of Queue = " + classes.Dequeue());
}
else
{
    Console.WriteLine("Queue Queue is empty ");
}

Console.WriteLine("------------------------ After Using POP method -----------------------------");
foreach (var item in classes)
{
    Console.WriteLine(item + " ");
}

// Peek- > Method -> also print first added element but do not remove it 
Console.WriteLine("------------------------ Using PEEK method -----------------------------");
if (classes.Count > 0) // classes.Count function return count of elements 
{

    Console.WriteLine("The first added elemet of Queue = " + classes.Peek());
}
else
{
    Console.WriteLine("classes Queue is empty ");
}
Console.WriteLine("------------------------ After Using PEEK method -----------------------------");
foreach (var item in classes)
{
    Console.WriteLine(item + " ");
}


// The Contains() method checks if the specified item is in a Queue collection. Returns true if present, false otherwise.
Console.WriteLine("------------------------ Using Contains method -----------------------------");
bool bool1 = classes.Contains("11");
bool bool2 = classes.Contains("7");
Console.WriteLine("------------------------ Our Queue -----------------------------");
foreach (var item in classes)
{
    Console.WriteLine(item + " ");
}
if (bool1)
{
    Console.WriteLine("We have 11 class in our Queue");
}
else
{
    Console.WriteLine("we Do not have 11 class in our queue");
}
if (bool2)
{
    Console.WriteLine("We have 7 class in our Queue");
}
else
{
    Console.WriteLine("we Do not have 7 class in our queue");
}
