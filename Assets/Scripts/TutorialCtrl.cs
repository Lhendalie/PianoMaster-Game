using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialCtrl : MonoBehaviour
{
    public static bool playTurorial = true;
    public GameObject tutorialPanel;
    public GameObject factsPanel;
    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;

        // If the left mouse button is pressed down
        if (Input.GetMouseButtonDown(0) == true)
        {
            if (gameObject.name == "playTutorial")
            {
                playTurorial = true;             
            }
            else
            {
                playTurorial = false;
            }

            tutorialPanel.SetActive(false);
            factsPanel.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
