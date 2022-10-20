using Proxy;

internal class Program
{
    private static void Main(string[] args)
    {
        InternetService internetService = new InternetService();
        IInternetService proxyInternetService = new ProxyInternetService(internetService);

        internetService.connect("www.facebook.com");
        internetService.connect("www.whatsapp.com");

        proxyInternetService.connect("www.facebook.com");
        proxyInternetService.connect("www.whatsapp.com");
    }
}