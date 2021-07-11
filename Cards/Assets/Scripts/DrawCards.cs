using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject[] cards;

    [SerializeField]
    private Transform playArea;
    private int numberOfCards;

    private bool isCardDrawn;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCards = 5;
        isCardDrawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawPlayerCards()
    {
        if (!isCardDrawn)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                GameObject cardDrawm = Instantiate(cards[Random.Range(0, cards.Length)], Vector2.zero, Quaternion.identity);
                cardDrawm.transform.SetParent(playArea, false);
            }
            isCardDrawn = true;
        }
    }
}
