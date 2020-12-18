using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private Animator basketAnimation;
    private Alphabets alphabets;

    [SerializeField] private int count;
    // Start is called before the first frame update
    void Start() {
        basketAnimation = FindObjectOfType<Animator>();
        alphabets = FindObjectOfType<Alphabets>();
    }

    public void targetLetter() {
        
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
