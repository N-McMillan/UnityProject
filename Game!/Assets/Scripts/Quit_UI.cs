using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class Quit_UI : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("delete"))
        {
            Application.Quit();
        }
    }
}