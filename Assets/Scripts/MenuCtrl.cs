using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCtrl : MonoBehaviour
{
    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;

        // If the left mouse button is pressed down
        if (Input.GetMouseButtonDown(0) == true)
        {
            if (gameObject.name != "ExitBtn")
            {
                SceneManager.LoadScene(gameObject.name);
                GetComponent<SpriteRenderer>().color = Color.white;
            }
            else
            {
                Application.Quit();
            }
        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
