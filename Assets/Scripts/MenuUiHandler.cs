using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MenuUiHandler : MonoBehaviour
{
    private LoadSelectedCharacter loadSelectedCharacter;

    private void Awake()
    {
        loadSelectedCharacter = gameObject.AddComponent<LoadSelectedCharacter>();
        loadSelectedCharacter.Start();
    }

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
#else
        Application.Quit();
#endif
    }

    /// <summary>
    /// On the Character Select Scene this will select FarmerPlayer character 
    /// And will load Game Scene
    /// </summary>
    public void SelectFarmer()
    {
        PlayerSelectedData.instance.SetSelectedCharacter("Farmer");
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// On the Character Select Scene this will select NursePlayer character 
    /// And will load Game Scene
    /// </summary>

    public void SelectNurse()
    {
        PlayerSelectedData.instance.SetSelectedCharacter("Nurse");
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// On the Character Select Scene this will select BuilderPlayer character 
    /// And will load Game Scene
    /// </summary>

    public void SelectBuilder()
    {
        PlayerSelectedData.instance.SetSelectedCharacter("Builder");
        SceneManager.LoadScene(2);
    }
}
