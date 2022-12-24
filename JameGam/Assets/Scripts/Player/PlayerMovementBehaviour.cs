using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovementBehaviour : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private CollectPresent presentReseter;

    [Header("Movement")]
    [SerializeField]
    private bool isGrounded = false;
    [SerializeField]
    private float moveAmount = 9.5f;
    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private string movingDirection;
    [SerializeField]
    public string sideLimiter;
    #endregion

    public void MovePlayer()
    {
        if (isGrounded)
        {
            rb.Sleep();

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                if (movingDirection == "up")
                {
                    rb.velocity = new Vector3(0, jumpForce, moveAmount);
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                    FindObjectOfType<AudioManager>().PlaySound("Jump");
                }
            }
            else if (Input.GetAxisRaw("Vertical") == -1f)
            {
                if (movingDirection == "down")
                {
                    rb.velocity = new Vector3(0, jumpForce, -moveAmount);
                    transform.rotation = Quaternion.Euler(0, 180, 0);
                    FindObjectOfType<AudioManager>().PlaySound("Jump");
                }
            }

            else if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                if(sideLimiter != "right")
                {
                    rb.velocity = new Vector3(moveAmount, jumpForce, 0);
                    transform.rotation = Quaternion.Euler(0, 90, 0);
                    FindObjectOfType<AudioManager>().PlaySound("Jump");
                }    
            }
            else if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                if(sideLimiter != "left")
                {
                    rb.velocity = new Vector3(-moveAmount, jumpForce, 0);
                    transform.rotation = Quaternion.Euler(0, -90, 0);
                    FindObjectOfType<AudioManager>().PlaySound("Jump");
                }
            }
        }
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
    }

    private void OnCollisionExit()
    {
        isGrounded = false;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "EndLine" && presentReseter.hasPresent == true)
        {
            FindObjectOfType<AudioManager>().PlaySound("DeliverPresent");
        }

        switch (col.tag)
        {
            case "BeginLine":
                movingDirection = "up";
                break;

            case "EndLine":
                movingDirection = "down";
                presentReseter.hasPresent = false;
                break;

            case "RightLine":
                sideLimiter = "right";
                break;

            case "LeftLine":
                sideLimiter = "left";
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sideLimiter = "";
    }
}
