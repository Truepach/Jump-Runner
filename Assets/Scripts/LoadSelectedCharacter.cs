using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectedCharacter : MonoBehaviour
{
    public static GameObject selectedCharacter;
    public GameObject farmerPrefab;
    public GameObject nursePrefab;
    public GameObject builderPrefab;
    public string character;

    public void Start()
    {
        string selectedCharacterString = PlayerSelectedData.instance.GetSelectedCharacter();

        if (selectedCharacterString == "Farmer")
        {
            Vector3 startPos = farmerPrefab.GetComponent<FarmerPlayer>().PlayerStartPosition();
            Quaternion startRotation = farmerPrefab.GetComponent<FarmerPlayer>().PlayerStartRotation();
            selectedCharacter = Instantiate(farmerPrefab, startPos, startRotation);
        }
        else if (selectedCharacterString == "Nurse")
        {
            Vector3 startPos = nursePrefab.GetComponent<NursePlayer>().PlayerStartPosition();
            Quaternion startRotation = nursePrefab.GetComponent<NursePlayer>().PlayerStartRotation();
            selectedCharacter = Instantiate(nursePrefab, startPos, startRotation);
        }
        else if (selectedCharacterString == "Builder")
        {
            Vector3 startPos = builderPrefab.GetComponent<BuilderPlayer>().PlayerStartPosition();
            Quaternion startRotation = builderPrefab.GetComponent<BuilderPlayer>().PlayerStartRotation();
            selectedCharacter = Instantiate(builderPrefab, startPos, startRotation);
        }
        else
        {
            Debug.LogError("No selected character found in PlayerSelectedData.");
        }

        character = selectedCharacterString;
    }
}
