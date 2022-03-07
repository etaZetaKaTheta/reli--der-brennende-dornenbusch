using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PerformanceTest : MonoBehaviour
{
    [SerializeField] private TMP_Text frameText;
    void Start()
    {
        Application.targetFrameRate = 120;
        QualitySettings.vSyncCount = 0;
        InvokeRepeating("CountFrames", 0.1f, 0.1f);
    }

    private void CountFrames()
    {
        frameText.text = (1f / Time.unscaledDeltaTime).ToString();
    }
}
