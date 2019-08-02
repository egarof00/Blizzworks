using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change2level : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayScreen()
    {
        SceneManager.LoadScene(4); //change when loading all scenes
    }

}
