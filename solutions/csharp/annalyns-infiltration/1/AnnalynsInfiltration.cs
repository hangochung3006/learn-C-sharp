static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        return !(!knightIsAwake && !archerIsAwake && !prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        return !(archerIsAwake == true || prisonerIsAwake == false);
    }

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
