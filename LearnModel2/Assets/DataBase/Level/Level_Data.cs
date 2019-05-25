using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Level_Data{

    public static string[] Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] Level_QuestionType = new string[7] { "Listening", "Fill in the blanks", "Translation", "Listening", "Fill in the blanks", "Translation", "Spelling" };
    public static string[] Level_Range = new string[7] { "1-5", "1-5", "1-5", "6-10", "6-10", "6-10", "6-10" };
    public static string[] Level_Reward = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] Level_Punishment = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] Level_HighestScore = new string[7] { "0", "0", "0", "0", "0", "0", "0" };

    public static Level_Class[] level_temp = new Level_Class[7];

    public static void Level_Init()
    {
        //宣告 level_temp 陣列並加入資料 Start
        for (int i = 0; i < 7; i++)
        {
            level_temp[i] = new Level_Class(Level_Title[i], Level_QuestionType[i], Level_Range[i], Level_Reward[i], Level_Punishment[i], Level_HighestScore[i]);
        }
        //宣告 level_temp 陣列並加入資料 End
        //Debug.Log(learn_temp[2].GetTitle());
    }
    public static Level_Class Level_Get(int n)
    {
        return level_temp[n];
    }

}
