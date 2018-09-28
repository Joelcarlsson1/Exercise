using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    public bool ifBool;
    public int value;
    void Start()
    {
        if (ifBool == true)
        {
            print("Ja");
        }
        else
        {
            print("Nej");
        }


    }

    // Update is called once per frame
    void Update()
    {
        // != inte lika med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och (shift6)
        // || eller (altgr <)
        //

        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Why you click E ma boi");
        }


        //if (value != 5 && ifBool == true)
        //{
        //    print("Majs är najs");
        //}
        //else if (value == 4)
        //{
        //    print("Ölpojke");
        //}
        //else if (value == 3)
        //{
        //    print("BOI");
        //}
        //else if (value == 2)
        //{
        //    print("BÖI");
        //}
        //else
        //{
        //    print("Hejsan svejsan");
        //}
    }

}