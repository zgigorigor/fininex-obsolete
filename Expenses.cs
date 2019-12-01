using System;
using System.Collections.Generic;
using System.Text;

namespace fininex
{
    class Expenses
    {
        Logger logging = new Logger();
        public string amount(string expenseAmountTemp)
        {
            logging.data(" - ", $"expense amount: {expenseAmountTemp}");
            return expenseAmountTemp;
        }
        public float totalExpenses(string expenseAmountTemp)
        {
            float expenseIncome = float.Parse(expenseAmountTemp);
            float expenseTotal = 0f;
            expenseTotal += expenseIncome;
            return expenseTotal;
        }
    }
}
