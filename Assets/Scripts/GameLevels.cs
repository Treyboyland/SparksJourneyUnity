using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="GameLevels",menuName="ScriptableObjects/Game Levels"]
public class GameLevels: ScriptableObject
{
[SerializeField]
List<Scene> gameLevels;

public List<Scene> GameLevels => gameLevels;
}