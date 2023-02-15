using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ripple : MonoBehaviour
{
    public  enum Status { perfect , good , miss}

    public Status status ;

    //private Transform Gb;

     public Status test;



    // Start is called before the first frame update
    void Start()
    {
        status = Status.miss;
    }

    private void Update()
    {
        test = status;
    }

    //// Update is called once per frame
    //void Update()
    //{
    //   // test = status;

    //    Gb = this.GetComponent<Transform>();


    //    double x = (double)Gb.transform.localScale.x;
    //    Debug.Log(x);
    //    switch (status)
    //    {
    //        case Status.miss:

    //            if(x >= 0.3f)
    //            {
    //                status = Status.good;
    //            }

    //            break;

    //        case Status.good:

    //            if (x >= 0.32f)
    //            {
    //                status = Status.perfect;
    //            }

    //            break;

    //        case Status.perfect:

    //            if (x >= 0.35f)
    //            {
    //                status = Status.nice;
    //            }

    //            break;



    //    }
    //}

    public void Destroy()
    {
        Destroy(gameObject);
        HitRing.snareDrum = false;
    }

    void isPrefect()
    {
        status = Status.perfect;
       // Debug.Log("PREFECT");
    }

    void isGood()
    {
        status = Status.good;
        //Debug.Log("GOOD");
    }

}
