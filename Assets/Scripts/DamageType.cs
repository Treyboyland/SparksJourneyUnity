using UnityEngine;

[CreateAssetMenu(fileName = "DamageType-", menuName = "Scriptable Objects/Damage Type")]
public class DamageType : ScriptableObject
{
    [SerializeField]
    string damageName;

    public string DamageName { get => damageName; }
}
