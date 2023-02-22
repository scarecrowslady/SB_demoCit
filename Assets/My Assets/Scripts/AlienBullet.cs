using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBullet : MonoBehaviour
{
    public float moveSpeed = 7f;

    Rigidbody2D rb;

    PlayerController target;
    private Vector2 moveDirection;

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerController>();

        gameManager = GameObject.Find("ScriptManagers");

        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 7f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            if(MainManager.Instance.DifficultyLevel == "easy")
            {
                gameManager.GetComponent<GameController>().ManagePlayerHealth(-2);
            }
            if (MainManager.Instance.DifficultyLevel == "medium")
            {
                gameManager.GetComponent<GameController>().ManagePlayerHealth(-4);
            }
            if (MainManager.Instance.DifficultyLevel == "hard")
            {
                gameManager.GetComponent<GameController>().ManagePlayerHealth(-6);
            }

            Destroy(gameObject);
        }
    }
}