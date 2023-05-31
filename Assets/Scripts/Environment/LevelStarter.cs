using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{

    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;

    public float waitTime = 0.5f;
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(waitTime);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(waitTime);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(waitTime);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMovement.canMove = true;
    }
}
