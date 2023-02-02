using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUiHandler : MonoBehaviour
{

    public void CharacterSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);    
    }

    /// <summary>
    /// Quits the application.
    /// </summary>
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#elif UNITY_WEBGL
        Application.OpenURL("https://play.unity.com/u/Truepach");
#else
        Application.Quit();
#endif
    }

}
