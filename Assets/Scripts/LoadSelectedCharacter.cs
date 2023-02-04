using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectedCharacter : MonoBehaviour
{
    public static GameObject selectedCharacter;
    public GameObject farmerPrefab;
    public GameObject nursePrefab;
    public GameObject builderPrefab;

    public void Start()
    {
        string selectedCharacterString = PlayerPrefs.GetString("SelectedCharacter");

        if (selectedCharacterString == "Farmer")
        {
            FarmerPlayer farmerPlayer = GetComponent<FarmerPlayer>();
            Vector3 startPos = farmerPlayer.PlayerStartPosition();
            Quaternion startRotation = farmerPlayer.PlayerStartRotation();
            selectedCharacter = Instantiate(farmerPrefab, startPos, startRotation);
        }
        else if (selectedCharacterString == "Nurse")
        {
            NursePlayer nursePlayer = GetComponent<NursePlayer>();
            Vector3 startPos = nursePlayer.PlayerStartPosition();
            Quaternion startRotation = nursePlayer.PlayerStartRotation();
            selectedCharacter = Instantiate(nursePrefab, startPos, startRotation);
        }
        else if (selectedCharacterString == "Builder")
        {
            BuilderPlayer builderPlayer = GetComponent<BuilderPlayer>();
            Vector3 startPos = builderPlayer.PlayerStartPosition();
            Quaternion startRotation = builderPlayer.PlayerStartRotation();
            selectedCharacter = Instantiate(builderPrefab, startPos, startRotation);
        }
        else
        {
            Debug.LogError("No selected character found in PlayerPrefs.");
        }
    }
}