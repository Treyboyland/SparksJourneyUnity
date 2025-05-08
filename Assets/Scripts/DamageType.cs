using UnityEngine;

[CreateAssetMenu(fileName = "DamageType", menuName = "Scriptable Objects/DamageType")]
public class DamageType : ScriptableObject
{
    [SerializeField]
    string damageName;

    public string DamageName { get => damageName; }
}
