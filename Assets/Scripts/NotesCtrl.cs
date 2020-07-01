using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NotesCtrl : MonoBehaviour
{
    public static int noteCounter;
    public static string currentNote;
    public static string[] noteNames;

    public static Text[] notePrefabs = new Text[100];

    public Text prefab;
    public Text scoreText;
    public Text finalScore;
    public GameObject notePanel;
    public GameObject fireWork;
    public GameObject gameOverPanel;
    public GameObject keyboard;
    public GameObject exitBtns;
    public Text factsText; 

    public static int score;
    public GameObject tutorialPanel;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        noteCounter = 0;

        string[] happyBday = new string[] {"G2", "G2", "A2", "G2", "C3", "B2", "G2", "G2", "A2", "G2", "D3", "C3", "G2", "G2", "G3", "E3", "C3", "B2", "A2", "F3", "F3", "E3", "C3", "D3", "C3" };
        string[] odeToJoy = new string[] {"E2", "E2", "F2", "G2", "G2", "F2", "E2", "D2", "C2", "C2", "D2", "E2", "E2", "D2", "D2", "E2", "E2", "F2", "G2", "G2", "F2", "E2", "D2", "C2", "C2", "D2", "E2", "D2", "C2", "C2", "D2", "D2", "E2", "C2", "D2", "E2", "F2", "E2", "C2", "D2", "E2", "F2", "E2", "C2", "C2", "D2", "E2", "E2", "F2", "G2", "G2", "F2", "E2", "D2", "C2", "C2", "D2", "E2", "D2", "C2", "C2" };
        string[] twinkleTwinkle = new string[] { "C2", "C2", "G2", "G2", "A2", "A2", "G2", "F2", "F2", "E2", "E2", "D2", "D2", "C2", "G2", "G2", "F2", "F2", "E2", "E2", "D2", "G2", "G2", "F2", "F2", "E2", "E2", "D2", "C2", "C2", "G2", "G2", "A2", "A2", "G2", "F2", "F2", "E2", "E2", "D2", "D2", "C2"};
        string[] forElise = new string[] {"E3", "D#3", "E3", "D#3", "E3", "B2", "D3", "C3", "A2", "C2", "E2", "A2", "B2", "E2", "A2", "B2", "C3", "E3", "D#3", "E3", "D#3", "E3", "B2", "D3", "C3", "A2", "C2", "E2", "A2", "B2", "E2", "C3", "B2", "A2", "B2", "C3", "D3", "E3", "G2", "F3", "E3", "D3", "E2", "E3", "D3", "C3", "E2", "D3", "C3", "B2", "E3", "D#3", "E3", "D#3", "E3", "B2", "D3", "C3", "A2", "C2", "E2", "A2", "B2", "E2", "A2", "B2", "C3", "E3", "D#3", "E3", "D#3", "E3", "B2", "D3", "C3", "A2", "C2", "E2", "A2", "B2", "E2", "C3", "B2", "A2" };
        string[] faded = new string[] {"F#2", "F#2", "F#2", "A#2", "D#3", "D#3", "D#3", "C#3", "A#2", "A#2", "A#2", "A#2", "F2", "F2", "F2", "D#2", "F#2", "F#2", "F#2", "D#2", "F#2", "D#2", "F#2", "G#2", "A#2", "F#2", "F#2", "D#2", "A#2", "F#2", "F#2", "F#2", "F2", "F2", "F2", "D#2", "F#2", "F#2", "F#2", "D#2", "F#2", "D#2", "F#2", "G#2", "A#2", "F#2", "F#2", "C#3", "A#2", "F#2", "G#2", "A#2", "A#2", "A#2", "A#2", "F#2", "D#2", "C#2", "F#2", "C#3", "C#3", "A#2", "F#2", "C#3", "C#3", "A#2", "G#2", "A#2", "A#2", "A#2", "A#2", "F#2", "F#2", "D#2", "B2", "C#3", "A#2", "C#3", "A#2", "C#3", "A#2", "C#3", "A#2", "F#2", "B2", "D#2", "B2", "A#2"};
        string[] jingleBells = new string[] {"E3", "E3", "E3", "E3", "E3", "E3", "E3", "G3", "C3", "D3", "E3", "F3", "F3", "F3", "F3", "F3", "E3", "E3", "E3", "E3", "E3", "D3", "D3", "E3", "D3", "G3", "E3", "E3", "E3", "E3", "E3", "E3", "E3", "E3", "G3", "C3", "D3", "E3", "F3", "F3", "F3", "F3", "F3", "E3", "E3", "E3", "E3", "G3", "G3", "F3", "D3", "C3" };

        string[] facts = new string[] { "Fact #1\nThe piano was invented in Italy in 1709 by harpsichord maker Bartolomeo di Francesco Cristofori.", "Fact #2\nA new piano should be tuned four times a year to adjust to its new environment and changing seasons. After the first year, tuning twice a year is sufficient.", "Fact #3\nPianos have a total of 88 black and white keys.", "Fact #4\nThe exact middle of a piano keyboard is NOT middle C. It is actually the space between E and F above middle C.", "Fact #5\nEach string usually holds around 168 pounds of tension. The total tension of most standard pianos is around 18-20 tons.", "Fact #6\nPedals on pianos are called – from left to right – una corda, sostenuto, and the sustain pedal.", "Fact #7\nSolfège naming convention Do–Re–Mi–Fa–Sol–La–Si = C-D-E-F-G-A-B respectively.", "Fact #8\nThe sharp sign (#) raises a note by a semitone or half-step, and a flat (b) lowers it by the same amount. For example, the note (D#) equals the note (Eb). ", "Fact #9\nThe black keys on the piano represent sharp and flat notes.For example, the black key AFTER the note (D) is (D#) and the black key BEFORE the note (D) is (Db). ", "Fact #10\nIn the piano instrument, there are no semitones (no black keys) between E-F and B-C." };

        //Choose a random piano fact to show at the begining of the game
        System.Random random = new System.Random();
        int selectedFact = random.Next(0, 9);
        factsText.text = facts[selectedFact];

        string sceneName = SceneManager.GetActiveScene().name;

        //Loads the correct scene
        if(sceneName == "Level1")
        {
            noteNames = happyBday;
        }
        else if (sceneName == "Level2")
        {
            noteNames = odeToJoy;
        }
        else if (sceneName == "Level3")
        {
            noteNames = twinkleTwinkle;
        }
        else if (sceneName == "Level4")
        {
            noteNames = forElise;
        }
        else if (sceneName == "Level5")
        {
            noteNames = faded;
        }
        else if (sceneName == "Level6")
        {
            noteNames = jingleBells;
        }
        
        //Sets the first note to be played
        currentNote = noteNames[0];
        GameObject.Find(currentNote).GetComponent<SpriteRenderer>().color = Color.yellow;

        //Instantiates the notes in the panel for the player to follow
        for (int i = 0; i < noteNames.Length; i++)
        {
            prefab.text = noteNames[i];
            Text spawnedPrefab = Instantiate(prefab, notePanel.transform);
            notePrefabs[i] = spawnedPrefab;
        }

        //Sets the score in the UI
        scoreText.text = $"Score: " + 0; 
    }

    void Update()
    {
        //Show the correct UI on the start of the level
        if (noteCounter < 1)
        {
            if (tutorialPanel.activeInHierarchy)
            {
                HideUi();
            }
            else
            {
                ShowUi();
            }
        }

        //Ends the game when the song is played completely
        if (noteCounter >= noteNames.Length)
        {            
            StartCoroutine(Finish());            
        }
        //Or finds the next note to be played
        else
        {
            currentNote = noteNames[noteCounter];           
        }

        //Sets the correct colour of the notes 
        for (int i = 0; i < noteNames.Length; i++)
        {
            notePrefabs[i].color = Color.black;
        }
        if (noteCounter < noteNames.Length)
        {
            notePrefabs[noteCounter].color = Color.yellow;
        }

        //Updates the score in the UI
        scoreText.text = $"Score: " + score;
    }

    void GameOver()
    {
        HideUi();

        int lastScore = score;
        finalScore.text = $"Score: " + lastScore ;

        gameOverPanel.SetActive(true);
        fireWork.SetActive(true);
    }

    IEnumerator Finish()
    {
        yield return new WaitForSeconds(1.5f);

        GameOver();
    }

    void HideUi()
    {
        notePanel.SetActive(false);
        keyboard.SetActive(false);
        exitBtns.SetActive(false);
        scoreText.enabled = false;
    }

    void ShowUi()
    {
        notePanel.SetActive(true);
        keyboard.SetActive(true);
        exitBtns.SetActive(true);
        scoreText.enabled = true;
    }
}
