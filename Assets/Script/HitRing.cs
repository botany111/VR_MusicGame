using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRing : MonoBehaviour
{
    public static bool snareDrum, bassDrum, crash, flooTom, HHclose, HHopen, ride, tom1, tom2;
    public static GameObject G_snareDrum, G_bassDrum, G_crash, G_flooTom, G_HHclose, G_HHopen, G_ride, G_tom1, G_tom2;

    public GameObject test;
    public bool test1;

    public GameObject self;

    private void OnTriggerEnter(Collider other)
    {
        //Snare Drum
        if (other.CompareTag("snare drum"))
        {
            snareDrum = true;
            G_snareDrum = other.gameObject;      

        }

        //BassDrum
        if (other.CompareTag("bass drum"))
        {
            bassDrum = true;
            G_bassDrum = other.gameObject;
        }


        //HH(close)
        if (other.CompareTag("HH(close)"))
        {
            HHclose = true;
            G_HHclose = other.gameObject;
        }


    }

    private void Start()
    {
    }

    private void Update()
    {
        test = G_HHclose;
        test1 = HHclose;
    }


    //private void OnTriggerExit(Collider other)
    //{
    //    snareDrum = false;
    //    G_snareDrum = null;
    //    Destroy(G_snareDrum);
    //}
}
