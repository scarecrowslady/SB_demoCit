using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //basic stuff
    public GameObject playerPFB;
    public SpriteRenderer playerCol;
    public Color playerBodyCol;

    //moving player
    public float horizontalInput;
    public float playerMoveSpeed;
    public float xRange;

    //shooting bullets
    public GameObject bulletPrefab;

    //triggering game states
    GameController gameManagingScript;
    public GameObject gameManager;

    //bullets
    public float ammoCount;
    public string playerDifficulty;

    //setting difficulty

    // Start is called before the first frame update
    void Start()
    {
        playerCol = playerPFB.GetComponent<SpriteRenderer>();
        gameManagingScript = gameManager.GetComponent<GameController>();

        ammoCount = MainManager.Instance.InvBulletCount;
        playerDifficulty = MainManager.Instance.DifficultyLevel;

        MainManager.Instance.isLevelEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        SetPlayerColor();

        if (MainManager.Instance.isLevelEnded == false)
        {
            //shooting
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                if(playerDifficulty != "easy" && ammoCount >= 1)
                {
                    Instantiate(bulletPrefab, gameObject.transform.position, bulletPrefab.transform.rotation);
                    gameManagingScript.GetComponent<GameController>().ManageAmmo(-1);
                } else if (playerDifficulty == "easy")
                {
                    Instantiate(bulletPrefab, gameObject.transform.position, bulletPrefab.transform.rotation);
                    gameManagingScript.GetComponent<GameController>().ManageAmmo(-1);
                }
                
            } 

            //moving
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerMoveSpeed);
        }
    }

    public void SetPlayerColor()
    {
        if (MainManager.Instance != null)
        {
            playerBodyCol = MainManager.Instance.PlayerColor;
            playerCol.color = playerBodyCol;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("playerKiller") || collision.CompareTag("playerKiller2") == true)
        {
            if(playerDifficulty == "easy")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-30);
            }
            if(playerDifficulty == "medium")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-40);
            }
            if(playerDifficulty == "hard")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-50);
            }
        }
        if(collision.CompareTag("res_rocks") || collision.CompareTag("res_debris") == true)
        {
            if (playerDifficulty == "easy")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-3);
            }
            if (playerDifficulty == "medium")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-5);
            }
            if (playerDifficulty == "hard")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-7);
            }
        }
        if(collision.CompareTag("res_alien") || collision.CompareTag("aggAlien") || collision.CompareTag("neut_alien") || collision.CompareTag("bounty_alien") == true)
        {
            if (playerDifficulty == "easy")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-7);
            }
            if (playerDifficulty == "medium")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-10);
            }
            if (playerDifficulty == "hard")
            {
                gameManagingScript.GetComponent<GameController>().ManagePlayerHealth(-13);
            }
        }
    }
}
