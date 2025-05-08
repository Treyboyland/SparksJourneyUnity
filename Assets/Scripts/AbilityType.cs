using UnityEngine;

[CreateAssetMenu(fileName = "AbilityType", menuName = "Scriptable Objects/AbilityType")]
public class AbilityType : ScriptableObject
{
    [SerializeField]
    string abilityName;

    [SerializeField]
    Sprite icon;

    [SerializeField]
    bool isPassive;

    public string AbilityName { get => abilityName; }
    public Sprite Icon { get => icon; }
    public bool IsPassive { get => isPassive; }
}
