using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int min, max;
    [SerializeField] TextMeshProUGUI guessText;  
    int guess;

    void Start()
    {
        StartGame();
        
    }
    public void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;                       // just so we dont't give the same answer again
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;                      // same above
        NextGuess();
    }

    public void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void Update()
    {
        
    }




}
