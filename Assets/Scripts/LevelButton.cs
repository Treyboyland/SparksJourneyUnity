using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelButton : MonoBehaviour
{
    [SerializeField]
    Button button;

    [SerializeField]
    TMP_Text textBox;

    [SerializeField]
    GameEventGeneric<Scene> onLoadScene;

    public Scene SceneToLoad { get; set; }

    int index;

    public int Index
    {
        get => index;
        set
        {
            index = value;
            textBox.text = "" + value;
        }
    }

    void Start()
    {
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        LevelTracker.Instance.SetLevel(index);
        onLoadScene.Invoke(SceneToLoad);
    }
}