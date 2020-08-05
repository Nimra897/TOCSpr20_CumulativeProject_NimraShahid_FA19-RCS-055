using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour
{
    public GameObject panelofmainmenu;
    public GameObject panelofhummingbird;
    public GameObject panelofmlagents;
    public GameObject panelofcomputationalmodel;
    public GameObject panelofpalindrome;
    public GameObject panelofparenthesis;
    public GameObject aboutcoursepanel;
    public GameObject linkpanel;
    public GameObject palindromelanguage;
    public GameObject parenthesislanguage;
    // Start is called before the first frame update
    void Start()
    {
        panelofmainmenu.SetActive(true);
    }
    public void Penguingame()
    {
        SceneManager.LoadScene("Penguins");
    }

    public void PalindromeLanguagecross()
    {
        
        palindromelanguage.SetActive(false);
    }

    public void ParenthesisLanguagecross()
    {

        parenthesislanguage.SetActive(false);
    }
    public void MLAgents()
    {
        panelofmlagents.SetActive(true);
        panelofmainmenu.SetActive(false);
    }

    public void ComputationalModel()
    {
        panelofcomputationalmodel.SetActive(true);
        panelofmainmenu.SetActive(false);
    }

    public void coursepanel()
    {
        aboutcoursepanel.SetActive(true);
    }
    public void linkpanelon()
    {
        linkpanel.SetActive(true);
    }
    public void crosscoursepanel()
    {
        aboutcoursepanel.SetActive(false);
    }
    public void crosslinkpanel()
    {
        linkpanel.SetActive(false);
    }

    public void palindromelinkon()
    {
        panelofpalindrome.SetActive(true);
        panelofmainmenu.SetActive(false);
        palindromelanguage.SetActive(false);

    }
    public void palindromelanguageclicked()
    {
        
        palindromelanguage.SetActive(true);

    }
    public void parehnthesislanguageclicked()
    {

        parenthesislanguage.SetActive(true);

    }

    public void parenthesispanelopen()
    {
        panelofparenthesis.SetActive(true);

        panelofmainmenu.SetActive(false);
        parenthesislanguage.SetActive(false);
    }
 

    public void parenthesisworld()
    {
        SceneManager.LoadScene("TerrainGame");
    }
    public void palindromeworld()
    {
        SceneManager.LoadScene("MyGame");
    }
    public void computationreturn()
    {
        panelofcomputationalmodel.SetActive(false);
        panelofmainmenu.SetActive(true);
    }

    public void palindromereturn()
    {
        panelofpalindrome.SetActive(false);
        panelofcomputationalmodel.SetActive(true);
    }

    public void parenthesisreturn()
    {
        panelofparenthesis.SetActive(false);
        panelofcomputationalmodel.SetActive(true);
    }
    public void openniazi()
    {
        Application.OpenURL("http://www.niazilab.com");
    }

  

    public void MLAgentReturn()
    {
        panelofmlagents.SetActive(false);
        panelofmainmenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Hummingbirdmenu()
    {
        panelofhummingbird.SetActive(true);
        panelofmainmenu.SetActive(false);
    }
    public void HummingAgent()
    {
        SceneManager.LoadScene("Training");
    }
    public void Battlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void back()
    {
        panelofmainmenu.SetActive(true);
        panelofhummingbird.SetActive(false);

    }

}