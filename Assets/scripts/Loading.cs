using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public GameObject[] Characters;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectCharacter");
        for(int i =0 ; i<Characters.Length ; i++){
            Characters[i].SetActive(false);
        }
        Characters[selectedCharacter].SetActive(true);

    }

}
