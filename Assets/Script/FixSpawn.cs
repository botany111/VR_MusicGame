using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixSpawn : MonoBehaviour
{

    public string Tag;

    public Transform selfTf;

    public GameObject SelfGb;

    private bool fix = false;


    private void Update()
    {
        selfTf = GetComponent<Transform>();

        //Debug.Log(selfTf.position.y);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            Destroy(gameObject);

            Debug.Log("fix");
        }
    }

}
