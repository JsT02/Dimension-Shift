using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases : MonoBehaviour
{

    public Movement player;
    public bool currentPhase = false;
    private bool first = true;
    // if currentPhase = false, phase 1.  else phase 2

    // Update is called once per frame
    void Update()
    {

        if (!player.isGrounded && first)
        {
            first = false;
            if (currentPhase) currentPhase = false;
            else currentPhase = true;

        }
        else if(player.isGrounded) first = true;

    }
}
