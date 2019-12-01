using System;
using fininex;


class Balance
{
    // hendla konačno stanje računa
    Logger logging = new Logger();
    Income income = new Income();
    Expenses expense = new Expenses();

    float incomeTotal = 100f;
    float expenseTotal = 0f;
    

    public float amountTotal(float incomeTotal, float expenseTotal)
    {
        
        float totalAmount = incomeTotal - expenseTotal;
        logging.data(" = ", $"balance: {totalAmount}");
        return totalAmount;
    }
}



class Input
{
    Logger logging = new Logger();
    Income Income = new Income();

    public string UI(bool show)
    {
        string startInput = "Type amount (n.nn): ";
        return startInput;
    }
    public string repeat(bool show)
    {
        string repeatInput = "Input more (y/n))? ";
        return repeatInput;
    }
    
    public float income(string tempAmount)
    {
        Income.amount(tempAmount);
        float amount = float.Parse(tempAmount);
        return amount;
    }
    
}







namespace fininex
{
    class Program
    {
        static void Main(string[] args)
        {
            string subStr = ".";
// LOGGER START
            Logger logging = new Logger();
            logging.info("!!!", "fininex booting...");

// APP START
            Console.Write("Start fininex? (y/n) ");
            var startApp = Console.ReadLine();
            if (startApp == "n")
            {
                logging.info("???", "start fininex? choice: no");
                Console.WriteLine("Fininex terminated. Goodbye!");
                logging.info("!!!", "finninex closed.");
                return;
            }
            else
            {
                logging.info("???", "start fininex? choice: yes");
                Console.WriteLine("Fininex starting...");
                logging.info("!!!", "finninex started.");
            }

// DATE CHECK
            Console.Write("Use today's date? (y/n) ");
            string dateQ = Console.ReadLine();
            if (dateQ != "n")
            {
                logging.info("???", "today's date? choice: yes");
                DateTime now = DateTime.Now;
                logging.info("INP", $"input for {now.ToString("d")}");
                Console.WriteLine(now.ToString("d"));
            }
            else
            {
                logging.info("???", "today's date? choice: no");
                Console.WriteLine("Starting fininex history mode...");
                logging.info("!!!", "start fininex history mode");
                Console.Write("Please enter date: (YY/MM/DD) ");
                var dateHistory = Console.ReadLine();
                logging.info("INP", $"input for {dateHistory}");
                Console.WriteLine($"Entering data for: {dateHistory}");
            }

// INCOME INPUT
            logging.info("!!!", "starting income input");
            Input input = new Input();
            bool startIncome;
            Console.Write("Would you like to input income amount? (y/n) ");
            var startInp = Console.ReadLine();
            if (startInp != "n")
            {
                logging.info("???", "income input? choice: yes");
                startIncome = true;
                logging.info("!!!", "started income input");
            }
            else
            {
                logging.info("???", "income input? choice: no");
                startIncome = false;
                logging.info("!!!", "terminating income input.");
                goto ExpenseInput;
            }

            while (startIncome == true)
            {
                Console.Write(input.UI(startIncome));
                input.income(Console.ReadLine());
                Console.Write(input.repeat(startIncome));
                startInp = Console.ReadLine();
                if (startInp == "n")
                {
                    logging.info("???", "more income input? choice: no");
                    startIncome = false;
                    Console.WriteLine("Income recorded. Proceed to expenses input");
                    logging.info("!!!", "finished income input");
                    goto ExpenseInput;
                }
            }

// EXPENSES INPUT
            ExpenseInput:
            logging.info("!!!", "starting expenses input");
            Expenses expense = new Expenses();
            bool startExpenses;
            Console.Write("Would you like to input expense amount? (y/n) ");
            var startExp = Console.ReadLine();
            if (startExp != "n")
            {
                startExpenses = true;
                logging.info("???", "expenses input? choice: yes");
                logging.info("!!!", "started expenses input");
            }
            else
            {
                startExpenses = false;
                logging.info("???", "expenses input? choice: no");
                logging.info("!!!", "terminating expenses input.");
            }

            
            while (startExpenses == true)
            {
                Console.Write("Input your expendure (n.nn): ");
                var tempExpenseInput1 = Console.ReadLine();
                if (tempExpenseInput1.Contains(subStr))
                {
                    expense.amount(tempExpenseInput1);
                }
                else
                {
                    float tempExpenseInput2 = float.Parse(tempExpenseInput1);
                    string expenseFormat = tempExpenseInput2.ToString("0.00");
                    expense.amount(expenseFormat);

                }
                Console.Write("Input another (y/n)? ");
                var anotherExpense = Console.ReadLine();
                if (anotherExpense != "n")
                {
                    startExpenses = true;
                    logging.info("???", "another expense? choice: yes");
                }
                else
                {
                    startExpenses = false;
                    logging.info("???", "another expense? choice: no");
                    logging.info("!!!", "finished expenses input");
                }
                goto End;
            }

// BALANCE CALCULATION

    /*
            logging.info("!!!", "started balance calculation");
            float expensesTotal = expense.totalExpenses();
            Console.WriteLine($"Today's income: {}")
            Console.WriteLine($"Today's total expenses: {expense.totalExpenses()}");

            logging.info("!!!", "finished balance calculation");

    */

// EXIT PROGRAM
        End:
            Console.WriteLine("Fininex closing. Goodbye!");
            logging.info("!!!", "fininex terminated.");
        }
    }
}

/*todo:
 
- change class income data type (string -> float)
- change class expenses data type (string -> float)
- create class Check, to check and convert input to float
- create class Input to handle income and expenses input
*/
/*
 upises iznos
 mora provjerit dal ima lipe
 ako nema, dodaj lipe .00
 pretvori u float
 pribroji totalu
     */