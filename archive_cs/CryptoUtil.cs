using System.Text;
public static class CryptoUtil
{
    public static string Encrypt(string t){ return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(t)); }
}
