using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Users : MonoBehaviour
{
    public List<UserObject> users = new List<UserObject>();
    public void InitUser()
    {
        for (int i = 0; i < 4; i++)
        {
            users.Add(new UserObject(i+1,$"User_{i+1}"));
        }
    }

}

[System.Serializable]
public class UserObject
{
    public int id;
    public string userName;
    public List<CardObject> currentCards = new List<CardObject>();

    public UserObject(int id, string userName)
    {
        this.id = id;
        this.userName = userName;
    }
}
[System.Serializable]
public class CardObject
{
    
    public int number;
    public CardController.CardGroup cardGroup;
    public Sprite spr;
    public CardObject(int number, CardController.CardGroup cardGroup,Sprite spr)
    {
        this.number = number;this.cardGroup = cardGroup;this.spr = spr;
    }
}
