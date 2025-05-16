using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{
[SerializeField]
int currentLevel;

[SerializeField]
int maxUnlockedLevel;

public int CurrentLevel {get => currentLevel;}

static LevelTracker _instance;

void Awake()
{
if(_instance != null && this != _instance)
{
Destroy(gameObject);
return;
}

_instance = this;
DontDestroyOnLoad(gameObject);
}

public void IncreaseLevel()
{
currentLevel ++;
if(currentLevel > maxLevel)
{
maxUnlockedLevel = currentLevel;
}
}

public void SetLevel(int level)
{
currentLevel = level;
if(currentLevel > maxLevel)
{
maxUnlockedLevel = currentLevel;
}
}
}