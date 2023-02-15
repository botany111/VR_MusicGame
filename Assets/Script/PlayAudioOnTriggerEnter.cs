using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

using UnityEngine.UI;

public class PlayAudioOnTriggerEnter : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    [Header("部位名稱")]
    public string self;

    public Animator animScore;

    public Score Score;
    


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        animScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            source.PlayOneShot(clip);

            isSnareDrum();
            isBassDrum();
            isHHclose();
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
                    addScore();
                }
                source.PlayOneShot(clip);
            }
        }


        
    }




    void isSnareDrum() 
    {
        if (self == "Snare Drum")
        {
            if (Hit.G_snareDrum != null)
            {
                Destroy(Hit.G_snareDrum);
                addScore();
            }
        }
    }

    void isBassDrum()
    {
        if (self == "Bass Drum")
        {
            if (Hit.bassDrum)
            {
                Destroy(Hit.G_bassDrum);
                addScore();
            }
        }
    }

    void isHHclose()
    {
        if (self == "Bass Drum")
        {
            if (Hit.G_HHclose)
            {
                Destroy(Hit.G_HHclose);
                addScore();
            }
        }
    }


    void addScore()
    {
        if (Hit.G_HHclose.GetComponent<Perfect>().isPerfect == true)
        {
            Score.score += 5;
            animScore.SetTrigger("perfect");
        }
        else
        {
            Score.score += 1;
            animScore.SetTrigger("good");
        }
        
    }
}
