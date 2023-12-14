using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransitionHandler : MonoBehaviour
{

    public GameObject panel1;
    public GameObject panel2;

    public void Transition()
    {

        panel1.SetActive(false);
        panel2.SetActive(true);

    }

}
