using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Question_Class{
    private string QuestionType = "";
    private string QuestionNum = "";
    private string Question = "";
    private string Answer = "";
    private string FeedBack = "";
    public Question_Class(string _QuestionType = "", string _QuestionNum = "", string _Question = "", string _Answer = "", string _FeedBack = "")
    {
        QuestionType = _QuestionType;
        QuestionNum = _QuestionNum;
        Question = _Question;
        Answer = _Answer;
        FeedBack = _FeedBack;
    }
    private string GetQuestionType()
    {
        return QuestionType;
    }
    private string GetQuestionNum()
    {
        return QuestionNum;
    }
    private string GetQuestion()
    {
        return Question;
    }
    private string GetAnswer()
    {
        return Answer;
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
