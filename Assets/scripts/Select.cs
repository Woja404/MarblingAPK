using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{

    public GameObject[] characters;
    public int selectedCharacter =0;

    public void Start(){
        int hs = PlayerPrefs.GetInt("highscore");
        if (hs<500){
            GameObject[] temp = new GameObject[1];
            for(int i=0 ; i<1;i++){
                temp[i] = characters[i];
            }
            characters = temp;
        }
        else if (hs<1500){
            GameObject[] temp = new GameObject[2];
            for(int i=0 ; i<2;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<3000){
            GameObject[] temp = new GameObject[3];
            for(int i=0 ; i<3;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<6000){
            GameObject[] temp = new GameObject[4];
            for(int i=0 ; i<4;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<12000){
            GameObject[] temp = new GameObject[5];
            for(int i=0 ; i<5;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<20000){
            GameObject[] temp = new GameObject[6];
            for(int i=0 ; i<6;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<40000){
            GameObject[] temp = new GameObject[7];
            for(int i=0 ; i<7;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<80000){
            GameObject[] temp = new GameObject[8];
            for(int i=0 ; i<8;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<200000){
            GameObject[] temp = new GameObject[9];
            for(int i=0 ; i<9;i++){
                temp[i] = characters[i];
            }
                    characters = temp;
        }
        else if (hs<250000){
            GameObject[] temp = new GameObject[10];
            for(int i=0 ; i<10;i++){
                temp[i] = characters[i];
            }
            characters = temp;
        }
    }      

    public void NextCharacter(){
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter +1) % characters.Length;
        characters[selectedCharacter].SetActive(true);

    }
    public void PreviousCharacter(){
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter<0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);

    }

    public void StartGame(){
        

        PlayerPrefs.SetInt("selectCharacter", selectedCharacter);
        SceneManager.LoadScene("InGame");

    }
}
