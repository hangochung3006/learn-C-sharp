public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
         string[] phoneNumberTach = phoneNumber.Split('-');
         return (phoneNumberTach[0] == "212", phoneNumberTach[1] == "555", phoneNumberTach[2]);
        
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
        
}
