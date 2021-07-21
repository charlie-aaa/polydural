using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCounter : MonoBehaviour
{
    public GameObject fpsText;
    private float _hudRefreshRate = 1f;
 
    private float timer;
 
    private void Update()
    {
        if (Time.unscaledTime > timer)
        {
            int fps = (int)(1f / Time.unscaledDeltaTime);
            fpsText.GetComponent<UnityEngine.UI.Text>().text = fps.ToString();
            timer = Time.unscaledTime + _hudRefreshRate;
        }
    }
}
