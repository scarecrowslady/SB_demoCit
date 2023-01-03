using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneUIPopOUt : MonoBehaviour
{
    private Vector3 originalSize;

    private Vector3 zoneEntrance_originalSize;

    // Start is called before the first frame update
    void Start()
    {
        originalSize = new Vector3(2, 6, 1);
        zoneEntrance_originalSize = new Vector3(3, 6, 1);
    }

    private void OnMouseOver()
    {
        RaycastHit2D rayHit2 = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

        if (gameObject.CompareTag("chara") == true)
        {
            rayHit2.transform.localScale = new Vector3(3, 8, 1);
        }

        if (gameObject.CompareTag("zone") == true)
        {
            rayHit2.transform.localScale = new Vector3(4, 8, 1);
        }
    }

    private void OnMouseExit()
    {
        if (gameObject.CompareTag("chara") == true)
        {
            gameObject.transform.localScale = originalSize;
        }

        if (gameObject.CompareTag("zone") == true)
        {
            gameObject.transform.localScale = zoneEntrance_originalSize;
        }
    }
}