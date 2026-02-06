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
            return (double)(221 * speed * 1);
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
        double xeMoiPhut = 0;
        if (speed == 0){
            xeMoiPhut = 0;
        }
        if (speed >= 1 && speed <= 4){
            xeMoiPhut = (221 * speed * 1) / 60;
        }
        if (speed >= 5 && speed <= 8){
            xeMoiPhut = (221 * speed * 0.9) / 60;
        }
        if (speed == 9){
            xeMoiPhut = (221 * speed * 0.8) / 60;
        }
        if (speed == 10){
            xeMoiPhut = (221 * speed * 0.77) / 60;
        }
        int xeMoiPhutInt = (int)xeMoiPhut;
        return xeMoiPhutInt;
    }
}
