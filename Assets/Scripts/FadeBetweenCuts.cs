using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeBetweenCuts : MonoBehaviour
{
    [SerializeField] private float fadeOutTime = 1.0f;
    [SerializeField] private float transitionTime = 0.2f;
    [SerializeField] private GameObject fadeOutObject;

    void OnEnable()
    {
        StartCoroutine(FadeCutscene());
    }

    private IEnumerator FadeCutscene()
    {
        Image image = fadeOutObject.GetComponent<Image>();
        LeanTween.value(gameObject, 0, 1, fadeOutTime).setOnUpdate((float val) =>
        {
            Color c = image.color;
            c.a = val;
            image.color = c;
        });

        yield return new WaitForSeconds(transitionTime);

        image.color = Color.white;
        LeanTween.value(gameObject, 1, 0, fadeOutTime).setOnUpdate((float val) =>
        {
            Color c = image.color;
            c.a = val;
            image.color = c;
        });
        
    }
}
