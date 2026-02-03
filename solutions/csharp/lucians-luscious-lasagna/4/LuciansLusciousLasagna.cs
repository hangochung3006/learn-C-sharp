class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
   
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int thoiGianDaNuong) => 40 - thoiGianDaNuong;
      
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int soLop) => soLop * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int soLop, int thoiGianDaNuong) => soLop * 2 + thoiGianDaNuong;
        
}
