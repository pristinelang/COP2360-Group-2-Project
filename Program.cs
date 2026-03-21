Dictionary<string, string> Group2Dictionary = new Dictionary<string, string>();
int choice;

do
{
    Console.WriteLine("\nGroup 2 Dictionary");
    Console.WriteLine("1. Populate the Dictionary");
    Console.WriteLine("2. Display Dictionary Contents");
    Console.WriteLine("3. Remove a Key");
    Console.WriteLine("4. Add a New Key and Value");
    Console.WriteLine("5. Add a Value to an Existing Key");
    Console.WriteLine("6. Sort the Keys");
    Console.WriteLine("0. Exit");
    Console.Write("Please enter your choice: ");

    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        choice = -1;
    }

    switch (choice)
    {
        case 1:
            PopulateDictionary(Group2Dictionary);
            break;
        case 2:
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                DisplayDictionary(Group2Dictionary);
            break;
        case 3:
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                RemoveKey(Group2Dictionary);
            break;
        case 4:
            AddNewKey(Group2Dictionary);
            break;
        case 5:
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                AppendToKey(Group2Dictionary);
            break;
        case 6:
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                SortKeys(Group2Dictionary);
            break;
        case 0:
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Your selection was not one of the menu options. Please try again.");
            break;
    }

} while (choice != 0);


// ─── Person 2 ───────────────────────────────────────────────
static void PopulateDictionary(Dictionary<string, string> dict)
{
  // ─── Person 2 ───────────────────────────────────────────────
static void PopulateDictionary(Dictionary<string, string> dict)
{
    // Adding a mix of real and made-up restaurants
    string[,] restaurants = {
        { "The Sizzling Skillet", "American Comfort Food" },
        { "Le Petit Bistro", "French" },
        { "Mama Mia's Kitchen", "Italian" },
        { "Dragon's Breath", "Szechuan" },
        { "Taco Temple", "Mexican Street Food" },
        { "The Golden Gyro", "Greek" },
        { "Cyber Cafe 2077", "Futuristic Fusion" },
        { "Ocean's Bounty", "Seafood" }
    };

    for (int i = 0; i < restaurants.GetLength(0); i++)
    {
        string name = restaurants[i, 0];
        string cuisine = restaurants[i, 1];

        if (!dict.ContainsKey(name))
        {
            dict.Add(name, cuisine);
        }
    }

    Console.WriteLine("Dictionary successfully populated with local restaurants!");
}

static void DisplayDictionary(Dictionary<string, string> dict)
{
    Console.WriteLine("\n--- Current Restaurant List ---");
    Console.WriteLine($"{"Restaurant Name",-25} | {"Cuisine Type",-20}");
    Console.WriteLine(new string('-', 50));

    foreach (var entry in dict)
    {
        Console.WriteLine($"{entry.Key,-25} | {entry.Value,-20}");
    }
}


// ─── Person 3 ───────────────────────────────────────────────
static void RemoveKey(Dictionary<string, string> dict)
{
    Console.Write("Enter the name of the restaurant to remove: ");
    string key = Console.ReadLine();

    if (dict.Remove(key))
    {
        Console.WriteLine($"{key} has been removed.");
    }
    else
    {
        Console.WriteLine("Restaurant not found.");
    }
}

static void AddNewKey(Dictionary<string, string> dict)
{
    Console.Write("Enter new restaurant name: ");
    string name = Console.ReadLine();
    
    if (dict.ContainsKey(name))
    {
        Console.WriteLine("That restaurant already exists.");
        return;
    }

    Console.Write("Enter cuisine type: ");
    string cuisine = Console.ReadLine();

    dict.Add(name, cuisine);
    Console.WriteLine("New restaurant added successfully.");
}
}

static void DisplayDictionary(Dictionary<string, string> dict)
{
    // Person 2 writes code here
}


// ─── Person 3 ───────────────────────────────────────────────
static void RemoveKey(Dictionary<string, string> dict)
{
    // Person 3 writes code here
}

static void AddNewKey(Dictionary<string, string> dict)
{
    // Person 3 writes code here
}


// ─── Person 4 ───────────────────────────────────────────────
static void AppendToKey(Dictionary<string, string> dict)
{
    Console.Write("Enter the key you want to update: ");
    string key = Console.ReadLine();

    if (dict.ContainsKey(key))
    {
        Console.Write("Enter the value to append: ");
        string newValue = Console.ReadLine();

        dict[key] = dict[key] + ", " + newValue;
        Console.WriteLine("Value added successfully.");
    }
    else
    {
        Console.WriteLine("Key not found.");
    }
}
static void SortKeys(Dictionary<string, string> dict)
{
    var sortedKeys = dict.Keys.OrderBy(k => k);

    Console.WriteLine("Sorted keys:");
    foreach (var key in sortedKeys)
    {
        Console.WriteLine(key + ": " + dict[key]);
    }
}
