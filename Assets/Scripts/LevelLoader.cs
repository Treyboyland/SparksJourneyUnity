using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    GameLevels gameLevels;

    [SerializeField]
    LevelButton buttonPrefab;

    [SerializeField]
    GridLayoutGroup buttonHolder;



    void Start()
    {
        CreateButtons();
    }

    void CreateButtons()
    {
        for (int i = 0; i < gameLevels.Levels.Count; i++)
        {
            var button = Instantiate(buttonPrefab) as LevelButton;

            button.Index = i;
            button.transform.SetParent(buttonHolder.transform);
            button.SceneToLoad = gameLevels.Levels[i];
        }
    }
}