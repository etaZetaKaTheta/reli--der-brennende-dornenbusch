using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    private void Start()
    {
        Invoke("Quit", 10.0f);
    }

    private void Quit()
    {
        Application.Quit();
    }
}
