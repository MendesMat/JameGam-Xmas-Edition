using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private MainCameraBehaviour mainCamera;
    [SerializeField]
    private CheckPresents checkPresents;

    private void Update()
    {
        MainCamera();
        CheckObjective();
    }

    void MainCamera()
    {
        mainCamera.CameraFollowsPlayer();
    }

    void CheckObjective()
    {
        checkPresents.CheckObjective();
    }
}
