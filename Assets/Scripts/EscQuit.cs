using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscQuit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Bye!");
            Application.Quit();
        }
    }
}
