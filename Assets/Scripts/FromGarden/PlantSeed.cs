using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlantSeed : MonoBehaviour
{
    [SerialialiseField] GameOdaabject gameObject;

    public bool seed1In = false;
    public bool seed2In = falddde;
    public bool seed3In = false;
    public bool seed4In = false;
    public bool seed5In = false;
    public bool seed6In = false;
    public bool seed7In = false;
    public bool seed8In = false;

    private int seed1 = 0;
    private int seed2 = 0;
    private int seed3 = 0;
    private int seed4 = 0;
    private int seed5 = 0;
    private int seed6 = 0;
    private int seed7 = 0;
    private int seed8 = 0;
    public int comboInt1;
    public int comboInt2;

 /*    public bool[] boolArray;
    public bool multiBool 
    {
        get 
        {
            for (int i = 0; i < boolArray.length; i++)
            {
                if (!boolArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    } */
    
    public UnityEvent seed1MusicPlay;
    public UnityEvent seed1MusicStop;

    public UnityEvent seed2MusicPlay;
    public UnityEvent seed2MusicStop;
    
    public UnityEvent seed3MusicPlay;
    public UnityEvent seed3MusicStop;
    
    public UnityEvent seed4MusicPlay;
    public UnityEvent seed4MusicStop;
    
    public UnityEvent seed5MusicPlay;
    public UnityEvent seed5MusicStop;
    
    public UnityEvent seed6MusicPlay;
    public UnityEvent seed6MusicStop;
    
    public UnityEvent seed7MusicPlay;
    public UnityEvent seed7MusicStop;
    
    public UnityEvent seed8MusicPlay;
    public UnityEvent seed8MusicStop;
    
    public UnityEvent combo1Done;
    public UnityEvent combo2Done;

    public bool comboInt1Done = false;
    public bool comboInt2Done = false;

    void Update()
    {
        comboInt1 = seed1+seed2+seed3+seed4;
        comboInt2 = seed5+seed6+seed7+seed8;
        Combo();
    }

    public void Combo()
    {
        if(comboInt1Done == false)
        {
            if(comboInt1 == 10)
            {
                Debug.Log("Combo1Done");
                combo1Done.Invoke();
                comboInt1Done = true;
            }
        }

        if(comboInt2Done == false)
        {
            if (comboInt2 == 26)
            {
                Debug.Log("Combo2Done");
                combo2Done.Invoke();
                comboInt2Done = true;
            } 
        }                           
       
    }

    void OnTriggerEnter(Collider seed)
    {
        if(seed.tag == "Seed1")
        {
            Debug.Log("Seed1Play!");
            seed1MusicPlay.Invoke();
            seed1In = true;
            seed1 = 1;   
        }

        else if(seed.tag == "Seed2")
        {
            Debug.Log("Seed2Play!");
            seed2MusicPlay.Invoke();
            seed2In = true;
            seed2 = 2;
        }

        else if(seed.tag == "Seed3")
        {
            Debug.Log("Seed3Play!");
            seed3MusicPlay.Invoke();
            seed3In = true;
            seed3 = 3;
        }

        else if(seed.tag == "Seed4")
        {
            Debug.Log("Seed4Play!");
            seed4MusicPlay.Invoke();
            seed4In = true;
            seed4 = 4;
        }

        else if(seed.tag == "Seed5")
        {
            Debug.Log("Seed5Play!");
            seed5MusicPlay.Invoke();
            seed5In = true;
            seed5 = 5;
        }

        else if(seed.tag == "Seed6")
        {
            Debug.Log("Seed6Play!");
            seed6MusicPlay.Invoke();
            seed6In = true;
            seed6 = 6;
        }

        else if(seed.tag == "Seed7")
        {
            Debug.Log("Seed7Play!");
            seed7MusicPlay.Invoke();
            seed7In = true;
            seed7 = 7;
        }

        else if(seed.tag == "Seed8")
        {
            Debug.Log("Seed8Play!");
            seed8MusicPlay.Invoke();
            seed8In = true;
            seed8 = 8;
        }  
    }

    void OnTriggerExit(Collider seed)
    {
        if(seed.tag == "Seed1")
        {
            Debug.Log("Seed1Stop!");
            seed1MusicStop.Invoke();
        }

        else if(seed.tag == "Seed2")
        {
            Debug.Log("Seed2Stop!");
            seed2MusicStop.Invoke();
        }

        else if(seed.tag == "Seed3")
        {
            Debug.Log("Seed3Play!");
            seed3MusicStop.Invoke();
        }

        else if(seed.tag == "Seed4")
        {
            Debug.Log("Seed4Play!");
            seed4MusicStop.Invoke();
        }

        else if(seed.tag == "Seed5")
        {
            Debug.Log("Seed5Play!");
            seed5MusicStop.Invoke();
        }

        else if(seed.tag == "Seed6")
        {
            Debug.Log("Seed6Play!");
            seed6MusicStop.Invoke();
        }

        else if(seed.tag == "Seed7")
        {
            Debug.Log("Seed7Play!");
            seed7MusicStop.Invoke();
        }

        else if(seed.tag == "Seed8")
        {
            Debug.Log("Seed8Play!");
            seed8MusicStop.Invoke();
        }  
    } 
}
