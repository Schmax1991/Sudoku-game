using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main : MonoBehaviour
{
    public Text slot1,slot2,slot3,slot4,slot5,slot6,slot7,slot8,slot9;
    public int num1, num2, num3, num4, num5, num6, num7, num8, num9;
   public List<int> newArr1 = new List<int>{};
    


    void Start()
    {
        List<int> slot1Arr = new List<int>{1,2,3,4,5,6,7,8,9};
        

        System.Random random = new System.Random();
        for(int i = 0; i < 9; i++)
        {
            int num = slot1Arr[random.Next(0, slot1Arr.Count)];
            newArr1.Add(num);
            slot1Arr.Remove(num);

        }

        
    }

    
    void Update()
    {


        
       
    }

    public void Button(){
         foreach(var el in newArr1)
        Console.WriteLine(el);

        slot1.text = newArr1[0].ToString();
        slot2.text = newArr1[1].ToString();
        slot3.text = newArr1[2].ToString();
        slot4.text = newArr1[3].ToString();
        slot5.text = newArr1[4].ToString();
        slot6.text = newArr1[5].ToString();
        slot7.text = newArr1[6].ToString();
        slot8.text = newArr1[7].ToString();
        slot9.text = newArr1[8].ToString();
    }
}
