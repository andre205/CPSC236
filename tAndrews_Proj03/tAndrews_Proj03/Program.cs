using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace tAndrews_Proj03
{
    class Program
    {
        //list that records will be added to
        static List<Record> records = new List<Record>();
        static void Main(string[] args)
        {
            //Calorie tracker program

            //read data from file - I could not get this part working. I could not find a way to retrieve my Record objects from the text file. This current method
            //only reads strings from the file and adds them to an array. The program still works, you just need to add records manually.
            
            //string[] recordsarray = File.ReadAllLines("records.txt");
            //recordsarray.ToList();
            //Console.WriteLine("Successfully loaded data from file: ");

            //Options menu. Uses tryparse to check for integer responses. Exectutes corresponding method based on user response.
            bool running = true;
            while (running)
                {               
                Console.WriteLine("Would you like to: \n 1. Add a record \n 2. Remove a record \n 3. Display past records \n 4. Exit");
                int z;
                string response = Console.ReadLine();
                if (int.TryParse(response, out z))
                {
                    if (z == 1)
                    {
                        Console.WriteLine("Add record...");
                        addRecord();
                    }

                    if (z == 2)
                    {
						removeRecord();
                    }

                    if (z == 3)
                    {
                        Console.WriteLine("Displaying records... \n");
                        printList();
                    }

                    if (z == 4)
                    {
                        Console.WriteLine("Exiting");
                        //writes to file before exiting
                        writeToFile();
                        running = false;
                    }

                }

                else
                {
                    Console.WriteLine("You did not enter a valid response! Try again.");
                }

            }

        }

        //Add record method using Record object
        public static void addRecord()
        {
            //Had to create a string variable to later convert to an int
            String entry3 = "";

            Record date = new Record();
            Record food = new Record();
            Record calories = new Record();

            //Variables to keep track of what has been answered
            bool unen1 = true;
            bool unen2 = true;
            bool unen3 = true;

            bool entering = true;
            while (entering)
            {
                if (unen1 == true)
                {
                    //I kept the date input as a string so it can be represented using month names and numbers
                    Console.WriteLine("Enter the date.");
                    date.date = Console.ReadLine();
                    unen1 = false;
                }
				
				if (unen2 == true && unen1 == false)
				{
					Console.WriteLine("Enter the name of the food.");
                    food.food = Console.ReadLine();
                    unen2 = false;					
				}
				
				if (unen3 == true && unen1 == false && unen2 == false)
				{
                    //calorie input is run through tryparse to insure it is a number
					int intentry3;
					Console.WriteLine("Enter the amount of calories consumed.");
					entry3 = Console.ReadLine();
					if (int.TryParse(entry3, out intentry3))
					{
                        calories.calories = intentry3;
						unen3 = false; 
					}
					else
					{
						Console.WriteLine("You did not enter a number. Try again.");
					}
					
				if (unen1 == false && unen2 == false && unen3 == false)
				{
                    //after all 3 questions are answered, creates a new Record object with the information
					records.Add(date);
                    records.Add(food);
                    records.Add(calories); 
                 
                    Console.WriteLine("Successfully added record.");
					entering = false;
                    
				}
					
				}
	  
            }

        }

        //Remove record method. Displays numbered records and allows you to choose which to delete. Deleting removes it from the list
        public static void removeRecord()
        {
			bool removing = true;
			while (removing)
			{
				Console.WriteLine("Please select a record to remove. \n");

                printList();
					
                //user inputs a number from the display list, and that number is removed from the list using.RemoveAt ( -1 accounts for indexing)		
				int selectionint;
				String selection = Console.ReadLine();
				if (int.TryParse(selection, out selectionint))
				{
					records.RemoveAt(selectionint - 1);
                    removing = false;
				}
				else
				{
					Console.WriteLine("You did not enter a valid response. Try again.");
				}						
			}

        }

        //printList method iterates through list and prints formatted records. (I had to count by 3s because each record object was appended to the list)
        public static void printList()
        {
            int counter = 0;
            int indexer = 0;

            foreach (Record r in records)
            {
                counter += 1;
            }

            for (int i = 0; i < counter; i += 3)
            {
                indexer += 1;
                Console.WriteLine(indexer + ".    Date: " + records[i].date + "    |   Food: " + records[i + 1].food + "    |   Calories: " + records[i + 2].calories + "\n");
            }
        }

        //Converts each object in the list to a string and writes it to a file.
        public static void writeToFile()
        {
            String printrec = "";
            foreach (Record rec in records)
            {
                printrec = rec.ToString();
                File.WriteAllText("records.txt", printrec);
            }
        }

        //Record object using struct
        public struct Record
        {
            public String date;
            public String food;
            public int calories;

            public Record(String date, String food, int calories)
            {
                this.date = date;
                this.food = food;
                this.calories = calories;
            }           
        }

    }
}
