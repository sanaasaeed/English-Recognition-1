using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameState : MonoBehaviour
{
    private Animator basketAnimation;
    [SerializeField] private GameObject targetAlphabet;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int count = 0;

    public bool isTargetSet = false;
    void Start() {
        basketAnimation = FindObjectOfType<Animator>();
    }

    public void SetTargetAlphabet(Sprite target) {
        targetAlphabet.GetComponent<SpriteRenderer>().sprite = target;
        isTargetSet = true;
    }

    public void AnimateBasket() {
        basketAnimation.enabled = true;
    }

    public void StopAnimation() {
        basketAnimation.enabled = false;
    }

    public void IncreaseScore() {
        count += 30;
        scoreText.text = count.ToString();
    }

    public void DecreaseScore() {
        count -= 30;
        scoreText.text = count.ToString();
    }
}
