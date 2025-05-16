using UnityEngine;

[CreateAssetMenu(fileName = "DataLog-", menuName = "Scriptable Objects/Data Log")]
public class DataLog : ScriptableObject
{
  [TextArea]
  [SerializeField]
  string logText;

  public string LogText { get => logText; }
}