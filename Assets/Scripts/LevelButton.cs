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

    public Scene SceneToLoad { get; set; }

    public int Index
    {
        set
        {
            textBox.text = "" + value;
        }
    }

    void Start()
    {
        button.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad.buildIndex);
    }
}