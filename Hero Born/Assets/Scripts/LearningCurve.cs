using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;


    // Start is called before the first frame update
    void Start()
    {
        //Character hero = new Character();
        //Character hero2 = new Character();
        //hero2.name = "Sir Krane the Brave";
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();
        ////hero2.Reset();




        //Character heroine = new Character("Agatha");
        //heroine.PrintStatsInfo();

        //Weapon huntingbow = new Weapon("Hunting Bow", 105);
        //Weapon warBow = huntingbow;

        //warBow.name = "War Bow";
        //warBow.damage = 155;
        //huntingbow.PrintWeaponStats();
        //warBow.PrintWeaponStats();


        //Paladin knight = new Paladin("Sir Arthur", huntingbow);
        //knight.PrintStatsInfo();


        //camTransform = this.GetComponent<Transform>();
        //Debug.Log(camTransform.localPosition);

       
        Debug.Log(GameObject.Find("Directional Light").GetComponent<Transform>().localPosition);

    }




    void Update()
    {

    }


}
