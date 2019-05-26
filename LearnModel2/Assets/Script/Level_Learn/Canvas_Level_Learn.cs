using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Level_Learn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text t_temp;
        Image i_Temp;
        Level_Class[] level_temp = new Level_Class[7];

        Level_Data.Level_Init();
        ClearAllText();

        for(int i = 0; i < 7; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
        }

        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = level_temp[Level_Check.choose].GetQuestionType();
        t_temp = GameObject.Find("Text_LevelContent").GetComponent<Text>();
        t_temp.text = level_temp[Level_Check.choose].GetTitle();

        switch (Level_Check.choose)
        {
            case 0: //Level-1
                t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
                t_temp.text = "Please click on the pattern on the left to select the correct answer based on what you hear and from the options below.";
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("Image/Voice", typeof(Sprite)) as Sprite;
                break;
            case 1: //Level-2
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                break;
            case 2: //Level-3
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                break;
            case 3: //Level-4
                t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
                t_temp.text = "Please click on the pattern on the left to select the correct answer based on what you hear and from the options below.";
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("Image/Voice", typeof(Sprite)) as Sprite;
                break;
            case 4: //Level-5
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                break;
            case 5: //Level-6
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                break;
            case 6: //overall
                i_Temp = GameObject.Find("Image_Question").GetComponent<Image>();
                i_Temp.sprite = Resources.Load("", typeof(Sprite)) as Sprite;
                break;
            default:
                break;
        }
	}
    public void ClearAllText()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_LevelContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_AnswerContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_Question").GetComponent<Text>();
        t_temp.text = "";
    }
	
}
