namespace Exercises._8ValueTypes
{
    public class House
    {
        public House(string address, int numberOfWindows)
        {
            Address = address;
            NumberOfWindows = numberOfWindows;
        }

        public int NumberOfWindows { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Address: {Address}, number of windows: {NumberOfWindows}";
        }

    }
}
