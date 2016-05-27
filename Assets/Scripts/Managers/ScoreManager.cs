using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;        // The player's score.
       

        Text text, text1;                      // Reference to the Text component.


        void Awake ()
        {
            // Set up the reference.
            text = GetComponent <Text> ();
            text1 = GetComponent<Text>();
           
            // Reset the score.
            score = 0;
        }


        void Update ()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Score: " + score;
            if (score > 100)
            {
                text1.text = "Nivel Completado!";
                SceneManager.LoadScene("Level2");
                text.color = Color.blue;
            }
        }
    }
}