namespace SkytapSharp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SkytapClient("ckittel", "AN8uyQZAXD/2;4CHAC");

            // Scratch pad for trying out the client
            var result = client.GetConfiguration("782260");
            System.Console.WriteLine(result.Name);

        }
    }
}
