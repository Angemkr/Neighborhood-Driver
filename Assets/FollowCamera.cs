using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    [SerializeField] GameObject thingToFollow;
    //camera position same as the car pov
    void LateUpdate()
    {   

        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-12) ;
    }
}
