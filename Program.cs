// COP2360 - Group 2 Dictionary Project
// This program lets the user manage a dictionary of restaurants and cuisine types

// Create the dictionary to store restaurant names and cuisine types
Dictionary<string, string> Group2Dictionary = new Dictionary<string, string>();

int choice; // stores the users menu pick

// Keep the menu running until the user picks 0 to exit
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

    // if the user types something thats not a number, set choice to -1
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        choice = -1;
    }

    // switch checks what number the user picked and runs the right method
    switch (choice)
    {
        case 1: // task 1a - populate the dictionary
            PopulateDictionary(Group2Dictionary);
            break;

        case 2: // task 1b - display contents using foreach enumeration
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                DisplayDictionary(Group2Dictionary);
            break;

        case 3: // task 1c - remove a key
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                RemoveKey(Group2Dictionary);
            break;

        case 4: // task 1d - add a new key and value
            AddNewKey(Group2Dictionary);
            break;

        case 5: // task 1e - append a value to an existing key
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                AppendToKey(Group2Dictionary);
            break;

        case 6: // task 1f - sort the keys alphabetically
            if (Group2Dictionary.Count == 0)
                Console.WriteLine("The dictionary is empty. Please add data.");
            else
                SortKeys(Group2Dictionary);
            break;

        case 0:
            Console.WriteLine("Goodbye!");
            break;

        // catches anything that isnt a valid menu option
        default:
            Console.WriteLine("Your selection was not one of the menu options. Please try again.");
            break;
    }

} while (choice != 0);


// task 1a - adds restaurant names and cuisine types to the dictionary
// we check for duplicates first so we dont get an error adding the same key twice
static void PopulateDictionary(Dictionary<string, string> dict)
{
    // 2D array with restaurant names and cuisine types
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

    // loop through the array and add each one to the dictionary
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

// task 1b - displays all entries using foreach to loop through the dictionary
static void DisplayDictionary(Dictionary<string, string> dict)
{
    Console.WriteLine("\n--- Current Restaurant List ---");
    Console.WriteLine($"{"Restaurant Name",-25} | {"Cuisine Type",-20}");
    Console.WriteLine(new string('-', 50));

    // foreach is one of the three enumeration methods from module 7
    foreach (var entry in dict)
    {
        Console.WriteLine($"{entry.Key,-25} | {entry.Value,-20}");
    }
}

// task 1c - asks the user for a restaurant name and removes it if it exists
static void RemoveKey(Dictionary<string, string> dict)
{
    Console.Write("Enter the name of the restaurant to remove: ");
    string key = Console.ReadLine() ?? ""; // ?? "" prevents a null error

    if (dict.Remove(key))
    {
        Console.WriteLine($"{key} has been removed.");
    }
    else
    {
        Console.WriteLine("Restaurant not found.");
    }
}

// task 1d - lets the user add a brand new restaurant and cuisine to the dictionary
static void AddNewKey(Dictionary<string, string> dict)
{
    Console.Write("Enter new restaurant name: ");
    string name = Console.ReadLine() ?? "";

    // make sure the key doesnt already exist
    if (dict.ContainsKey(name))
    {
        Console.WriteLine("That restaurant already exists.");
        return;
    }

    Console.Write("Enter cuisine type: ");
    string cuisine = Console.ReadLine() ?? "";

    dict.Add(name, cuisine);
    Console.WriteLine("New restaurant added successfully.");
}

// task 1e - adds extra info to an existing restaurants cuisine value
static void AppendToKey(Dictionary<string, string> dict)
{
    Console.Write("Enter the key you want to update: ");
    string key = Console.ReadLine() ?? "";

    if (dict.ContainsKey(key))
    {
        Console.Write("Enter the value to append: ");
        string newValue = Console.ReadLine() ?? "";

        // tack the new value onto the end of the existing one
        dict[key] = dict[key] + ", " + newValue;
        Console.WriteLine("Value added successfully.");
    }
    else
    {
        Console.WriteLine("Key not found.");
    }
}

// task 1f - sorts the keys a to z using OrderBy and prints them with their values
static void SortKeys(Dictionary<string, string> dict)
{
    var sortedKeys = dict.Keys.OrderBy(k => k);

    Console.WriteLine("\nSorted keys:");
    foreach (var key in sortedKeys)
    {
        Console.WriteLine(key + ": " + dict[key]);
    }
}