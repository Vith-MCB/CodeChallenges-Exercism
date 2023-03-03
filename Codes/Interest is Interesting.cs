/*
 * Instructions
In this exercise you'll be working with savings accounts.
Each year, the balance of your savings account is updated 
based on its interest rate. The interest rate your bank gives
you depends on the amount of money in your account (its balance):

3.213% for a negative balance (balance gets more negative).
0.5% for a positive balance less than 1000 dollars.
1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
2.475% for a positive balance greater than or equal to 5000 dollars.
You have four tasks, each of which will deal your balance and its interest rate.

*/

using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        //Implementing conditions
        if(balance < 0) { return 3.213f; }
        else if(balance >= 0 && balance < 1000) { return 0.5f; }
        else if(balance >= 1000 && balance < 5000) { return 1.621f; }
        else { return 2.475f; }
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)(InterestRate(balance)/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int count = 0;
        while(balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            count++;
        }
        return count;
    }
}
