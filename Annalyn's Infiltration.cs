using System;

static class QuestLogic {


    /// <summary>
    /// Used to check if fast attack is possible, can be made if the knight is sleeping
    /// </summary>
    /// <param name="knightIsAwake">Used to check if Knight is awake</param>
    /// <returns>True if the attack can be executed or False if it can't</returns>
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    /// <summary>
    /// The group can be spied if at least one of the members is awake
    /// </summary>
    /// <param name="knightIsAwake">Used to check if Knight is awake</param>
    /// <param name="archerIsAwake">Used to check if Archer is awake</param>
    /// <param name="prisonerIsAwake">Used to check if Prisoner is awake</param>
    /// <returns>True if the group can be spied or False if it can't</returns>
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    /// <summary>
    /// Checks if the prisoner can be signaled using sounds, archer must be asleep
    /// </summary>
    /// <param name="archerIsAwake">Used to check if Archer is awake</param>
    /// <param name="prisonerIsAwake">Used to check if Prisoner is awake</param>
    /// <returns>True if the prisioner can be signaled or False if it can't</returns>
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;


    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => prisonerIsAwake && !knightIsAwake && !archerIsAwake || petDogIsPresent && !archerIsAwake;

}
