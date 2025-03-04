using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    // Camera position should be the same as the player's position.

    [SerializeField] GameObject thingToFollow;
    [SerializeField] Vector3 offset; // Define the camera's offset from the player

    void LateUpdate() {

    }Update()
    {

        transform.position = thingToFollow.transform.position + offset;

    }
}
