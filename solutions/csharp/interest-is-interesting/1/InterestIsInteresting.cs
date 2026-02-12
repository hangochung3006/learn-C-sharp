static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float soLai = 0;
        while (balance < 0)
        {
             soLai = (float)3.213;
             break;
        }
        while (balance < 1000 && balance >= 0)
        {
             soLai = (float)0.5;
             break;
        }
        while (balance >= 1000 && balance < 5000)
        {
             soLai = (float)1.621;
             break;
        }
        while (balance >= 5000)
        {
             soLai = (float)2.475;
             break;
        }    
        return soLai;
    }

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) * balance / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => (decimal)Interest(balance) + balance;

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
         int soNam = 0;
         while (balance < targetBalance)
         {
             balance += Interest(balance);
             soNam++;
         }
         return soNam;
    }
}
