using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ripple : MonoBehaviour
{
    //public GameObject self;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
