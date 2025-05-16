using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
[SerializeField]
string sceneToLoad;

public void LoadScene()
{
SceneManager.LoadScene(sceneToLoad,LoadSceneMode.Single);
}

public void LoadScene(Scene scene)
{
SceneManager.LoadScene(scene,LoadSceneMode.Single);
}

public void LoadScene(string scene)
{
SceneManager.LoadScene(scene,LoadSceneMode.Single);
}
}