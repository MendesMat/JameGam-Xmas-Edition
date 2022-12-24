using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementBehaviour movementBehaviour;

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        movementBehaviour.MovePlayer();
    }
}
