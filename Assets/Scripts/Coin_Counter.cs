using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coin_Counter : MonoBehaviour
{
    //Text counterText;
    int coinsCollected = Coin_Collect.totalCoins;
    TextMeshProUGUI counterText;

    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();  
    }

    void Update()
    {
         if(counterText.text != Coin_Collect.totalCoins.ToString())
         {
             counterText.text = Coin_Collect.totalCoins.ToString();
         } 
         
        
    }
}
