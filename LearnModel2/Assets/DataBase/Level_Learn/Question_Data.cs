using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Threading;
static class Question_Chcek
{
    public static int Question_Num = 1;
    public static string Choose_Ans = "";
}

static class Question_Data{
    // Level
    public static string[] Question = new string[5] { "", "", "", "", "" };
    public static string[] Answer_r = new string[5] { "", "", "", "", "" };
    public static string[] Answer_c = new string[5] { "", "", "", "", "" };
    public static string[] FeedBack = new string[5] { "", "", "", "", ""};

    public static string[] Button_Ans = new string[3] { "", "", ""};

    public static Question_Class[] question_temp = new Question_Class[5];
    public static Vocabulary_Class[] vocabulary_temp = new Vocabulary_Class[10];



    public static void Question_Init()
    {
        Random.seed = System.Guid.NewGuid().GetHashCode();
        Vocabulary_Data.Vocabulary_Init();
        for(int i = 0; i < 10; i++)
        {
            vocabulary_temp[i] = Vocabulary_Data.Vocabulary_Get(i);
        }

        switch (Level_Check.choose)
        {
            case 0: //Level-1 
                Question_Vocabulary_Set(0,5);
                break;
            case 1: //Level-2 Listening 英翻中
                Question_Vocabulary_Set(0,5);
                break;
            case 2: //Level-3 
                break;
            case 3: //Level-4
                Question_Vocabulary_Set(5,10);
                break;
            case 4: //Level-5 Listening 英翻中
                Question_Vocabulary_Set(5,10);
                break;
            case 5: //Level-6
                break;
            case 6: //Overall
                break;
            default:
                break;
        }
    }
    public static void Question_Vocabulary_Set(int n1,int n2) //Level 1 2 4 5
    {
        for(int i= n1;i< n2; i++)
        {
            if (n1 < 5)
            {
                Question[i] = vocabulary_temp[i].GetE_Name();
                Answer_r[i] = vocabulary_temp[i].GetE_Name();
            }
            else
            {
                Question[i-5] = vocabulary_temp[i].GetE_Name();
                Answer_r[i-5] = vocabulary_temp[i].GetE_Name();
            }
        }
        QaARandomSequence(5);

        /*for(int i = 0; i < 5;i++)
        {
            Debug.Log(Question[i] + " ");
        }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Answer_r[i] + " ");
        }*/  //Check

        for(int i = 0; i < 5; i++)
        {
            question_temp[i] = new Question_Class(i+1, Question[i], Answer_r[i],"","");
        }
    }
    public static Question_Class Question_Get(int n)
    {
        return question_temp[n];
    }
    public static void QaARandomSequence(int total)
    {
        int r;
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            string temp = "";
            temp = Question[i];
            Question[i] = Question[r];
            Question[r] = temp;

            temp = Answer_r[i];
            Answer_r[i] = Answer_r[r];
            Answer_r[r] = temp;
        }
    }
    public static void ChangeButton_Ans(string s, int c)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Ans-" + (c+1).ToString()).GetComponent<Text>();
        t_temp.text = s;
        Button_Ans[c]=s;
    }
    public static void ChangeAnswer_c(string s, int c)
    {
        question_temp[c].ChangeAnswer_c(s);
    }
    public static void ChangeFeedBack(string s, int c)
    {
        question_temp[c].ChangeFeedBack(s);
    }

}
