using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public static bool snareDrum;

    public static GameObject GsnareDrum;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("snare drum"))
        {
            snareDrum = true;

            GsnareDrum = other.gameObject ;
        }
    }





    private void OnTriggerExit(Collider other)
    {
        snareDrum = false;
        GsnareDrum = null;
    }
}
