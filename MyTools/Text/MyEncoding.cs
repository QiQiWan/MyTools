using System.Web;
using System.Text;

namespace MyTools.Text
{
    public class MyEncoding
    {
        static public string GetUriStr(string str)
        {
            return HttpUtility.UrlEncode(str, Encoding.UTF8);
        }
        static public string GetGBStr(string UrlStr)
        {
            return HttpUtility.UrlDecode(UrlStr, Encoding.UTF8);
        }

    }
}
