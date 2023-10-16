using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public float FollowDistance = -10f;
    public Transform Target;

    void Update()
    {
        
        transform.position = new Vector3(Target.position.x, Target.position.y, FollowDistance);

    }
}
