string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish", "horses" };
string[] characters = { "Dad", "Mother" };

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(characters);

static void PrintArrayElements(string[] someArray)
{

    for (int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i+1}. {someArray[i]}");
    }
}