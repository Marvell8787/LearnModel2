using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Question_Class{
    private int QuestionNum = 1;
    private string Question = "";
    private string Answer_r = ""; //正解
    private string Answer_c = ""; //使用者的答案
    private string FeedBack = "";
    public Question_Class(int _QuestionNum = 1, string _Question = "", string _Answer_r = "", string _Answer_c = "", string _FeedBack = "")
    {
        QuestionNum = _QuestionNum;
        Question = _Question;
        Answer_r = _Answer_r;
        Answer_c = _Answer_c;

        FeedBack = _FeedBack;
    }
    private int GetQuestionNum()
    {
        return QuestionNum;
    }
    private string GetQuestion()
    {
        return Question;
    }
    private string GetAnswer_r()
    {
        return Answer_r;
    }
    private string GetAnswer_c()
    {
        return Answer_c;
    }
    private string GetFeedBack()
    {
        return FeedBack;
    }
    private void ChangeFeedBack(string s)
    {
        FeedBack = s;
    }
}
