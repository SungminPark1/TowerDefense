﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public Button instructions;
    public Button play;
    public Button quit;
    public Button close;
    public Button credits;
    public Button menu;
    public Button monsterlog;
    public Button lore1;
    public Button lore2;

    private GameObject instructionPane;

    private bool instructionsClicked;

    // Use this for initialization
    void Start()
    {
    }

    void hideText()
    {
        instructionPane.SetActive(false);
    }

    void showText()
    {
        instructionPane.SetActive(true);
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void InstPage2()
    {
        SceneManager.LoadScene("InfoScreen");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Close()
    {
        hideText();
    }

    public void Play()
    {
        SceneManager.LoadScene("SungTest");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Monsterlog()
    {
        SceneManager.LoadScene("MonsterLog");
    }

    public void Lore1()
    {
        SceneManager.LoadScene("Lore1");
    }

    public void Lore2()
    {
        SceneManager.LoadScene("Lore2");
    }

    public void Lore3()
    {
        SceneManager.LoadScene("Lore3");
    }

    public void Lore12()
    {
        SceneManager.LoadScene("Lore12");
    }
    public void Lore22()
    {
        SceneManager.LoadScene("Lore22");
    }
    public void Lore32()
    {
        SceneManager.LoadScene("Lore32");
    }
    public void Lore13()
    {
        SceneManager.LoadScene("Lore13");
    }
    public void Lore23()
    {
        SceneManager.LoadScene("Lore23");
    }
    public void Lore33()
    {
        SceneManager.LoadScene("Lore33");
    }
}
