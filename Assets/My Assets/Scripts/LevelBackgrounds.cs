using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBackgrounds : MonoBehaviour
{
    public GameObject levelOneBackdrop;
    public GameObject levelTwoBackdrop;
    public GameObject levelThreeBackdrop;
    public GameObject levelFourBackdrop;
    public GameObject levelFiveBackdrop;
    public GameObject levelSixBackdrop;
    public GameObject levelSevenBackdrop;
    public GameObject levelEightBackdrop;
    public GameObject levelNineBackdrop;
    public GameObject levelTenBackdrop;

    public float levelNumber;

    // Start is called before the first frame update
    void Start()
    {
        levelNumber = MainManager.Instance.levelNumber;

        if(levelNumber == 1)
        {
            levelOneBackdrop.SetActive(true);

            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelTwoBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelThreeBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelFourBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelFiveBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelSixBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelSevenBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelEightBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelNineBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelTenBackdrop.SetActive(false);
        }
        if (levelNumber == 1)
        {
            levelTenBackdrop.SetActive(true);

            levelOneBackdrop.SetActive(false);
            levelTwoBackdrop.SetActive(false);
            levelThreeBackdrop.SetActive(false);
            levelFourBackdrop.SetActive(false);
            levelFiveBackdrop.SetActive(false);
            levelSixBackdrop.SetActive(false);
            levelSevenBackdrop.SetActive(false);
            levelEightBackdrop.SetActive(false);
            levelNineBackdrop.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
