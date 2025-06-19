using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {

            // Write "Enter the item number of an appliance: "
            Console.Write("Enter the item number of an appliance: ");


            // Create long variable to hold item number
            long itemNumber;


            // Get user input as string and assign to variable.
            string? itemInput = Console.ReadLine();


           // Convert user input from string to long and store as item number variable.
           if(!long.TryParse(itemInput, out itemNumber)) 
            {
                Console.WriteLine("Invalid Item number.");
                return; 
            }


            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;

                    // Break out of loop (since we found what need to)
                    break;
                }

            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }

            // Otherwise (appliance was found)
            else
            {
                // Test found appliance is available
                if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();
                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out.");
                }
                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.Write("Enter brand to search for:");


            // Create string variable to hold entered brand
            string? brand;


            // Get user input as string and assign to variable.
            brand = Console.ReadLine();


            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();


            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand == brand)
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);
                }
            }

           
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");


            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");


            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");


            // Write "Enter number of doors: "
            Console.Write("Enter number of doors: ");


            // Create variable to hold entered number of doors
            int inputDoors;


            // Get user input as string and assign to variable 
            string? input = Console.ReadLine();


            // Convert user input from string to int and store as number of doors variable. (L94-L99)
            if (!int.TryParse(input, out inputDoors))
            {
                Console.WriteLine("Invalid input. Returning to menu.");
                return;
            }


            // Create list to hold *found* Appliance objects
            List<Appliance> found = new List<Appliance>();


            // Iterate/loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                // Down cast Appliance to Refrigerator
                if (appliance is Refrigerator refrigerator)
                {
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (inputDoors == 0 || refrigerator.Doors == inputDoors)
                    {
                        // Add current appliance in list to found list
                        found.Add(refrigerator);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");


            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");


            // Write "Enter grade:"
            Console.Write("Enter grade:");


            // Get user input as string and assign to variable
            string? gradeInput = Console.ReadLine();


            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;


            // Test input is "0"
            if (gradeInput == "0")
            {
                // Assign "Any" to grade
                grade = "Any";
            }


            // Test input is "1"
            else if (gradeInput == "1")
            {
                // Assign "Residential" to grade
                grade = "Residential";
            }


            // Test input is "2"
            else if (gradeInput == "2")
            {
                // Assign "Commercial" to grade
                grade = "Commercial";
            }

            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");


                // Return to calling (previous) method
                return;
            }


            // Write "Possible options:"
            Console.WriteLine("Possible options: ");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");


            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");

            // Write "Enter voltage:"
            Console.Write("Enter voltage:");

            // Get user input as string
            string? voltageInput = Console.ReadLine();


            // Create variable to hold voltage
            int voltage;


            // Test input is "0"
            if (voltageInput == "0")
            {
                {
                    // Assign 0 to voltage
                    voltage = 0;
                }
            }


            // Test input is "1"
            else if (voltageInput == "1")
            {
                {
                    // Assign 18 to voltage
                    voltage = 18;
                }
            }


            // Test input is "2"
            else if (voltageInput == "2")
            {
                {
                    // Assign 24 to voltage
                    voltage = 24;

                }
            }


            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");


                // Return to calling (previous) method
                return;
            }


            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Check if current appliance is vacuum
                // Down cast current Appliance to Vacuum object
                if (appliance is Vacuum vacuum)
                {
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if ((grade == "Any" || vacuum.Grade == grade) && (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        // Add current appliance in list to found list
                        found.Add(vacuum);
                    }
                }
            }


            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");


            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");



            // Write "Enter room type:"
            Console.Write("Enter room type:");


            // Get user input as string and assign to variable
            string? input = Console.ReadLine();


            // Create character variable that holds room type
            char roomType;


            // Test input is "0"
            if (input == "0")
            {
                // Assign 'A' to room type variable
                roomType = 'A';
            }


            // Test input is "1"
            else if (input == "1")
            {
                // Assign 'K' to room type variable
                roomType = 'K';
            }


            // Test input is "2"
            else if (input == "2")
            {
                // Assign 'W' to room type variable
                roomType = 'W';
            }


            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");


                // Return to calling method
                return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();


            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test current appliance is Microwave
                // Down cast Appliance to Microwave
                if (appliance is Microwave microwave)
                {
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");


            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");


            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");


            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");


            // Write "Enter sound rating:"
            Console.Write("Enter sound rating:");


            // Get user input as string and assign to variable
            string? input = Console.ReadLine();


            // Create variable that holds sound rating
            string soundRating;


            // Test input is "0"
            if (input == "0")
            {
                // Assign "Any" to sound rating variable
                soundRating = "Any";
            }

            // Test input is "1"
            else if (input == "1")
            {
                // Assign "Qt" to sound rating variable
                soundRating = "Qt";
            }


            // Test input is "2"
            else if (input == "2")
            {
                // Assign "Qr" to sound rating variable
                soundRating = "Qr";
            }


            // Test input is "3"
            else if (input == "3")
            {
                // Assign "Qu" to sound rating variable
                soundRating = "Qu";
            }


            // Test input is "4"
            else if (input == "4")
            {
                // Assign "M" to sound rating variable
                soundRating = "M";
            }


            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");

                // Return to calling method
                return;

            }


            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();


            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                // Down cast current Appliance to Dishwasher
                if (appliance is Dishwasher dishwasher)
                {
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        // Add current appliance in list to found list
                        found.Add(dishwasher);
                    }
                }
            }


            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");


            // Write "0 - Any"
            Console.WriteLine("0 - Any");


            // Write "1 – Refrigerators"
            Console.WriteLine("1 – Refrigerators");


            // Write "2 – Vacuums"
            Console.WriteLine("2 – Vacuums");


            // Write "3 – Microwaves"
            Console.WriteLine("3 – Microwaves");


            // Write "4 – Dishwashers"
            Console.WriteLine("4 – Dishwashers");


            // Write "Enter type of appliance:"
            Console.Write("Enter type of appliance:");

            // Get user input as string and assign to appliance type variable
            string? applianceInput = Console.ReadLine();


            // Write "Enter number of appliances: "
            Console.Write("Enter number of appliances: ");


            // Get user input as string and assign to variable
            string? numberInput = Console.ReadLine();


            // Convert user input from string to int

            int applianceType;
            int num;
            

            if (!int.TryParse(applianceInput, out applianceType) || applianceType < 0 || applianceType > 4)
            {
                Console.WriteLine("Invalid appliance type.");
                return;
            }
            if (!int.TryParse (numberInput, out num) || num <= 0)
            {
                Console.WriteLine("Invalid appliance number.");
                return;
            }


            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance> { };


            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {

                // Test inputted appliance type is "0"
                if (applianceType == 0)
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);
                }

                // Test inputted appliance type is "1"
                else if (applianceType == 1) 
                {
                    // Test current appliance type is Refrigerator
                    if (appliance is Refrigerator)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }


                // Test inputted appliance type is "2"
                else if (applianceType == 2)
                {
                    // Test current appliance type is Vacuum
                    if (appliance is Vacuum) 
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }

                // Test inputted appliance type is "3"
                else if (applianceType == 3)
                {
                    // Test current appliance type is Microwave
                    if (appliance is Microwave)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }


                // Test inputted appliance type is "4"
                else if (applianceType == 4)
                {
                    // Test current appliance type is Dishwasher
                    if (appliance is Dishwasher)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }


            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, num);

        }
    }
}
