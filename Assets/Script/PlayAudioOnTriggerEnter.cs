using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

using UnityEngine.UI;
using VRTK;

public class PlayAudioOnTriggerEnter : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    [Header("部位名稱")]
    public string self;

    private Animator animScore;

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;

    public Animator anim;

    public GameObject prefect;
    public GameObject good;
    public Transform spawn;



    // private Score Score;





    // Start is called before the first frame update
    void Start()
    {
        //trackedObj = GetComponent<SteamVR_TrackedObject>();
        //device = SteamVR_Controller.Input((int)trackedObj.index);

        source = GetComponent<AudioSource>();
        animScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("123");

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

        //if (device.GetTouchDown(EVRButtonId.k_EButton_SteamVR_Touchpad))
        //{
        //    Debug.Log("123");
        //}
        //鍵盤測試
        if (Input.GetKeyDown(KeyCode.B))
        {
            if( self == "Snare Drum")
            {
                if (HitRing.snareDrum == true)
                {
                    
                    addScore();
                    Destroy(HitRing.G_snareDrum);
                   
                }

                anim.SetTrigger("hit");
                source.PlayOneShot(clip);
            }
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (self == "HH")
            {
                if (HitRing.HHclose == true)
                {
                    addScore();
                    Destroy(HitRing.G_HHclose);
                    
                }
                source.PlayOneShot(clip);
                anim.SetTrigger("hit");
            }
        }

    }




    void isSnareDrum()
    {
        if (self == "Snare Drum")
        {
            if (HitRing.G_snareDrum != null)
            {
                addScore();
                Destroy(HitRing.G_snareDrum);
                
            }
            anim.SetTrigger("hit");
        }
    }

    void isBassDrum()
    {
        if (self == "Bass Drum")
        {
            if (HitRing.G_bassDrum != null)
            {
                Destroy(HitRing.G_bassDrum);
                addScore();
            }
            anim.SetTrigger("hit");
        }
    }

    void isHHclose()
    {
        if (self == "HH")
        {
            if (HitRing.G_HHclose != null)
            {
                Destroy(HitRing.G_HHclose);
                addScore();
            }
            anim.SetTrigger("hit");
        }
    }


    void addScore()
    {
        if(HitRing.G_snareDrum != null)
        {
            if (HitRing.G_snareDrum.GetComponent<ripple>().status == ripple.Status.perfect)
            {
                Score.score += 2;
                animScore.SetTrigger("perfect");
                Instantiate(prefect, spawn);
            }
            else
            {
                Score.score += 1;
                animScore.SetTrigger("good");
                Instantiate(good, spawn);
            }
        }

        if (HitRing.G_HHclose != null)
        {
            if (HitRing.G_HHclose.GetComponent<ripple>().status == ripple.Status.perfect)
            {
                Score.score += 2;
                animScore.SetTrigger("perfect");
            }
            else
            {
                Score.score += 1;
                animScore.SetTrigger("good");
            }
        }

        if (HitRing.G_bassDrum != null)
        {
            if (HitRing.G_bassDrum.GetComponent<ripple>().status == ripple.Status.perfect)
            {
                Score.score += 2;
                animScore.SetTrigger("perfect");
            }
            else
            {
                Score.score += 1;
                animScore.SetTrigger("good");
            }
        }


    }


}
