using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private Animator basketAnimation;
    [SerializeField] private GameObject targetAlphabet;
    [SerializeField] private int count;

    private bool isTargetSet = false;
    void Start() {
        basketAnimation = FindObjectOfType<Animator>();
    }

    public void SetTargetAlphabet(Sprite target) {
        if (!isTargetSet) {
            targetAlphabet.GetComponent<SpriteRenderer>().sprite = target;
            isTargetSet = true;
        }
    }

    public void AnimateBasket() {
        basketAnimation.enabled = true;
    }

    public void StopAnimation() {
        basketAnimation.enabled = false;
    }

    public void IncreaseScore() {
        count += 30;
    }
    
}
