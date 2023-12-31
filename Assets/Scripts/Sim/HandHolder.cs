using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandHolder : Singleton<HandHolder> {

    public List<Card> Hand;
    private float HandItemGap = 0.125f;

    private void Start() {
        SetHand();
        CalculateCardPositons();
    }

    private void SetHand() {
        Hand = new List<Card>();
        foreach (Card card in GetComponentsInChildren<Card>()) { Hand.Add(card); }
    }

    private void ResetCardPositions() { foreach(Card c in Hand) { c.StopMovement(); c.LerpDefault(0.2f); } }

    public void CalculateCardPositons() {
        if (Hand.Count == 0) { return; }

        float ItemWidth = Hand[0].GetComponent<RectTransform>().rect.width;

        float StartX = 0 - (Hand.Count * (ItemWidth + ItemWidth * HandItemGap)/2)  + ItemWidth/2;
        for (int i=0; i<Hand.Count; i++) {
            Hand[i].SetDefaultPosition(new Vector3(StartX, transform.position.y, 2));
            StartX += ItemWidth + ItemWidth * HandItemGap;
        }
    }

    public void AddCard(Card card) {
        Hand.Add(card);
        CalculateCardPositons();

        ResetCardPositions();
    }

    public bool RemoveCard(Card card, bool destroyFlag=true) {
        if (! Hand.Contains(card)) { return false; }
        Hand.Remove(card);
        CalculateCardPositons();
        ResetCardPositions();
        if (destroyFlag) {
            Destroy(card.gameObject);
        }
        return true;
    }

    public void ClearHand() {
        Hand.Clear();
        CalculateCardPositons();
    }

}
