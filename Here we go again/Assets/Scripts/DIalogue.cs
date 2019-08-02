using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIalogue : MonoBehaviour{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public GameObject continueButton;
    public GameObject nextButton;

    void Start()
    {
        nextButton.SetActive(false);
        StartCoroutine(Type());
    }

    void Update()
    {
        if(textDisplay.text == sentences[index])
         {
        continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            nextButton.SetActive(true);
        }
      
    }

    public void NextScene()
    {
        Application.LoadLevel("Scenes/CharacterSelect");
    }
}