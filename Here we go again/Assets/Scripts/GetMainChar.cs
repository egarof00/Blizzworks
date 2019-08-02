using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetMainChar : MonoBehaviour
{
    public Sprite sour, idle_1, doge;
    private SpriteRenderer mySprite;
    private readonly string selectedCharacter = "SelectedCharacter";
    private Vector3 CharacterPosition;

    void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();
        //CharacterPosition = idle_1.transform.position;
    }
    void Start()
    {
        int getCharacter;

        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch (getCharacter)
        {
            case 1:
                mySprite.sprite = doge;
                //mySprite.transform.position = CharacterPosition;
                mySprite.enabled = true;
                break;
            case 2:
                mySprite.sprite = sour;
                //mySprite.transform.position = CharacterPosition;
                mySprite.enabled = true;
                break;
            case 3:
                mySprite.sprite = idle_1;
               //mySprite.transform.position = CharacterPosition;
                mySprite.enabled = true;
                break;
            default:
                mySprite.sprite = idle_1;
                //mySprite.transform.position = CharacterPosition;
                mySprite.enabled = true;
                break;
        }
    }

}
