using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTriggerEnter : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    [Header("部位名稱")]
    public string self;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            source.PlayOneShot(clip);

            isSnareDrum();
        }

    }


    private void Update()
    {
        //鍵盤測試
        if (Input.GetKeyDown(KeyCode.B))
        {
            if( self == "Snare Drum")
            {
                if (Hit.snareDrum)
                {
                    Destroy(Hit.G_snareDrum);
                    
                }
                source.PlayOneShot(clip);
            }
        }

    }




    void isSnareDrum() 
    {
        if (self == "Snare Drum")
        {
            if (Hit.snareDrum)
            {
                Destroy(Hit.G_snareDrum);
            }
        }
    }
}
