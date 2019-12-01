using System;
using System.Collections.Generic;
using System.Text;

namespace fininex
{
    class Income
    {
        public void amount(string incomeAmountTemp)
        {
            Logger logging = new Logger();
            logging.data(" + ", $"income amount: {incomeAmountTemp}");
        }
    }
}
