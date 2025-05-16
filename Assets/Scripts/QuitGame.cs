using UnityEngine;

public class QuitGameHandler: MonoBehaviour 
{


  public void QuitGame()
{
#if UNITY_WEBGL
//Do Nothing
#elif UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;
#else
Application.Quit();
#endif
}
}