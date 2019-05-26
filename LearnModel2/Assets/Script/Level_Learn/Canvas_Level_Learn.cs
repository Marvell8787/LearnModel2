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
        Question_Class[] question_temp = new Question_Class[5];
        int r,r1;

        Question_Data.Question_Init();
        Level_Data.Level_Init();
        ClearAllText();

        for (int i = 0; i < 5; i++)
        {
            question_temp[i] = Question_Data.Question_Get(i);
        }

        for (int i = 0; i < 7; i++)
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

                r = Random.Range(0, 3);
                for(int i = 0; i < 3;i++)
                {
                    if(r == i)
                        Question_Data.ChangeButton_Ans(question_temp[Question_Chcek.Question_Num].GetAnswer_r(), i);
                    else
                    {
                        r1 = Random.Range(0, 10);
                        while (true)
                        //{
                            Question_Data.ChangeButton_Ans(Question_bank.Vocabulary_Ans[r1], i);
                        //}
                    }
                }

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
        Question_Chcek.Question_Num = 1;
        t_temp = GameObject.Find("Text_QuestionNum").GetComponent<Text>();
        t_temp.text = Question_Chcek.Question_Num.ToString() + ".";


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
