using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace WebApplication1.Models
{
    public static class Browser
    {

        public static string MyAlert(string msg)
        {
            return RegisteredFunction.Invoke<string>("MyAlert", msg);
        }
    }
}
