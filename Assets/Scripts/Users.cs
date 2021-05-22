using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Users : MonoBehaviour
{
    public List<User> users = new List<User>();
    public void InitUser()
    {
        for (int i = 0; i < 4; i++)
        {
            users.Add(new User());
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
    
    public int number;
    public CardController.CardGroup cardGroup;
    public Sprite spr;
    public Card(int number, CardController.CardGroup cardGroup,Sprite spr)
    {
        this.number = number;this.cardGroup = cardGroup;this.spr = spr;
    }
}
