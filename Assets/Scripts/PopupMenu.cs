using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupMenu : MonoBehaviour {
    public static bool IsPopUpOpened = true;
    public GameObject popupMenu;

    private void OnEnable() {
        Time.timeScale = 0f;
    }

    public void Update() {
        
        if (Input.GetKeyDown(KeyCode.I)) {
            if (!IsPopUpOpened) {
                OpenPopUp();
            } 
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) {
            if (IsPopUpOpened) {
                ClosePopUp();
            }
        }
    }

    public void OpenPopUp() {
        popupMenu.SetActive(true);
        Time.timeScale = 0f;
        IsPopUpOpened = true;
    }

    public void ClosePopUp() {
        popupMenu.SetActive(false);
        Time.timeScale = 1f;
        IsPopUpOpened = false;
    }
}
