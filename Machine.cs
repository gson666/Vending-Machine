using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using virualproject;


 public class Machine
{
    
    private string _name;
    private int _currentBeverageCount = 0;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private float _price;
    public float Price
    {
        get { return _price; }
        set { _price = value; }
    }
    private decimal _balance = 0;
    

    public decimal Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }
    private const int _maxdrinks = 10;
    public int Maxdrinks
    {
        get { return _maxdrinks; }
    }

    

    public void Adminaccess()
    {
        Machine machine = new Machine();
        machine.AddBeverage(10);
        machine.GetCurrentBeverageCount();
        

        Admin BAR = new Admin("STOLENFRAGG");
        Admin SCOUTER = new Admin("GARNIKAD");
        BAR.Access();
        BAR.GetAdminNumbers();
        BAR.Adminoption(machine);



    }
    
    public void Drinks()
    {
        Beverage beverage = new Beverage();
        beverage.Moresweets();
        GoodBye();
    }
    public void tea()
    {
        Tea tea = new Tea();
        tea.SelectTea();
        prepare();
        GoodBye();
       
    }
    public void coffe()
    {
        Coffee coffee = new Coffee();
        coffee.SelectCoffe();
        prepare();
        GoodBye();
        
        
    }
    public void Shoco()
    {
        Choclate choclate = new Choclate();
        choclate.Selectchoclate();
        prepare();
        GoodBye();
       
        
    }


    public void prepare()
    {
        Console.WriteLine("Adding ingredients..");
        Thread.Sleep(2500);
        Console.WriteLine("Adding hot water..");
        Thread.Sleep(2500);
        Console.WriteLine("stiring..");
    }
    public void RunProgram()
    {
        Welcomeness();
        drinkchoser();
        GoodBye();
        
    }

    
    
   
    
    public void drinkchoser()
    {
        string[] options = { "Coffe", "Tea", "Choclate", "Soft drinks", "EXIT" };
        int index = LoopSelect("Please select option:", false, options);

        switch (index)
        {
            case 0: coffe(); break;
            case 1: tea();  break;
            case 2: Shoco(); break;
            case 3: Drinks(); break;
            case 4: Exit(); break;
            default: break;
                Console.ReadKey();
        }




        static int LoopSelect(string title, bool isShowSelected, params string[] options)
        {
            bool isSelected = false;
            int selectedIndex = 0;
            string color = "--> \x1b[34m";


            Console.WriteLine(title);
            (int left, int top) = Console.GetCursorPosition();

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{(selectedIndex == i ? color : "    ")}{options[i]}\u001b[0m");
                }
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (selectedIndex < options.Length - 1)
                            selectedIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (selectedIndex > 0)
                            selectedIndex--;
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                    default: break;
                }

            }
            if (isShowSelected)
                Console.WriteLine($"You selected {options[selectedIndex]}");
            return selectedIndex;
        }
    }
    public void Welcomeness()
    {
        Console.WriteLine("Designed by hackersgroup^^ ");
        Console.WriteLine("Hello customer! Cash or Creditcard?");
        string[] options = { "Cash", "Credit",  "Exit", "ADMIN MODE" };
        int index = LoopSelect("Please select option:", false, options);

        switch (index)
        {
            case 0: Payingwithcash(); ; break;
            case 1: PayingWithCard(); break;
            case 2: Exit(); break;
                case 3: Adminaccess(); break;
            default:
                break;
                
        }

        static int LoopSelect(string title, bool isShowSelected, params string[] options)
        {
            bool isSelected = false;
            int selectedIndex = 0;
            string color = "--> \x1b[34m";


            Console.WriteLine(title);
            (int left, int top) = Console.GetCursorPosition();

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{(selectedIndex == i ? color : "    ")}{options[i]}\u001b[0m");
                }
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (selectedIndex < options.Length - 1)
                            selectedIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (selectedIndex > 0)
                            selectedIndex--;
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                    default: break;
                }

            }
            if (isShowSelected)
                Console.WriteLine($"You selected {options[selectedIndex]}");
            return selectedIndex;
        }

    }
    public void Payingwithcash()
    {
        decimal[] coins = { 0.10m, 0.50m, 1.00m, 2.00m, 5.00m, 10.00m };
        Console.WriteLine("Machine's accepted coins:");
        foreach (decimal coin in coins)
        {
            string formattedAmount = coin.ToString("C", CultureInfo.CurrentCulture);
            Console.WriteLine(formattedAmount);
        }

        Console.WriteLine("Press enter to add the coin to your balance.Otherwise: write:" + " "+ "EXIT" );

        string input = Console.ReadLine();

        if (input.ToLower() == "exit")
        {
            Console.WriteLine("Transaction cancelled");
            return;
        }

        
        decimal balance = 0;

        while (input != "")
        {
            decimal coinValue;
            bool isValidCoin = decimal.TryParse(input, out coinValue);

            if (isValidCoin && coins.Contains(coinValue))
            {
                balance += coinValue;
                Console.Clear();
                Console.WriteLine($"Added to your balance: {coinValue.ToString("C")}");
                Console.WriteLine($"Updated balance: {balance.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Coins value is not matched, please try again");
            }

            Console.WriteLine("To add another coin press enter. to cancel the transaction write:" + " " + "EXIT");
            input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Transaction cancelled");
                return;
            }
        }

        Console.WriteLine($"Balance: {balance.ToString("C")}");
        // Call the method to choose a beverage and perform the purchase
        drinkchoser();
    }
    private void PayingWithCard()
    {
        bool restartProgram = true;

        while (restartProgram)
        {
            Console.WriteLine("Enter credit card number:");
            string cardNumber = Console.ReadLine();

            // Perform additional validation and security checks on the card number

            Console.WriteLine("Enter expiration month:");
            int expirationMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter expiration year:");
            int expirationYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CVV:");
            string cvv = Console.ReadLine();

            // Perform additional validation and security checks on the CVV

            // Process the payment using the credit card information
            bool paymentSuccessful = ProcessPayment(cardNumber, expirationMonth, expirationYear, cvv);

            if (paymentSuccessful)
            {
                Console.WriteLine("Please wait for the process of receiving the card details");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("Payment successful!");
                _balance+= 10m;
                Console.WriteLine($"Balance: {_balance}₪");
                Thread.Sleep(5000);
                // Perform further actions after successful payment
                restartProgram = false; // Exit the loop and continue with the program
            }
            else
            {
                Thread.Sleep(5000);
                Console.WriteLine("Payment failed. Please check your credit card details and try again.");
                Console.WriteLine("Do you want to try again? (Y/N)");
                string restartInput = Console.ReadLine();

                if (restartInput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    restartProgram = false; // Exit the loop and continue with the program
                }
            }

            Console.Clear();
        }
    }

    protected private void BlockedDetails()
    {
        PayingWithCard();

    }




    private bool ProcessPayment(string cardNumber, int expirationMonth, int expirationYear, string cvv)
    {
        bool paymentSuccessful = (cardNumber.Length == 16 && expirationMonth >= 1 && expirationMonth <= 12 && expirationYear >= DateTime.Now.Year && cvv.Length == 3);
        return paymentSuccessful;
    }
    //protected private void PayingWithCard()
    //{
    //    Console.WriteLine("Enter credit card number:");
    //    string cardNumber = Console.ReadLine();

    //    // Perform additional validation and security checks on the card number

    //    Console.WriteLine("Enter expiration month:");
    //    int expirationMonth = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Enter expiration year:");
    //    int expirationYear = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Enter CVV:");
    //    string cvv = Console.ReadLine();

    //    // Perform additional validation and security checks on the CVV

    //    // Process the payment using the credit card information
    //    bool paymentSuccessful = ProcessPayment(cardNumber, expirationMonth, expirationYear, cvv);

    //    if (paymentSuccessful)
    //    {
    //        Console.WriteLine("Please wait for the process of receiving the card details");
    //        Thread.Sleep(5000);
    //        Console.WriteLine("Payment successful!");
    //        Console.Clear();
    //        _balance+= 10m;
    //        Console.WriteLine($"Balance: {_balance}₪");

    //        // Perform further actions after successful payment
    //    }
    //    else
    //    {
    //        Console.WriteLine("Please wait for the process of receiving the card details");
    //        Thread.Sleep(5000);
    //        Console.WriteLine("Payment failed. Please check your credit card details and try again.");
    //        // Perform further actions for a failed payment
    //    }
    //}

    public void Exit()
    {
        Console.WriteLine("Transaction cancelled");
        Environment.Exit(0);
    }
    public void GoodBye()
    {
        Console.WriteLine("\x1b[34mThank you! We look forward to seeing you again\x1b[0m");
        Environment.Exit(0);
        Console.ReadKey();
    }
    public bool CheckBeverageLimit(int beverageCount)
    {
        const int maxBeverages = 10;
        if (beverageCount <= maxBeverages)
        {
            Console.WriteLine("Beverage limit not exceeded. You can proceed.");
            return true;
        }
        else
        {
            Console.WriteLine("Beverage limit exceeded. Cannot proceed.");
            return false;
        }
    }
    public void AddBeverage(int quantity)
    {
        
        // Add the specified quantity to the current count
        _currentBeverageCount += quantity;

        // Limit the count to the maximum number of beverages (10)
        _currentBeverageCount = Math.Min(_currentBeverageCount, 10);
        if (_currentBeverageCount > 10)
        {
            throw new arguments("limit to 10 beverages");
        }


        Console.WriteLine($"{quantity} beverages added. Total beverages: {_currentBeverageCount}");
    }
    public void RemoveBeverage(int quantity)
    {
        _currentBeverageCount -= quantity;
        if (_currentBeverageCount < 0)
        {
            _currentBeverageCount = 0;
        }
        Console.WriteLine($"Beverages removed:{quantity}");

    }

    public int GetCurrentBeverageCount()
    {
        // Assuming you have a variable to store the current beverage count
        int currentBeverageCount = 0;

        // Retrieve the current beverage count from the class field
        currentBeverageCount = _currentBeverageCount;
        Console.WriteLine($"Current beverages:{currentBeverageCount} ");

        return currentBeverageCount;
    }
    public void RemoveOneBeverage()
    {
        if (_currentBeverageCount > 0)
        {
             _currentBeverageCount--;
            Console.WriteLine($"{_currentBeverageCount} left");
        }
        else
        {
            Console.WriteLine("No beverages available in machine please call admin.");
        }
    }





}