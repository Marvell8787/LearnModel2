using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Level : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b_temp;
        int Avg = new int();
        Avg = 0;
        ClearAllText();
        b_temp = GameObject.Find("Button_Challenge").GetComponent<Button>();
        b_temp.interactable = false;

        Level_Class[] level_temp = new Level_Class[6];
        for (int i = 0; i < 6; i++)
        {
            level_temp[i] = Level_Data.Level_Get(i);
            Avg += int.Parse(level_temp[i].GetHighestScore());
        }
        b_temp = GameObject.Find("Button_Overall").GetComponent<Button>();
        if ((Avg / 6) > 80)
        {
            b_temp.interactable = true;
            //Debug.Log("On");
        }
        else
        {
            b_temp.interactable = false;
            //Debug.Log("Off");
        }
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
        t_temp = GameObject.Find("Text_HighestScoreContent").GetComponent<Text>();
        t_temp.text = "";
    }
}
