using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixSpawn : MonoBehaviour
{

    public string Tag;



    private void Update()
    {

        //Debug.Log(selfTf.position.y);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            //Destroy(gameObject);

            Debug.Log("fix");
        }
    }

}
