static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        if (speed == 0){
            return 0;
        }
        if (speed >= 1 && speed <= 4){
            return 1;
        }
        if (speed >= 5 && speed <= 8){
            return 0.9;
        }
        if (speed == 9){
            return 0.8;
        }
        else{
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        if (speed == 0){
            return 0;
        }
        if (speed >= 1 && speed <= 4){
            return (double)(221 * speed);
        }
        if (speed >= 5 && speed <= 8){
            return (double)(221 * speed * 0.9);
        }
        if (speed == 9){
            return (double)(221 * speed * 0.8);
        }
        else{
            return (double)(221 * speed * 0.77);
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        if (speed == 0){
            return (int)0;
        }
        if (speed >= 1 && speed <= 4){
            return (int)(221 * speed ) / 60;
        }
        if (speed >= 5 && speed <= 8){
            return (int)(221 * speed * 0.9) / 60;
        }
        if (speed == 9){
            return (int)(221 * speed * 0.8) / 60;
        }
        else{
            return (int)(221 * speed * 0.77) / 60;
        }
    }
}
