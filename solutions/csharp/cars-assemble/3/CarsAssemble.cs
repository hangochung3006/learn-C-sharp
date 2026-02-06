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
    
    public static double ProductionRatePerHour(int speed) => (double)(SuccessRate(speed) * 221 * speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);

}
