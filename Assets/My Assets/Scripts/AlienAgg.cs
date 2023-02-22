using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAgg : MonoBehaviour
{
    [SerializeField]
    GameObject alienBullet;

    float fireRate;
    float nextFire;

    //initialization
    private void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    private void Update()
    {
        if (MainManager.Instance.hasturnedonPheninColors == false)
        {
            if (transform.position.y < 4 && transform.position.y > -4 && gameObject.CompareTag("aggAlien"))
            {
                CheckIfTimeToFirePhenon();
            }
        }

        if (MainManager.Instance.hasturnedonXeronColors == false)
        {
            if (transform.position.y < 4 && transform.position.y > -4 && gameObject.CompareTag("res_alien"))
            {
                CheckIfTimeToFireXeron();
            }
        }
    }

    void CheckIfTimeToFirePhenon()
    {
        if (Time.time > nextFire)
        {
            Instantiate(alienBullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
    void CheckIfTimeToFireXeron()
    {
        if (Time.time > nextFire)
        {
            Instantiate(alienBullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
