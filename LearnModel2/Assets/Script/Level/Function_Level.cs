using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


static class Level_Check
{
    public static string s = "";
    public static int choose = 0;
}

public class Function_Level : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        ClearAllText();
    }
    //Button
    public void Back()
    {
        Application.LoadLevel("Learn");
    }
    public void Level_1()
    {
        Application.LoadLevel("Learn");
    }
    public void ClearAllText()
    {
        Text t_temp;
        t_temp = GameObject.Find("Text_QuestionTypeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RangeContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_RewardContent").GetComponent<Text>();
        t_temp.text = "";
        t_temp = GameObject.Find("Text_PunishmentContent").GetComponent<Text>();
        t_temp.text = "";
    }
}
