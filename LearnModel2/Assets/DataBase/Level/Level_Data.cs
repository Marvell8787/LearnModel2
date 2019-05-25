using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Data : MonoBehaviour {

    public static string[] Level_Title = new string[7] { "Level-1", "Level-2", "Level-3", "Level-4", "Level-5", "Level-6", "Overall" };
    public static string[] Level_QuestionType = new string[7] { "None", "Level-1's Over", "Level-2's Over", "Level-3's Over", "Level 4's Over", "Level 5's Over", "Level 1~6're Over" };
    public static string[] Level_Range = new string[7] { "1-10", "1-10", "1-10", "1-10", "1-10", "1-10", "1-10" };
    public static string[] Level_Reward = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };
    public static string[] Level_Punishment = new string[7] { "Money", "Money", "Money", "Money", "Money", "Money", "Money" };

    // Use this for initialization
    void Start () {
		
	}
}
