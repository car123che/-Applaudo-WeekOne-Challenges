namespace FacebookPost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> namesList = new List<string>();
            namesList = AskNames();
            DisplayMessage(namesList);
        }

        static List<string> AskNames()
        {
            List<string> namesList = new List<string>();
            string name;
            
            do
            {
                Console.Write("Type a name or press enter to finish: ");
                name = Console.ReadLine();
                namesList.Add(name);
            } while ( !String.IsNullOrWhiteSpace(name));

            return namesList;
        }

        static void DisplayMessage(List<string> namesList)
        {
            int namesListSize = namesList.Count - 1 ;

            switch (namesListSize)
            {   
                case 0:
                    {
                        Console.WriteLine("");
                        break;
                    }
                case 1:
                    {
                        string name = namesList[0];
                        Console.WriteLine("{0} likes your post", name);
                        break;
                    }
                case 2:
                    {
                        string nameOne = namesList[0];
                        string nameTwo = namesList[1];
                        Console.WriteLine("{0} and {1} like your post", nameOne, nameTwo);
                        break;
                    }
                default:
                    {
                        string nameOne = namesList[0];
                        string nameTwo = namesList[1];
                        Console.WriteLine("{0}, {1} and {2} others like your post", nameOne, nameTwo, namesListSize - 2);
                        break;
                    }
            }
        }
    }
}