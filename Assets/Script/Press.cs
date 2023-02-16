using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using VRTK;

public class Press : VRTK_InteractableObject
{

    //public GameObject VR_L;
   // public GameObject VR_R;

    // Start is called before the first frame update
    void Start()
    {
      // VR_R =  VRTK_DeviceFinder.GetControllerRightHand();
      // VR_L =  VRTK_DeviceFinder.GetControllerLeftHand();
    }

    //public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    //{
        
    //}

    void Test()
    {
        Debug.Log("踏板");
    }
}
