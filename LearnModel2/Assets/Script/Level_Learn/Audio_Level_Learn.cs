using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Level_Learn : MonoBehaviour {
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
    
    public void Voice()
    {
        if (Level_Check.choose == 1 || Level_Check.choose == 4)
            Play();
    }
    public void Play()
    {
        switch (0) //等題目出來記得來給
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
            case 5:
                depth.Play();
                break;
            case 6:
                luxury.Play();
                break;
            case 7:
                applause.Play();
                break;
            case 8:
                marathon.Play();
                break;
            case 9:
                electronic.Play();
                break;
            default:
                break;
        }
    }
}
