using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ColliderEventTrigger : MonoBehaviour
{
    [SerializeField] private int cutsceneIndex;
    [SerializeField] private AudioSource whereAreTheSheep;
    [SerializeField] private AudioSource ending;
    [SerializeField] private PlayableDirector speakToGod;
    [SerializeField] private BoxCollider bc; 
    [SerializeField] private GameObject fader;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (fader.gameObject.activeInHierarchy) { fader.SetActive(false); }
            switch (cutsceneIndex)
            {
                case 0:
                    speakToGod.Play();
                    break;

                case 1:
                    if(whereAreTheSheep == null) { return; }
                    whereAreTheSheep.Play();
                    break;

                case 2:
                    if (ending == null) { return; }
                    ending.Play();
                    fader.SetActive(true);
                    StartCoroutine(SceneDelay());
                    break;
            }
            bc.enabled = false;
        }
    }

    private IEnumerator SceneDelay()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(2);
    }
}
