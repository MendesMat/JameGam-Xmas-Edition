using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("Death");
            FindObjectOfType<AudioManager>().PlaySound("Impact");
            Destroy(other.gameObject);
            SceneManager.LoadScene("Game");
        }

        if (other.tag == "ObstacleDestroyer")
        {
            Destroy(gameObject);
        }
    }
}
