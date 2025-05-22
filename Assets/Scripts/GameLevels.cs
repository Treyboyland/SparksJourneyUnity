using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameLevels", menuName = "Scriptable Objects/Game Levels")]
public class GameLevels : ScriptableObject
{
    [SerializeField]
    List<Scene> gameLevels;

    public List<Scene> Levels => gameLevels;
}