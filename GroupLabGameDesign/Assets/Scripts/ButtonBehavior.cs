using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    private static PersistentData data;

    void Start ()
    {
        data = GameObject.FindWithTag("PD").GetComponent<PersistentData>();
    }

    public void loadMenu()
    {
        //AudioSource.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public void loadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void loadInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void nextScene() 
    {
        //AudioSource.PlayClipAtPoint(clickSoundEffect, transform.position);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }

    public void PreviousScene ()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) - 1);
    }

    public void LoadNewsScene (int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void AlterHappiness (int amount)
    {
        data.AlterHappiness(amount);
    }

    public void AlterStress (int amount)
    {
        data.AlterStress(amount);
    }
}
