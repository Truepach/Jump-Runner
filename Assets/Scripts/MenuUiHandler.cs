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


  /*  private void Awake()
    {
        LoadSelectedCharacter loadSelectedCharacter = gameObject.AddComponent<LoadSelectedCharacter>();
        loadSelectedCharacter.Start();
    } */
    /// <summary>
    /// On the Character Select Scene this will select FarmerPlayer character 
    /// And will load Game Scene
    /// </summary>
    public void SelectFarmer()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Farmer");
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// On the Character Select Scene this will select NursePlayer character 
    /// And will load Game Scene
    /// </summary>

    public void SelectNurse()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Nurse");
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// On the Character Select Scene this will select BuilderPlayer character 
    /// And will load Game Scene
    /// </summary>

    public void SelectBuilder()
    {
        PlayerPrefs.SetString("SelectedCharacter", "Builder");
        SceneManager.LoadScene(2);
    }
}
