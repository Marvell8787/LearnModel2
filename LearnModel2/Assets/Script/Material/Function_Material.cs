using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
static class Material_Check
{
    public static string s = ""; //vocabulary
    public static int Choose = 0;
    
}

public class Function_Material : MonoBehaviour {

    public AudioSource implement; //implement
    public AudioSource helmet; //helmet
    public AudioSource assurance; //assurance
    public AudioSource lord; //lord
    public AudioSource contribute; //contribute
    public AudioSource depth; //depth
    public AudioSource luxury; //luxury
    public AudioSource applause; //applause
    public AudioSource marathon; //marathon
    public AudioSource electronic; //electronic


    // Use this for initialization
    void Start()
    {
        Vocabulary_Data.Vocabulary_Init();
        ShowContent(Material_Check.Choose);
    }
    public void Back()
    {
        Application.LoadLevel("Learn");
    }
    public void ShowContent(int n)
    {
        Text t_temp;
        Vocabulary_Class vocabulary_temp = new Vocabulary_Class();
        vocabulary_temp = Vocabulary_Data.Vocabulary_Get(n);

        t_temp = GameObject.Find("Text_E_Name").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetE_Name();
        t_temp = GameObject.Find("Text_C_Name").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetC_Name();


        t_temp = GameObject.Find("Text_PartOfSpeech").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetPartOfSpeech();
        t_temp = GameObject.Find("Text_Sentence").GetComponent<Text>();
        t_temp.text = vocabulary_temp.GetSentence();
    }
    public void Play()
    {
        switch (Material_Check.Choose)
        {
            case 0:
                implement.Play();
                break;
            case 1:
                helmet.Play();
                break;
            case 2:
                assurance.Play();
                break;
            case 3:
                lord.Play();
                break;
            case 4:
                contribute.Play();
                break;
            case 6:
                depth.Play();
                break;
            case 7:
                luxury.Play();
                break;
            case 8:
                applause.Play();
                break;
            case 9:
                marathon.Play();
                break;
            case 10:
                electronic.Play();
                break;
            default:
                break;
        }
    }


}
