using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    private static PersistentData data;

    private int index = 0;

    [SerializeField] float waitTime = 4.0f;

    void Start ()
    {
        data = GameObject.FindWithTag("PD").GetComponent<PersistentData>();
        data.decided = false;
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

    public void WaitNext()
    {
        Invoke("nextScene",waitTime);
    }

    public void WaitPrev()
    {
        Invoke("PreviousScene",waitTime);
    }
    public void WaitSpecific (int index)
    {
        this.index = index;
        Invoke("NewsIndex",waitTime);
    }

    private void NewsIndex ()
    {
        LoadNewsScene(index);
    }

    public void LoadNewsScene (int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void AlterHappiness (int amount)
    {
        data.AlterHappiness(amount);
        data.decided = true;
    }

    public void AlterStress (int amount)
    {
        data.AlterStress(amount);
        data.decided = true;
    }

    public void Reset ()
    {
        data.Reset();
    }
}
