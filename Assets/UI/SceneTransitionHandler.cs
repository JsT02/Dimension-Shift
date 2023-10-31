using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionHandler : MonoBehaviour
{

    public void Transition(string scenename)
    {

        SceneManager.LoadScene(scenename);

    }

}
