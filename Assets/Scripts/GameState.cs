using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class GameState : MonoBehaviour
{
    private Animator basketAnimation;
    [SerializeField] private GameObject targetAlphabetPrefab;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private List<Sprite> alphabets;
    private int count = 0;
    public static Sprite target;
    public static int levelScore;

    private void OnEnable() {
        SetTargetAlphabet();
        SetLevelScore();
    }

    void Start() {
        basketAnimation = FindObjectOfType<Animator>();
    }

    public void SetTargetAlphabet() {
        target = alphabets[Random.Range(0, 25)];
        targetAlphabetPrefab.GetComponent<SpriteRenderer>().sprite = target;
    }

    public void AnimateBasket() {
        basketAnimation.enabled = true;
    }

    public void StopAnimation() {
        basketAnimation.enabled = false;
    }

    public void IncreaseScore() {
        count += 10;
        scoreText.text = count.ToString();
    }

    public void DecreaseScore() {
        count -= 10;
        scoreText.text = count.ToString();
    }

    public void SetLevelScore() {
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            levelScore = 100;
        } else if (SceneManager.GetActiveScene().buildIndex == 2) {
            levelScore = 300;
        } else if (SceneManager.GetActiveScene().buildIndex == 3) {
            levelScore = 500;
        }
    }
}
