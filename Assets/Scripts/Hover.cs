using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Hover : MonoBehaviour
{
    public float Amplitude = 1f;
    public float Frequency = 1f;

    private Vector3 startPos;

    private void OnEnable()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float time = Application.isPlaying
            ? Time.time
#if UNITY_EDITOR
            : (float)UnityEditor.EditorApplication.timeSinceStartup;
#else
            : 0f;
#endif

        float newY = startPos.y + Mathf.Sin(time * Frequency) * Amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }

    public void ResetStartPosition()
    {
        startPos = transform.position;
    }
}
