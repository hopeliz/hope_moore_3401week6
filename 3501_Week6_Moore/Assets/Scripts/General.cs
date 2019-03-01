using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : MonoBehaviour {

    public GameObject duck;
    public GameObject hudPanel;
    public AudioSource splashSound;
    public Animator skyAnimator;
    public bool gameOn = false;

    public void StartAnimation()
    {
        skyAnimator.SetTrigger("begin");
    }

    public void StartGame()
    {
        gameOn = true;
        duck.SetActive(true);
        hudPanel.SetActive(true);
    }

    public void Splash()
    {
        splashSound.Play();
    }
}
