using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject aboutPanel;

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;

        // If the left mouse button is pressed down
        if (Input.GetMouseButtonDown(0) == true)
        {
            if (gameObject.name == "Hide")
            {
                aboutPanel.SetActive(false);
                GetComponent<SpriteRenderer>().color = Color.white;
            }
            else
            {
                aboutPanel.SetActive(true);
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }


    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
