using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform parentObject;
    [SerializeField] private AudioSource audsrcBang;
    [SerializeField] private AudioSource audsrcPlayer;
    [SerializeField] private MeshCollider coll;
    
    [SerializeField] private float delay;
    [SerializeField] private ParticleSystem bigExplosion;
    public void Interact()
    {
        gameObject.transform.parent = parentObject;
        gameObject.transform.localPosition = Vector3.zero;
        gameObject.transform.localRotation = Quaternion.identity;

        coll.enabled = false;
        StartCoroutine(SoundDelay());
    }

    private IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(delay);
        audsrcBang.Play();
        bigExplosion.Play();
        yield return new WaitForSeconds(delay);
        audsrcPlayer.Play();
    }
}
