using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingPoints : MonoBehaviour
{
    public GameObject gameManager;

    //set difficulty
    public bool isLevelEasy;
    public bool isLevelMedium;
    public bool isLevelHard;

    //managing inventory
    public float addBountyAmt;
    public float addRocksAmt;
    public float addDebrisAmt;

    //managing bank
    public float addMoneyAmt;

    //managing scores
    public float addScoreForResAmt;
    public float addScoreForAliensAmt;

    public float addToHighScore;

    //managing alien relationships
    public float addPheninRlshpForMiningAmt;
    public float addPheninRlshpForShootingAmt;
    public float addXeronRlshpForMiningAmt;
    public float addXeronRlshpForShootingAmt;
    public float addPheninRlshpForBountyAmt;
    public float addXeronRlshpForBountyAmt;

    //managing crime rating
    public float hittingPlanetsCrimeRateAmt;
    public float hittingNeutAlienCrimeRateAmt;
    public float hittingResCrimeRateAmt;

    //player background
    public string playerBackgroundChoice;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("ScriptManagers");

        playerBackgroundChoice = MainManager.Instance.PlayerBackground;

        //----->THIS WILL NEED MORE TWEAKING!     

        if (MainManager.Instance.DifficultyLevel == "easy")
        {
            addBountyAmt = 5;
            addRocksAmt = 3;
            addDebrisAmt = 3;

            addMoneyAmt = 5;

            addScoreForResAmt = 7;
            addScoreForAliensAmt = 10;

            addToHighScore = 20;

            addPheninRlshpForMiningAmt = 3;
            addXeronRlshpForMiningAmt = 3;
            addPheninRlshpForShootingAmt = 7;
            addXeronRlshpForShootingAmt = 7;
            addPheninRlshpForBountyAmt = 5;
            addXeronRlshpForBountyAmt = 5;

            hittingNeutAlienCrimeRateAmt = 15;
            hittingPlanetsCrimeRateAmt = 20;
            hittingResCrimeRateAmt = -10;
        }
        if (MainManager.Instance.DifficultyLevel == "medium")
        {
            addBountyAmt = 3;
            addRocksAmt = 2;
            addDebrisAmt = 2;

            addMoneyAmt = 3;

            addScoreForResAmt = 5;
            addScoreForAliensAmt = 7;

            addToHighScore = 16;

            addPheninRlshpForMiningAmt = 2;
            addXeronRlshpForMiningAmt = 2;
            addPheninRlshpForShootingAmt = 5;
            addXeronRlshpForShootingAmt = 5;
            addPheninRlshpForBountyAmt = 3;
            addXeronRlshpForBountyAmt = 3;

            hittingNeutAlienCrimeRateAmt = 20;
            hittingPlanetsCrimeRateAmt = 25;
            hittingResCrimeRateAmt = -7;
        }
        if (MainManager.Instance.DifficultyLevel == "hard")
        {
            addBountyAmt = 2;
            addRocksAmt = 1;
            addDebrisAmt = 1;

            addMoneyAmt = 1;

            addScoreForResAmt = 3;
            addScoreForAliensAmt = 5;

            addToHighScore = 10;

            addPheninRlshpForMiningAmt = 1;
            addXeronRlshpForMiningAmt = 1;
            addPheninRlshpForShootingAmt = 3;
            addXeronRlshpForShootingAmt = 3;
            addPheninRlshpForBountyAmt = 2;
            addXeronRlshpForBountyAmt = 2;

            hittingNeutAlienCrimeRateAmt = 30;
            hittingPlanetsCrimeRateAmt = 35;
            hittingResCrimeRateAmt = -5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //hitting neutral aliens

        if (collision.CompareTag("neut_alien") == true)
        {
            gameManager.GetComponent<GameController>().BecomeCriminal(hittingNeutAlienCrimeRateAmt);

            //pirate perk
            if(playerBackgroundChoice == "pirate")
            {
                gameManager.GetComponent<GameController>().AddBounty(addBountyAmt * MainManager.Instance.scavengingRate);
                gameManager.GetComponent<GameController>().AddingScore(addToHighScore);
            }            
        }

        //PHENIN (RED)
        if (collision.CompareTag("res_alien") == true)
        {
            gameManager.GetComponent<GameController>().AddIrillRlshp(addPheninRlshpForShootingAmt);
            gameManager.GetComponent<GameController>().AddMoney(addMoneyAmt);
            gameManager.GetComponent<GameController>().AddingScore(addScoreForAliensAmt);
        }

        if (collision.CompareTag("playerKiller") == true)
        {
            gameManager.GetComponent<GameController>().AddIrillRlshp(addPheninRlshpForShootingAmt);
            gameManager.GetComponent<GameController>().BecomeCriminal(hittingPlanetsCrimeRateAmt);
        }

        if (collision.CompareTag("res_debris") == true)
        {            
            gameManager.GetComponent<GameController>().AddIrillRlshp(addPheninRlshpForMiningAmt);
            gameManager.GetComponent<GameController>().AddingScore(addScoreForResAmt);

            if(isLevelEasy || isLevelMedium == true)
            {
                gameManager.GetComponent<GameController>().BecomeCriminal(hittingResCrimeRateAmt);
            } 

            if(playerBackgroundChoice == "trader")
            {
                gameManager.GetComponent<GameController>().AddDebris(addDebrisAmt * MainManager.Instance.scavengingRate);
                gameManager.GetComponent<GameController>().AddingScore(addToHighScore/2);
            } else if (playerBackgroundChoice == "pirate" || playerBackgroundChoice == "hunter")
            {
                gameManager.GetComponent<GameController>().AddDebris(addDebrisAmt * MainManager.Instance.scavengingRate);
            }
        }

        //XERON (BLUE)
        if (collision.CompareTag("aggAlien") == true)
        {
            gameManager.GetComponent<GameController>().AddXenonRlshp(addXeronRlshpForShootingAmt);
            gameManager.GetComponent<GameController>().AddMoney(addMoneyAmt);
            gameManager.GetComponent<GameController>().AddingScore(addScoreForAliensAmt);

            Debug.Log("Adding Plunder: " + MainManager.Instance.InvBountyCount);
        }

        if (collision.CompareTag("playerKiller2") == true)
        {
            gameManager.GetComponent<GameController>().AddXenonRlshp(addXeronRlshpForShootingAmt);
            gameManager.GetComponent<GameController>().BecomeCriminal(hittingPlanetsCrimeRateAmt);
        }

        if (collision.CompareTag("res_rocks") == true)
        {
            gameManager.GetComponent<GameController>().AddXenonRlshp(addXeronRlshpForMiningAmt);
            gameManager.GetComponent<GameController>().AddingScore(addScoreForResAmt);

            if (isLevelEasy || isLevelMedium == true)
            {
                gameManager.GetComponent<GameController>().BecomeCriminal(hittingResCrimeRateAmt);
            }
            if (playerBackgroundChoice == "trader")
            {
                gameManager.GetComponent<GameController>().AddRocks(addRocksAmt * MainManager.Instance.scavengingRate);
                gameManager.GetComponent<GameController>().AddingScore(addToHighScore/2);
            }
            else if (playerBackgroundChoice == "pirate" || playerBackgroundChoice == "hunter")
            {
                gameManager.GetComponent<GameController>().AddRocks(addRocksAmt * MainManager.Instance.scavengingRate);
            }
        }

        //hitting bounty aliens
        if(collision.CompareTag("bounty_alien") == true)
        {
            
            gameManager.GetComponent<GameController>().AddXenonRlshp(addXeronRlshpForBountyAmt);
            gameManager.GetComponent<GameController>().AddIrillRlshp(addPheninRlshpForBountyAmt);

            //hunter perk
            if (playerBackgroundChoice == "hunter")
            {
                gameManager.GetComponent<GameController>().AddBounty(addBountyAmt * MainManager.Instance.scavengingRate);
                gameManager.GetComponent<GameController>().AddingScore(addToHighScore);

            } else if (playerBackgroundChoice == "trader" || playerBackgroundChoice == "pirate")
            {
                gameManager.GetComponent<GameController>().AddBounty(addBountyAmt * MainManager.Instance.scavengingRate);
            }
        }
    }
}
