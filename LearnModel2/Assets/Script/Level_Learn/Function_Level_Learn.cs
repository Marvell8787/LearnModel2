using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Function_Level_Learn : MonoBehaviour {

    public void Choose_A()
    {
        Question_Chcek.Choose_Ans = "A";
        CheckAns(Question_Chcek.Choose_Ans);
    }
    public void Choose_B()
    {
        Question_Chcek.Choose_Ans = "B";
        CheckAns(Question_Chcek.Choose_Ans);
    }
    public void Choose_C()
    {
        Question_Chcek.Choose_Ans = "C";
        CheckAns(Question_Chcek.Choose_Ans);
    }
    public void CheckAns(string a)
    {

    }

}
