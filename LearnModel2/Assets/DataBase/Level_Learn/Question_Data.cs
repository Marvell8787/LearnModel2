using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

static class Question_Data{
    public static string[] Question_QuestionType = new string[7] { "Listening", "Fill in the blanks", "Translation", "Listening", "Fill in the blanks", "Translation", "Spelling" };
    public static string[] Question_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] Question_Range = new string[7] { "1-5", "1-5", "1-5", "6-10", "6-10", "6-10", "6-10" };
    public static string[] Question_Reward = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] Question_Punishment = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] Question_HighestScore = new string[7] { "0", "0", "0", "0", "0", "0", "0" };
}
