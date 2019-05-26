using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Threading;
static class Question_Chcek
{
    public static int Question_Num = 0;
}

    static class Question_Data{
    // Level
    public static string[] Question = new string[5] { "", "", "", "", "" };
    public static string[] Answer_r = new string[5] { "", "", "", "", "" };
    public static string[] Answer_c = new string[5] { "", "", "", "", "" };
    public static string[] FeedBack = new string[5] { "", "", "", "", ""};

    public static string[] Button_Ans = new string[3] { "", "", ""};

    public static Question_Class[] question_temp = new Question_Class[5];


    public static void Question_Init()
    {
        Vocabulary_Data.Vocabulary_Init();

        switch (Level_Check.choose)
        {
            case 0: //Level-1 
                break;
            case 1: //Level-2 Listening 英翻中
                break;
            case 2: //Level-3 
                break;
            case 3: //Level-4
                break;
            case 4: //Level-5 Listening 英翻中
                break;
            case 5: //Level-6
                break;
            case 6: //Overall
                break;
            default:
                break;
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
