using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour
{
    void OnMouseOver()
    {
        // If the left mouse button is pressed down
        if (Input.GetMouseButtonDown(0) == true)
        {
            if(NotesCtrl.noteCounter >= NotesCtrl.noteNames.Length)
            {
                GetComponent<SpriteRenderer>().color = Color.grey;
                GetComponent<AudioSource>().Play();
                return;           
            }

            if (gameObject.name == NotesCtrl.currentNote)
            {
                GetComponent<SpriteRenderer>().color = Color.grey;
                NotesCtrl.noteCounter += 1;

                NotesCtrl.score += 5;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Color.red;

                if (NotesCtrl.score <= 5)
                {
                    NotesCtrl.score = 0;
                }
                else
                {
                    NotesCtrl.score -= 5;
                }
            }

            GetComponent<AudioSource>().Play();

        }
        //If the left mouse button is released
        if (Input.GetMouseButtonUp(0) == true)
        {
            GetComponent<SpriteRenderer>().color = Color.white;

            if (NotesCtrl.noteCounter < NotesCtrl.noteNames.Length && TutorialCtrl.playTurorial)
            {
                GameObject.Find(NotesCtrl.currentNote).GetComponent<SpriteRenderer>().color = Color.yellow;
            }
        }
    }

    private void OnMouseExit()
    {
        if (NotesCtrl.currentNote != gameObject.name)
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
