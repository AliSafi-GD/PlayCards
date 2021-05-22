using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Card : MonoBehaviour
{
    public CardObject card;
    public CardObject _Card
    {
        get => card;
        set
        {
            card = value;
            img = GetComponent<Image>();
            btn = GetComponent<Button>();
            img.sprite = card.spr;
        }
    }
    public Image img;
    public Button btn;
    
}
