using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selector_script : MonoBehaviour
{
    public GameObject doge;
    public GameObject idle_1;
    public GameObject sour;
    //add for added characters
    private Vector3 CharacterPosition;
    private Vector3 Offscreen;
    private int CharacterInt = 1;
    private SpriteRenderer dogeRender, idle_1Render, sourRender; //add more here if characters added
    private readonly string selectedCharacter = "SelectedCharacter";
    private int index;

    private void Awake()
      
    {
        CharacterPosition = idle_1.transform.position;
        Offscreen = doge.transform.position;
        dogeRender = doge.GetComponent<SpriteRenderer>();
        idle_1Render = idle_1.GetComponent<SpriteRenderer>();
        sourRender = sour.GetComponent<SpriteRenderer>();
        //add for others

    }
 


    public void NextCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                idle_1Render.enabled = false;
                idle_1.transform.position = Offscreen;
                doge.transform.position = CharacterPosition;
                dogeRender.enabled = true;
                CharacterInt++;
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                dogeRender.enabled = false;
                doge.transform.position = Offscreen;
                sour.transform.position = CharacterPosition;
                sourRender.enabled = true;
                CharacterInt++;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                sourRender.enabled = false;
                sour.transform.position = Offscreen;
                idle_1.transform.position = CharacterPosition;
                idle_1Render.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            //Create as many as there are characters
            default:
                ResetInt();
                break;
        }
    }
    public void PreviousCharacter()
    {
        switch (CharacterInt)
        {
            case 1:
                PlayerPrefs.SetInt(selectedCharacter, 2);
                idle_1Render.enabled = false;
                idle_1.transform.position = Offscreen;
                sour.transform.position = CharacterPosition;
                sourRender.enabled = true;
                CharacterInt--;
                ResetInt();
                break;
            case 2:
                PlayerPrefs.SetInt(selectedCharacter, 3);
                dogeRender.enabled = false;
                doge.transform.position = Offscreen;
                idle_1.transform.position = CharacterPosition;
                idle_1Render.enabled = true;
                CharacterInt--;
                break;
            case 3:
                PlayerPrefs.SetInt(selectedCharacter, 1);
                sourRender.enabled = false;
                sour.transform.position = Offscreen;
                doge.transform.position = CharacterPosition;
                dogeRender.enabled = true;
                CharacterInt--;
                break;
            //Create as many as there are characters
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if(CharacterInt >= 3)
        {
            CharacterInt = 1;
        }
        else
        {
            CharacterInt = 3;
        }
    }

    public void PlayScreen()
    {
        SceneManager.LoadScene(3); //change when loading all scenes

    }
}