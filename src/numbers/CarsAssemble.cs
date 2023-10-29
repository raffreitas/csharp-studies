namespace Numbers
{
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            if (speed == 0)
            {
                return 0;
            }
            else if (speed <= 4)
            {
                return 1;
            }
            else if (speed <= 8)
            {
                return 0.9;
            }
            else if (speed == 9)
            {
                return 0.8;
            }
            else
            {
                return 0.77;
            }
        }

        public static double ProductionRatePerHour(int speed)
        {
            double successRate = SuccessRate(speed);
            return speed * 221 * successRate;
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(ProductionRatePerHour(speed) / 60);
        }
    }
}