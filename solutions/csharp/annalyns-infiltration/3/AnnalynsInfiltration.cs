static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
    
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => !(!knightIsAwake && !archerIsAwake && !prisonerIsAwake);

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !(archerIsAwake || !prisonerIsAwake);

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        if(petDogIsPresent)
            {
            return !(archerIsAwake);
            }
        else
            {
            return (!archerIsAwake && !knightIsAwake && prisonerIsAwake);
            }

    }
    
}
