using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float jumpForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdBody.linearVelocityY = jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadTouch")
        {
            Debug.Log("You lose!");
            Time.timeScale = 0;
        }
    }
}
