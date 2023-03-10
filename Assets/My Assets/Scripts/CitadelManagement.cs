using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CitadelManagement : MonoBehaviour
{
    //lounge zone
    public GameObject subZone_lounge;
    public GameObject chara_allie;
    public GameObject chara_oneesan;
    public GameObject chara_kil;
    public GameObject panel_allie;
    public GameObject panel_oneesan;
    public GameObject panel_kil;

    //office zone
    public GameObject subZone_office;
    public GameObject chara_berro;
    public GameObject chara_xel;
    public GameObject panel_berro;
    public GameObject panel_xel;

    //alley zone
    public GameObject subZone_alley;
    public GameObject chara_crank;
    public GameObject chara_lane;
    public GameObject chara_draz;
    public GameObject panel_crank;
    public GameObject panel_lane;
    public GameObject panel_draz;

    //digs zone
    public GameObject subZone_digs;
    public GameObject chara_loanshark;
    public GameObject chara_questchara1;
    public GameObject chara_questchara2;
    public GameObject panel_loanshark;
    public GameObject panel_questchara1;
    public GameObject panel_questchara2;

    //movement calculation
    private Vector3 originalPosition1;
    private Vector3 originalPosition2;
    private Vector3 originalPosition3;
    private Vector3 newCharaPositon;
    private Vector3 newSize;

    //original sizes
    private Vector3 allieOriginalSize;
    private Vector3 oneesanOriginalSize;
    private Vector3 kilOriginalSize;
    private Vector3 berroOriginalSize;
    private Vector3 xelOriginalSize;
    private Vector3 crankOriginalSize;
    private Vector3 laneOriginalSize;
    private Vector3 drazOriginalSize;
    private Vector3 shylarOriginalSize;
    private Vector3 questchara1OS;
    private Vector3 questchara2OS;
    //UI header

    //UI subHeader
    public GameObject panel_subHeader;

    //managing zone handling

    // Start is called before the first frame update
    void Start()
    {
        panel_subHeader.gameObject.SetActive(false);

        subZone_lounge.gameObject.SetActive(false);
        subZone_office.gameObject.SetActive(false);
        subZone_alley.gameObject.SetActive(false);
        subZone_digs.gameObject.SetActive(false);

        originalPosition1 = new Vector3(7,-2,-1);
        originalPosition2 = new Vector3(4,-2,-1);
        originalPosition3 = new Vector3(1,-2,-1);
        newCharaPositon = new Vector3(-3, -2, -1);

        //original sizes
        allieOriginalSize = chara_allie.transform.localScale;
        oneesanOriginalSize = chara_oneesan.transform.localScale;
        kilOriginalSize = chara_kil.transform.localScale;
        berroOriginalSize = chara_berro.transform.localScale;
        xelOriginalSize = chara_xel.transform.localScale;
        crankOriginalSize = chara_crank.transform.localScale;
        laneOriginalSize = chara_lane.transform.localScale;
        drazOriginalSize = chara_draz.transform.localScale;
        shylarOriginalSize = chara_loanshark.transform.localScale;
        questchara1OS = chara_questchara1.transform.localScale;
        questchara2OS = chara_questchara2.transform.localScale;

        //newSize = new Vector3(3, 6, 1);
        newSize = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        NavigateZones();
    }

    #region Opening Zones

    public void EnteringTheAlley()
    {
        subZone_alley.gameObject.SetActive(true);
        panel_subHeader.gameObject.SetActive(true);
    }

    public void EnteringTheLounge()
    {
        subZone_lounge.gameObject.SetActive(true);
        panel_subHeader.gameObject.SetActive(true);
    }

    public void EnteringTheOffices()
    {
        subZone_office.gameObject.SetActive(true);
        panel_subHeader.gameObject.SetActive(true);
    }

    public void EnteringTheDigs()
    {
        subZone_digs.gameObject.SetActive(true);
        panel_subHeader.gameObject.SetActive(true);
    }
    #endregion

    #region Navigating Zones    

    public void NavigateZones()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayHit2b = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));

            Debug.Log(rayHit2b);

            //lounge
            #region The Lounge
            if (rayHit2b.collider.name == "lounge_Allie")
            {
                Debug.Log("I hit " + rayHit2b.collider.name);

                chara_oneesan.gameObject.SetActive(false);
                chara_kil.gameObject.SetActive(false);

                chara_allie.gameObject.transform.position = newCharaPositon;
                chara_allie.transform.localScale = newSize;

                panel_allie.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "lounge_Oneesan")
            {
                chara_allie.gameObject.SetActive(false);
                chara_kil.gameObject.SetActive(false);

                chara_oneesan.gameObject.transform.position = newCharaPositon;
                chara_oneesan.transform.localScale = newSize;

                panel_oneesan.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "lounge_Kil")
            {
                chara_allie.gameObject.SetActive(false);
                chara_oneesan.gameObject.SetActive(false);

                chara_kil.gameObject.transform.position = newCharaPositon;
                chara_kil.transform.localScale = newSize;

                panel_kil.gameObject.SetActive(true);
            }
            #endregion

            //alley
            #region The Alley
            if (rayHit2b.collider.name == "alley_Crank")
            {
                chara_lane.gameObject.SetActive(false);
                chara_draz.gameObject.SetActive(false);

                chara_crank.gameObject.transform.position = newCharaPositon;
                chara_crank.transform.localScale = newSize;

                panel_crank.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "alley_Lane")
            {
                chara_crank.gameObject.SetActive(false);
                chara_draz.gameObject.SetActive(false);

                chara_lane.gameObject.transform.position = newCharaPositon;
                chara_lane.transform.localScale = newSize;

                panel_lane.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "alley_Draz")
            {
                chara_crank.gameObject.SetActive(false);
                chara_lane.gameObject.SetActive(false);

                chara_draz.gameObject.transform.position = newCharaPositon;
                chara_draz.transform.localScale = newSize;

                panel_draz.gameObject.SetActive(true);
            }
            #endregion

            //office
            #region The Office
            if (rayHit2b.collider.name == "office_Berro")
            {
                chara_xel.gameObject.SetActive(false);

                chara_berro.gameObject.transform.position = newCharaPositon;
                chara_berro.transform.localScale = newSize;

                panel_berro.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "office_Xel")
            {
                chara_berro.gameObject.SetActive(false);

                chara_xel.gameObject.transform.position = newCharaPositon;
                chara_xel.transform.localScale = newSize;

                panel_xel.gameObject.SetActive(true);
            }
            #endregion

            //digs
            #region The Digs
            if (rayHit2b.collider.name == "digs_Shylar")
            {
                chara_questchara1.gameObject.SetActive(false);
                chara_questchara2.gameObject.SetActive(false);

                chara_loanshark.gameObject.transform.position = newCharaPositon;
                chara_loanshark.transform.localScale = newSize;

                panel_loanshark.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "digs_mainChara1")
            {
                chara_loanshark.gameObject.SetActive(false);
                chara_questchara2.gameObject.SetActive(false);

                chara_questchara1.gameObject.transform.position = newCharaPositon;
                chara_questchara1.transform.localScale = newSize;

                panel_questchara1.gameObject.SetActive(true);
            }
            if (rayHit2b.collider.name == "digs_mainChara2")
            {
                chara_loanshark.gameObject.SetActive(false);
                chara_questchara1.gameObject.SetActive(false);

                chara_questchara2.gameObject.transform.position = newCharaPositon;
                chara_questchara2.transform.localScale = newSize;

                panel_questchara2.gameObject.SetActive(true);
            }
            #endregion
        }
    }

    public void ResetZones()
    {
        //lounge
        chara_allie.gameObject.SetActive(true);
        chara_allie.transform.position = originalPosition1;
        chara_allie.transform.localScale = allieOriginalSize;
        panel_allie.gameObject.SetActive(false);

        chara_oneesan.gameObject.SetActive(true);
        chara_oneesan.transform.position = originalPosition2;
        chara_oneesan.transform.localScale = oneesanOriginalSize;
        panel_oneesan.gameObject.SetActive(false);

        chara_kil.gameObject.SetActive(true);
        chara_kil.transform.position = originalPosition3;
        chara_kil.transform.localScale = kilOriginalSize;
        panel_kil.gameObject.SetActive(false);

        //alley
        chara_crank.gameObject.SetActive(true);
        chara_crank.transform.position = originalPosition1;
        chara_crank.transform.localScale = crankOriginalSize;
        panel_crank.gameObject.SetActive(false);

        chara_lane.gameObject.SetActive(true);
        chara_lane.transform.position = originalPosition2;
        chara_lane.transform.localScale = laneOriginalSize;
        panel_lane.gameObject.SetActive(false);

        chara_draz.gameObject.SetActive(true);
        chara_draz.transform.position = originalPosition3;
        chara_draz.transform.localScale = drazOriginalSize;
        panel_draz.gameObject.SetActive(false);

        //office
        chara_berro.gameObject.SetActive(true);
        chara_berro.transform.position = originalPosition1;
        chara_berro.transform.localScale = berroOriginalSize;
        panel_berro.gameObject.SetActive(false);

        chara_xel.gameObject.SetActive(true);
        chara_xel.transform.position = originalPosition2;
        chara_xel.transform.localScale = xelOriginalSize;
        panel_xel.gameObject.SetActive(false);

        //digs
        chara_loanshark.gameObject.SetActive(true);
        chara_loanshark.transform.position = originalPosition1;
        chara_loanshark.transform.localScale = shylarOriginalSize;
        panel_loanshark.gameObject.SetActive(false);

        chara_questchara1.gameObject.SetActive(true);
        chara_questchara1.transform.position = originalPosition2;
        chara_questchara1.transform.localScale = questchara1OS;
        panel_questchara1.gameObject.SetActive(false);

        chara_questchara2.gameObject.SetActive(true);
        chara_questchara2.transform.position = originalPosition3;
        chara_questchara2.transform.localScale = questchara2OS;
        panel_questchara2.gameObject.SetActive(false);
    }
    #endregion
}
