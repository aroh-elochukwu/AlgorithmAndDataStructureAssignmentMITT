// function call to use vending machine
// accept product price and amount tendered
// calls a function return change to customer and returns a customer greeting message

 string useVendingMachine(int productCost, int amountTendered)
{
    int customerChange = amountTendered - productCost;
    string machineOutput = "";

    if(customerChange > 0)
    {
        Console.WriteLine("Please collect your merchandise");
        machineOutput = string.Format("Please Wait, Dispensing {0} Dollars" , customerChange);

    } else if (customerChange < 0)
    {
        machineOutput = string.Format("You have not tendered enough money for this merchandise");
    }

    // Still to decipher how to delay this function call with a set timeout kinda thing
    Console.WriteLine(tenderCustomerChange(customerChange));


    return  machineOutput ;
}

// accepts amount to return to customer
// from available dispenser drawer returns change customer

string tenderCustomerChange(int customerChange)
{
    Dictionary<string, int> vendingMachineCashDrawer = new Dictionary<string, int>();

    vendingMachineCashDrawer.Add("20 Dollars", 1);
    vendingMachineCashDrawer.Add("10 Dollars", 15);
    vendingMachineCashDrawer.Add("5 Dollars", 15);
    vendingMachineCashDrawer.Add("2 Dollars", 15);
    vendingMachineCashDrawer.Add("1 Dollar", 15);

    int amountToDispense = customerChange;

    //still to review code and stop repetiton of code below

    /*

    string[] dollarBills = new string[] {"20 Dollars", "10 Dollars", "5 Dollars", "2 Dollars", "1 Dollar"};

    foreach (string dollar in dollarBills)
    {
        while (amountToDispense > 20 & vendingMachineCashDrawer["20 Dollars"] > 0)
        {
            amountToDispense = amountToDispense - 20;
            vendingMachineCashDrawer["20 Dollars"] = vendingMachineCashDrawer["20 Dollars"] - 1;
            Console.WriteLine("Dispenses 20 Dollars");
        }

    }
    */

    
    while (amountToDispense  > 20 & vendingMachineCashDrawer["20 Dollars"] > 0  )
    {
        amountToDispense = amountToDispense - 20;
        vendingMachineCashDrawer["20 Dollars"] = vendingMachineCashDrawer["20 Dollars"] -1;
        Console.WriteLine("Dispenses 20 Dollars");  
    }
    while (amountToDispense > 10 & vendingMachineCashDrawer["10 Dollars"] > 0)
    {
        amountToDispense = amountToDispense - 10;
        vendingMachineCashDrawer["10 Dollars"] = vendingMachineCashDrawer["10 Dollars"] - 1;
        Console.WriteLine("Dispenses 10 Dollars");
    }
    while (amountToDispense > 5 & vendingMachineCashDrawer["5 Dollars"] > 0)
    {
        amountToDispense = amountToDispense - 5;
        vendingMachineCashDrawer["5 Dollars"] = vendingMachineCashDrawer["5 Dollars"] - 1;
        Console.WriteLine("Dispenses 5 Dollars");
    }
    while (amountToDispense > 2 & vendingMachineCashDrawer["2 Dollars"] > 0)
    {
        amountToDispense = amountToDispense - 2;
        vendingMachineCashDrawer["2 Dollars"] = vendingMachineCashDrawer["2 Dollars"] - 1;
        Console.WriteLine("Dispenses 2 Dollars");
    }
    while (amountToDispense > 1 & vendingMachineCashDrawer["1 Dollar"] > 0)
    {
        amountToDispense = amountToDispense - 1;
        vendingMachineCashDrawer["1 Dollar"] = vendingMachineCashDrawer["1 Dollar"] - 1;
        Console.WriteLine("Dispenses 1 Dollar");
    }
    
    return "Thanks for your patronage, Enjoy the rest of your day";
}

Console.WriteLine(useVendingMachine(1, 50));