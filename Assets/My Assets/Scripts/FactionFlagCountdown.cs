using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FactionFlagCountdown : MonoBehaviour
{
    public float cooldownAmt;
    public float temppcdAmt;
    public float tempxcdAmt;

    public float pheninFlagCountdown;
    public float xeronFlagCountdown;

    public bool isPheninFlagOn;
    public bool isXeronFlagOn;

    public float tempPheninCD;
    public float tempXeronCD;

    public GameObject pheninPFB;
    public GameObject xeronPFB;

    public GameObject pheninflagCDtext;
    public GameObject xeronflagCDtext;
    public TMP_Text flagCountDown;
    public TMP_Text flagCountDown2;

    public GameObject pheninCoolDowntext;
    public GameObject xeronCoolDowntext;
    public TMP_Text pheninCoolDown;
    public TMP_Text xeronCoolDown;

    public Button pheninButton;
    public Button xeronButton;

    // Start is called before the first frame update
    void Start()
    {
        //set difficulty
        if (MainManager.Instance.DifficultyLevel == "easy")
        {
            pheninFlagCountdown = 20;
            xeronFlagCountdown = 20;

            cooldownAmt = 10;
        }
        if (MainManager.Instance.DifficultyLevel == "medium")
        {
            pheninFlagCountdown = 15;
            xeronFlagCountdown = 15;

            cooldownAmt = 15;
        }
        if (MainManager.Instance.DifficultyLevel == "hard")
        {
            pheninFlagCountdown = 10;
            xeronFlagCountdown = 10;

            cooldownAmt = 20;
        }

        temppcdAmt = cooldownAmt;
        tempxcdAmt = cooldownAmt;

        tempPheninCD = pheninFlagCountdown;
        tempXeronCD = xeronFlagCountdown;

        MainManager.Instance.pheninFlagCountdown = pheninFlagCountdown;
        MainManager.Instance.xeronFlagCountdown = xeronFlagCountdown;

        isPheninFlagOn = false;
        MainManager.Instance.hasturnedonPheninColors = isPheninFlagOn;
        isXeronFlagOn = false;
        MainManager.Instance.hasturnedonXeronColors = isXeronFlagOn;

        pheninflagCDtext.gameObject.SetActive(true);
        xeronflagCDtext.gameObject.SetActive(true);
        pheninCoolDowntext.gameObject.SetActive(false);
        xeronCoolDowntext.gameObject.SetActive(false);

        flagCountDown.text = MainManager.Instance.pheninFlagCountdown + "";
        flagCountDown2.text = MainManager.Instance.xeronFlagCountdown + "";
    }

    // Update is called once per frame
    void Update()
    {
        //counting down the shield timer
        float pfCD = Mathf.RoundToInt(tempPheninCD);
        float xfCD = Mathf.RoundToInt(tempXeronCD);
        flagCountDown.text = pfCD + "";
        flagCountDown2.text = xfCD + "";

        //counting down the cooldown timer
        float pfcool = Mathf.RoundToInt(temppcdAmt);
        float xfcool = Mathf.RoundToInt(tempxcdAmt);
        pheninCoolDown.text = pfcool + "";
        xeronCoolDown.text = xfcool + "";

        //checking flag status
        if(isPheninFlagOn == true)
        {
            MainManager.Instance.hasturnedonPheninColors = true;
        }
        if (isXeronFlagOn == true)
        {
            MainManager.Instance.hasturnedonXeronColors = true;
        }
    }

    public void PopPheninColors()
    {
        StartCoroutine(PheninColorHandling());
    }
    public void PopXeronColors()
    {
        StartCoroutine(XeronColorHandling());
    }

    IEnumerator PheninColorHandling()
    {
        while (tempPheninCD > 0)
        {
            isPheninFlagOn = true;
            tempPheninCD -= Time.deltaTime;

            yield return null;
        }
        
        if(tempPheninCD <= 0)
        {
            pheninflagCDtext.gameObject.SetActive(false);
            Coroutine b = StartCoroutine(PheninFlagCoolDown());

            yield return b;
        }
    }

    IEnumerator XeronColorHandling()
    {
        while (tempXeronCD > 0)
        {
            isXeronFlagOn = true;
            tempXeronCD -= Time.deltaTime;

            yield return null;
        }

        if (tempXeronCD <= 0)
        {
            xeronflagCDtext.gameObject.SetActive(false);
            Coroutine b = StartCoroutine(XeronFlagCoolDown());

            yield return b;
        }
    }

    IEnumerator PheninFlagCoolDown()
    {
        while (temppcdAmt > 0)
        {
            pheninCoolDowntext.gameObject.SetActive(true);
            pheninButton.interactable = false;
            temppcdAmt -= Time.deltaTime;

            yield return null;
        }

        pheninCoolDowntext.gameObject.SetActive(false);
        tempPheninCD = pheninFlagCountdown;
        temppcdAmt = cooldownAmt;
        pheninButton.interactable = true;
        pheninflagCDtext.gameObject.SetActive(true);

        isPheninFlagOn = false;
        MainManager.Instance.hasturnedonPheninColors = isPheninFlagOn;
    }

    IEnumerator XeronFlagCoolDown()
    {
        while (tempxcdAmt > 0)
        {
            xeronCoolDowntext.gameObject.SetActive(true);
            xeronButton.interactable = false;
            tempxcdAmt -= Time.deltaTime;

            yield return null;
        }

        xeronCoolDowntext.gameObject.SetActive(false);
        tempXeronCD = pheninFlagCountdown;
        tempxcdAmt = cooldownAmt;
        xeronButton.interactable = true;
        xeronflagCDtext.gameObject.SetActive(true);

        isXeronFlagOn = false;
        MainManager.Instance.hasturnedonXeronColors = isXeronFlagOn;
        Debug.Log("The status of xeron colors in FFC script " + MainManager.Instance.hasturnedonXeronColors);
    }
}
