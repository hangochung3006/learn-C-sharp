public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string kyTu){
        int viTri = str.IndexOf(kyTu);
        int doDaiKyTu = kyTu.Length;
        return str.Substring(viTri + doDaiKyTu);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string kyTu1, string kyTu2)
    {
        int doDaiKyTu = str.Length;
        int viTri1 = str.IndexOf(kyTu1);
        int doDaiKyTu1 = kyTu1.Length;
        int viTri2 = str.IndexOf(kyTu2);
        int doDaiKyTuConLai = doDaiKyTu - viTri2;
        return str.Substring(viTri1 + doDaiKyTu1, doDaiKyTu - doDaiKyTuConLai - viTri1 - doDaiKyTu1);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[","]");
 
}