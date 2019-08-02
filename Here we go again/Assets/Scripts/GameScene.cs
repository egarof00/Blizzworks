using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    public int index;
    public GameObject doge;
    public GameObject idle_1;
    public GameObject sour;

    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("SelectedCharacter");

        if (index == 1)
        {
            Debug.Log("doge");
            idle_1.SetActive(false);
            sour.SetActive(false);
            doge.SetActive(true);
        }
        else if (index == 2)
        {
            Debug.Log("sour");
            idle_1.SetActive(false);
            sour.SetActive(true);
            doge.SetActive(false);
        }
        else
        {
            Debug.Log("idle_1");
            idle_1.SetActive(true);
            sour.SetActive(false);
            doge.SetActive(false);


        }
    }


}
