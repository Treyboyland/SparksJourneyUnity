using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RobotStats", menuName = "Scriptable Objects/RobotStats")]
public class RobotStats : ScriptableObject
{
    [SerializeField]
    float speed;
    [SerializeField]
    List<DamageType> invulnerablities;
    [SerializeField]
    float jumpHeight;
    [SerializeField]
    Color robotColor;
    [SerializeField]
    List<AbilityType> abilities;

    public float Speed { get => speed; set => speed = value; }
    public float JumpHeight { get => jumpHeight; set => jumpHeight = value; }
    public List<DamageType> Invulnerablities { get => invulnerablities; set => invulnerablities = value; }
    public List<AbilityType> Abilities { get => abilities; set => abilities = value; }
    public Color RobotColor { get => robotColor; }
}
