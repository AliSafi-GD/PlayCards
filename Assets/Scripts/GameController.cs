using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CardController cardController;
    public Users users;

    public List<Card> currentCards = new List<Card>();

    private void Start()
    {
        users.InitUser();
        cardController.InitCardsObject();
        currentCards = new List<Card>(cardController.cardsObject);
        DestributeCards();
    }
    void DestributeCards()
    {
        FirstDistributeCards();
    }
    void FirstDistributeCards()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int rnd = Random.Range(0, currentCards.Count);
                Card card = currentCards[rnd];
                currentCards.Remove(card);
                users.users[i].currentCards.Add(card);
            }
        }
        ContinueDistributeCard();
    }
    void ContinueDistributeCard()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int u = 0; u < 4; u++)
            {
                for (int c = 0; c < 4; c++)
                {
                    int rnd = Random.Range(0, currentCards.Count);
                    Card card = currentCards[rnd];
                    currentCards.Remove(card);
                    users.users[i].currentCards.Add(card);
                }
            }
        }
    }
}
