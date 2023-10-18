using UnityEngine;
using System.Collections;
using OculusSampleFramework;

public class HandController : MonoBehaviour
{
    public OVRHand leftHand;
    public OVRHand rightHand;

    void Start()
    {
        leftHand = GameObject.Find("OVRPlayerController/Hands/HandLeft").GetComponent<OVRHand>();
        rightHand = GameObject.Find("OVRPlayerController/Hands/HandRight").GetComponent<OVRHand>();
    }

    void Update()
    {
        // Check if the left hand is tracking
        if (leftHand.IsTracked)
        {
            // Update the position and rotation of the left hand object to match the left controller
            transform.Find("LeftHand").position = leftHand.transform.position;
            transform.Find("LeftHand").rotation = leftHand.transform.rotation;
        }

        // Check if the right hand is tracking
        if (rightHand.IsTracked)
        {
            // Update the position and rotation of the right hand object to match the right controller
            transform.Find("RightHand").position = rightHand.transform.position;
            transform.Find("RightHand").rotation = rightHand.transform.rotation;
        }
    }
}
