using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Users : MonoBehaviour
{
    public List<Card> cardsObject = new List<Card>();

    private void Start()
    {
        InitCardsObject();
    }

    void InitCardsObject()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Card.CardGroup cardGroup = (Card.CardGroup)i;
                cardsObject.Add(new Card(j, cardGroup));
                print($"{cardsObject[i]}");
            }
        }
    }

}

[System.Serializable]
public class User
{
    public int id;
    public string userName;
    public List<Card> currentCards = new List<Card>();
    
}
[System.Serializable]
public class Card
{
    public enum CardGroup
    {
        Heart=0,Diamond=1,Spade=2,Club=3
    }
    public int number;
    public CardGroup cardGroup;
    public Sprite spr;
    public Card(int number,CardGroup cardGroup)
    {
        this.number = number;this.cardGroup = cardGroup;
    }
}
