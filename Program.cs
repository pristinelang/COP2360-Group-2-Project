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
    // Person 2 writes code here
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
    // Person 4 writes code here
}

static void SortKeys(Dictionary<string, string> dict)
{
    // Person 4 writes code here
}