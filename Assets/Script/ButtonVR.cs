using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;

    public bool isPressed;

    public GameObject gm;

    void Start()
    {
        isPressed = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015F, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void StartGame()
    {
        gm.SetActive(false);
        Score.score = 0;
        gm.SetActive(true);
    }
}
