namespace Tuples
{
    static class PhoneNumberAnalysis
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] splitted = phoneNumber.Split("-");
            return (splitted[0] == "212", splitted[1] == "555", splitted[2]);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneInfo)
        {
            return phoneInfo.IsFake;
        }

    }
}