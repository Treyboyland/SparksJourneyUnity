using System;
using UnityEngine;

[Serializable]
public struct RobotAndAbility
{
    public Robot Robot;
    public AbilityType Ability;
}

[Serializable]
public struct DataLogPickupData
{
    public DataLog DataLog;
    public Vector3 PickupPosition;
}