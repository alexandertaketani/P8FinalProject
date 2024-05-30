using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    public float jumpForce = 5;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {      
        if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
            Debug.Log("Game Over");
            SceneManager.LoadSceneAsync(3); } else if (collision.gameObject.CompareTag("Win")) {
            Debug.Log("Win");
            SceneManager.LoadSceneAsync(4); }
    }

}


