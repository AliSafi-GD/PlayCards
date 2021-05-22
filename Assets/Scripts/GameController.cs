using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform[] trsParents;
    public CardController cardController;
    public Users users;

    public List<CardObject> currentCards = new List<CardObject>();

    private void Start()
    {
        users.InitUser();
        cardController.InitCardsObject();
        currentCards = new List<CardObject>(cardController.cardsObject);
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
                CardObject card = currentCards[rnd];
                currentCards.Remove(card);
                users.users[i].currentCards.Add(card);
                CreateCard(card,trsParents[i]);
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
                    CardObject card = currentCards[rnd];
                    currentCards.Remove(card);
                    users.users[u].currentCards.Add(card);
                    CreateCard(card, trsParents[u]);
                }
            }
        }
    }

    void CreateCard(CardObject card,Transform parent)
    {
        Card c = Instantiate(cardPrefab, parent).GetComponent<Card>();
        c._Card = card;
    }
}
