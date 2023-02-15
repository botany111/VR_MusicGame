using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public static bool snareDrum , bassDrum , crash , flooTom, HHclose, HHopen , ride , tom1 , tom2;
    public static GameObject G_snareDrum , G_bassDrum, G_crash, G_flooTom, G_HHclose, G_HHopen, G_ride, G_tom1, G_tom2;

    

    public bool perfect;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("test");

        if (perfect)
        {
            other.GetComponent<Perfect>().isPerfect = true;
        }

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

        //crash
        if (other.CompareTag("crash"))
        {
            crash = true;
            G_crash = other.gameObject;
        }

        //floor tom
        if (other.CompareTag("floor tom"))
        {
            flooTom = true;
            G_flooTom = other.gameObject;
        }

        //HH(close)
        if (other.CompareTag("HH(close)"))
        {
            HHclose = true;
            G_HHclose = other.gameObject;
        }

        //HH(open)
        if (other.CompareTag("HH(open)"))
        {
            HHopen = true;
            G_HHopen = other.gameObject;
        }

        //ride
        if (other.CompareTag("ride"))
        {
            ride = true;
            G_ride = other.gameObject;
        }

        //tom-1
        if (other.CompareTag("tom-1"))
        {
            tom1 = true;
            G_tom1 = other.gameObject;
        }

        //tom-2
        if (other.CompareTag("tom-2"))
        {
            tom2 = true;
            G_tom2 = other.gameObject;
        }
    }


    //private void OnTriggerStay(Collider other)
    //{
    //    //Snare Drum
    //    if (other.CompareTag("snare drum"))
    //    {
    //        snareDrum = true;
    //        G_snareDrum = other.gameObject;
    //    }

    //    //BassDrum
    //    if (other.CompareTag("bass drum"))
    //    {
    //        bassDrum = true;
    //        G_bassDrum = other.gameObject;
    //    }

    //    //crash
    //    if (other.CompareTag("crash"))
    //    {
    //        crash = true;
    //        G_crash = other.gameObject;
    //    }

    //    //floor tom
    //    if (other.CompareTag("floor tom"))
    //    {
    //        flooTom = true;
    //        G_flooTom = other.gameObject;
    //    }

    //    //HH(close)
    //    if (other.CompareTag("HH(close)"))
    //    {
    //        HHclose = true;
    //        G_HHclose = other.gameObject;
    //    }

    //    //HH(open)
    //    if (other.CompareTag("HH(open)"))
    //    {
    //        HHopen = true;
    //        G_HHopen = other.gameObject;
    //    }

    //    //ride
    //    if (other.CompareTag("ride"))
    //    {
    //        ride = true;
    //        G_ride = other.gameObject;
    //    }

    //    //tom-1
    //    if (other.CompareTag("tom-1"))
    //    {
    //        tom1 = true;
    //        G_tom1 = other.gameObject;
    //    }

    //    //tom-2
    //    if (other.CompareTag("tom-2"))
    //    {
    //        tom2 = true;
    //        G_tom2 = other.gameObject;
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {
        if (perfect)
        {
            other.GetComponent<Perfect>().isPerfect = false;
        }

        //Snare Drum
        snareDrum = false;
        G_snareDrum = null;
        Destroy(G_snareDrum);

        //BassDrum
        bassDrum = false;
        G_bassDrum = null;

        //crash
        crash = false;
        G_crash = null;

        //floor tom
        flooTom = false;
        G_flooTom = null;

        //HH(close)
        HHclose = false;
        G_HHclose = null;

        //HH(open)
        HHopen = false;
        G_HHopen = null;

        //ride
        ride = false;
        G_ride = null;

        //tom-1
        tom1 = false;
        G_tom1 = null;

        //tom-2
        tom2 = false;
        G_tom2 = null;
    }
}
