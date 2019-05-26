using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Function_Level_Learn : MonoBehaviour {

    public void Choose_A()
    {
        Question_Check.Choose_Ans = "A";
        Question_Check.Choose_Ans_n = 0;
        Question_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(0);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    public void Choose_B()
    {
        Question_Check.Choose_Ans = "B";
        Question_Check.Choose_Ans_n = 1;
        Question_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(1);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    public void Choose_C()
    {
        Question_Check.Choose_Ans = "C";
        Question_Check.Choose_Ans_n = 2;
        Question_Check.Choose_Ans_Content = Question_Data.GetButton_Ans(2);
        //Debug.Log(Question_Check.Choose_Ans_Content);

        CheckAns();
    }
    public void Next()
    {
        Button b_temp;

        b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Ans-1").GetComponent<Button>();
        b_temp.interactable = true;
        b_temp = GameObject.Find("Button_Ans-2").GetComponent<Button>();
        b_temp.interactable = true;
        b_temp = GameObject.Find("Button_Ans-3").GetComponent<Button>();
        b_temp.interactable = true;

        if (Question_Check.Question_Num == 10)
        {

        }
        else
        {
            Question_Check.Question_Num++;
        }
    }
    public void CheckAns()
    {
        Text t_temp;
        Button b_temp;
        Question_Class question_temp = new Question_Class();
        Question_Data.ChangeAnswer_c(Question_Check.Choose_Ans, Question_Check.Question_Num);
        Question_Data.ChangeAnswer_c_Content(Question_Check.Choose_Ans_Content, Question_Check.Question_Num);

        question_temp = Question_Data.Question_Get(Question_Check.Question_Num);

        if(question_temp.GetAnswer_r() == question_temp.GetAnswer_c())
        {
            Question_Data.ChangeFeedBack("O", Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
            t_temp.text = "O";
            Question_Check.Score += 20;
        }
        else
        {
            Question_Data.ChangeFeedBack("X", Question_Check.Question_Num);
            t_temp = GameObject.Find("Text_FeedBack").GetComponent<Text>();
            t_temp.text = "X";
        }
        t_temp = GameObject.Find("Text_AnswerContent").GetComponent<Text>();
        t_temp.text = question_temp.GetAnswer_r();
        t_temp = GameObject.Find("Text_ScoreContent").GetComponent<Text>();
        t_temp.text = Question_Check.Score.ToString();

        b_temp = GameObject.Find("Button_Next").GetComponent<Button>();
        b_temp.interactable = true;
        b_temp = GameObject.Find("Button_Ans-1").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Ans-2").GetComponent<Button>();
        b_temp.interactable = false;
        b_temp = GameObject.Find("Button_Ans-3").GetComponent<Button>();
        b_temp.interactable = false;

        Debug.Log(question_temp.GetQuestion());
        Debug.Log(question_temp.GetAnswer_r());
        Debug.Log(question_temp.GetAnswer_r_Content());
        Debug.Log(question_temp.GetAnswer_c());
        Debug.Log(question_temp.GetAnswer_c_Content());
        Debug.Log(question_temp.GetFeedBack());


    }

}
