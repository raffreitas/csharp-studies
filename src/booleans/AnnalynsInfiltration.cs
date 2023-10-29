namespace Booleans
{
    class AnnalynsInfiltration
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            return !knightIsAwake;
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            // Se pelo menus um estiver acordado
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            return !archerIsAwake && prisonerIsAwake;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake) || (!knightIsAwake && !archerIsAwake && prisonerIsAwake);
        }
    }
}