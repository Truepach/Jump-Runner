using UnityEngine;

public class PlayerSelectedData : MonoBehaviour
{
    public static PlayerSelectedData instance;
    public string selectedCharacter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSelectedCharacter(string character)
    {
        selectedCharacter = character;
    }

    public string GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}