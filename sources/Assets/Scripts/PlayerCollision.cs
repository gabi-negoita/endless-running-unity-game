/**
 * Controll player collition events
 */
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public BoxCollider playerCollider;

    public GameObject obj;

    public float gameOverDelay = 2f;
    private int bonusPoints = 100;
    public GameObject gameOver;
    public GameObject background;

    public SoundEffects soundEffects;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Ground"))
        {
            playerMovement.isAbleToJump = true;
        }

        if  (collision.collider.tag.Equals("Obstacle") && (transform.position.y - collision.transform.position.y <= 0.4))
        {
            // Disabling player movement
            playerMovement.enabled = false;

            // Starting the player's fall animation
            FindObjectOfType<AnimationController>().StartFall();

            // Sound effects
            soundEffects.PlayCrashSoundEffect();
            soundEffects.PlayDieSoundEffect();

            // Game over
            Invoke("GameOver", gameOverDelay);

            collision.collider.enabled = false;
        }
        
        if (collision.collider.tag.Equals("BonusPoints")) 
        {
            // Sound effect
            soundEffects.PlayBonusPointsSoundEffect();

            // Destroy the object collider
            Destroy(collision.gameObject);

            // Increase score
            DisplayScore.incrementScore(bonusPoints);
        }
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        background.GetComponent<Image>().color = new Color32(255, 255, 255, 125);
    }
}
