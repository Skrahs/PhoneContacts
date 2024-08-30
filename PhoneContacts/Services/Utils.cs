namespace PhoneContacts.Services
{
    public static class Utils
    {
        public static string LeggiInput(string messaggio, string valoreDefault = "")
        {
            Console.Write(messaggio);
            string input = Console.ReadLine();
            return string.IsNullOrEmpty(input) ? valoreDefault : input;
        }
    }
}
