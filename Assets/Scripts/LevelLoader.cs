using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    List<Scene> gameLevels;

[SerializeField]
LevelButton buttonPrefab;

[SerializeField]
GridLayout buttonHolder;



    void Start()
{
CreateButtons();
}

void CreateButtons()
{
for (int i = 0; i < gameLevels.Count ; i++)
{
var button = Instantiate(buttonPrefab) as LevelButton;

button.Index = i;
button.SetParent(buttonHolder.transform);
button.SceneToLoad = gameLevels[i];
}
}
}