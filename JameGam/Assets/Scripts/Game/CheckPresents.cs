using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPresents : MonoBehaviour
{
    public int PresentsCounter = 0;

    public void CheckObjective()
    {
        if (PresentsCounter >= 5)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
