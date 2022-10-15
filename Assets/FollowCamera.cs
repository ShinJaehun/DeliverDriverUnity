using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        // transform.position = thingToFollow.transform.position;
        // unity 카메라가 3D라는 것을 기억하자.
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
