﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Threading;
static class Question_Check
{
    public static int Question_Num = 0;
    public static string Choose_Ans = "";
    public static string Choose_Ans_Content = "";
    public static int Choose_Ans_n = 0;
    public static int Score = 0;
}

static class Question_Data{
    // Level
    public static string[] Question = new string[5] { "", "", "", "", "" };
    public static string[] Answer_r = new string[5] { "", "", "", "", "" };
    public static string[] Answer_r_Content = new string[5] { "", "", "", "", "" };
    public static string[] Answer_c = new string[5] { "", "", "", "", "" };
    public static string[] Answer_c_Content = new string[5] { "", "", "", "", "" };
    public static string[] FeedBack = new string[5] { "", "", "", "", ""};

    public static string[] Button_Ans = new string[3] { "", "", ""};

    public static string[] Button_Ans_Check = new string[3] { "A", "B", "C" };

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
        //要弄中文的題庫
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
                Answer_r_Content[i] = vocabulary_temp[i].GetE_Name();
            }
            else
            {
                Question[i-5] = vocabulary_temp[i].GetE_Name();
                Answer_r_Content[i-5] = vocabulary_temp[i].GetE_Name();
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
            question_temp[i] = new Question_Class(i+1, Question[i],"", Answer_r_Content[i],"","","");
        }
    }
    public static void Button_Ans_Set()
    {
        //選項設定START
        int r = 0;
        r = Random.Range(0, 3);
        //亂數陣列 START
        int[] rand = new int[10];
        int c = 0;
        //亂數陣列 END
        for (int i = 0; i < 3; i++)
        {
            if (r == i)
            {
                ChangeButton_Ans(question_temp[Question_Check.Question_Num].GetAnswer_r_Content(), i);
                ChangeAnswer_r(Button_Ans_Check[r], Question_Check.Question_Num); //設定正解ABC END
            }
            else
            {
                rand = GetRandomSequence(10);
                while (true)
                {
                    if (Question_bank.Vocabulary_Ans[rand[c]] == (question_temp[Question_Check.Question_Num].GetQuestion())) { c++; continue; }
                    ChangeButton_Ans(Question_bank.Vocabulary_Ans[rand[c]], i);
                    c++;
                    break;
                }
            }
        }
        //選項設定 END
    }
    public static Question_Class Question_Get(int n)
    {
        return question_temp[n];
    }

    public static string GetButton_Ans(int c)
    {
        return Button_Ans[c];
    }
    public static void ChangeButton_Ans(string s, int c)
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_Ans-" + (c+1).ToString()).GetComponent<Text>();
        t_temp.text = s;
        Button_Ans[c]=s;
    }
    public static void ChangeAnswer_r(string s, int c)
    {
        question_temp[c].ChangeAnswer_r(s);
    }
    public static void ChangeAnswer_c(string s, int c)
    {
        question_temp[c].ChangeAnswer_c(s);
    }
    public static void ChangeAnswer_c_Content(string s, int c)
    {
        question_temp[c].ChangeAnswer_c_Content(s);
    }
    public static void ChangeFeedBack(string s, int c)
    {
        question_temp[c].ChangeFeedBack(s);
    }
    //亂數函式
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

            temp = Answer_r_Content[i];
            Answer_r_Content[i] = Answer_r_Content[r];
            Answer_r_Content[r] = temp;
        }
    }
    public static int[] GetRandomSequence(int total)
    {
        int r;
        int[] output = new int[total];
        for (int i = 0; i < total; i++)
        {
            output[i] = i;
        }
        for (int i = 0; i < total; i++)
        {
            r = Random.Range(0, total);
            int temp = 0;
            temp = output[i];
            output[i] = output[r];
            output[r] = temp;
        }
        return output;
    }
}
