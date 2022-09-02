using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour
{
    public PlayerScript playerScript;
    public ScoreScript score;
    public GameControllerScript gameController;
    public AudioSource audioSource;
    public AudioSource gameOverSound;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            gameOverSound.Play();
            playerScript.enabled = false;
            gameController.GameOver();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedCube")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
      
    }
}
