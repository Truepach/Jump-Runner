using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUiHandler : MonoBehaviour
{

    /// <summary>
    /// Loads the Character Select Scene.
    /// </summary>
    public void CharacterSelect()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Loads the Title Scene.
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
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

    public void SelectFarmer()
    {
        //SpawnFarmer()
        SceneManager.LoadScene(2);
    }

}
