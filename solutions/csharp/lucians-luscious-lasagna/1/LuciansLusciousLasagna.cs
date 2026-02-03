class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        int result = 40;
        return result;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int thoiGianDaNuong){
        int result = 40 - thoiGianDaNuong;
        return result;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int soLop){
        int result = soLop * 2;
        return result;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int soLop, int thoiGianDaNuong){
        int result = soLop * 2 + thoiGianDaNuong;
        return result;
    }
}
