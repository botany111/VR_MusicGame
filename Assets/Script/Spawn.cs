using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Spawn : MonoBehaviour
{
    public string TrackEventID;
    public GameObject GB;
    public Transform SpawnPoint;

   // public int test;

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(TrackEventID, HandleEvent);
    }

    private void HandleEvent(KoreographyEvent koreoEvent)
    {
        //throw new KeyNotFoundException();
        Instantiate(GB, SpawnPoint.position, SpawnPoint.rotation);
        //test += 1;
        //Debug.Log(test);
        
    }
}
