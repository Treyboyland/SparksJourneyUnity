using UnityEngine;

public class DataLog : ScriptableObject 
{
[TextArea]
    [SerializeField]
    string logText;

  public string LogText {get=>logText; }
}