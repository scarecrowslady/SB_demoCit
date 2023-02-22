using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    //top destruction
    public float topRangeLimit;

    //bottom destruction
    public float bottomRangeLimit;

    //level ended destruction
    //GameController gameController;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topRangeLimit)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < bottomRangeLimit)
        {
            Destroy(gameObject);
        }

        if (MainManager.Instance.isLevelEnded == true)
        {
            if (gameObject.CompareTag("bullet") || gameObject.CompareTag("res_rocks") || gameObject.CompareTag("res_alien") || gameObject.CompareTag("res_debris") || gameObject.CompareTag("res_alien") || gameObject.CompareTag("aggAlien")
                || gameObject.CompareTag("alienBullet") || gameObject.CompareTag("playerKiller") || gameObject.CompareTag("playerKiller2") || gameObject.CompareTag("neut_alien") || gameObject.CompareTag("bounty_alien") || gameObject.CompareTag("nothing") == true)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet") == true && (gameObject.CompareTag("res_rocks") || gameObject.CompareTag("res_debris") || gameObject.CompareTag("res_alien") || gameObject.CompareTag("aggAlien") || gameObject.CompareTag("neut_alien") 
            || gameObject.CompareTag("bounty_alien") || gameObject.CompareTag("nothing") == true))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

        if (gameObject.CompareTag("playerKiller") == true || gameObject.CompareTag("playerKiller2") == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
