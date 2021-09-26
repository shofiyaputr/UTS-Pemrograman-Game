using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditsPanel;

    void Start()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }

    void Update()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game1");
    }

    public void CreditsButton()
    {
        MenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void BackButton()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
    }
}
