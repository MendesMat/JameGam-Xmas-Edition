using UnityEngine;

public class MainCameraBehaviour : MonoBehaviour
{
    public Transform player;

    public void CameraFollowsPlayer()
    {
        if (GameObject.Find("Coldean") != null)
        {
            transform.position = new Vector3(player.position.x, 35, player.position.z-35);
        }   
    }
}
