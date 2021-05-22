using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public enum CardGroup
    {
        Club = 0, Diamond = 1, Heart = 2, Spade = 3
    }
    // Start is called before the first frame update
    public List<CardObject> cardsObject = new List<CardObject>();

    public void InitCardsObject()
    {
        int number = 0;
        Sprite[] spr = Resources.LoadAll<Sprite>($"cards");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                
                CardGroup cardGroup = (CardGroup)i;
                cardsObject.Add(new CardObject(j, cardGroup,spr[number]));
               // print($"{cardsObject[i]}");
                number++;
            }
        }
    }
}
