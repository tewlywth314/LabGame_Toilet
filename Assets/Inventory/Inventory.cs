using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject itemtext;
    [SerializeField] GameObject Toothbrush;
    [SerializeField] GameObject ToothbrushOnGround;
    [SerializeField] GameObject Toothpaste;
    [SerializeField] GameObject Bowl;
    [SerializeField] GameObject Shaving;
    [SerializeField] GameObject ScrubberBrush;
    [SerializeField] GameObject ToiletSuction;
    [SerializeField] GameObject Comb;
    [SerializeField] GameObject Sprinkler;
    [SerializeField] GameObject DishwashingLiquid;
    [SerializeField] GameObject Sponge;
    [SerializeField] GameObject ShoePolish;
    [SerializeField] GameObject Fabric;
    [SerializeField] GameObject Soap;
    [SerializeField] GameObject Shampoo;
    [SerializeField] GameObject Closet;
    bool set = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            
            if (set == false)
            {
                set = true;
                canvas.SetActive(set);
            }
            else
            {
                set = false;
                canvas.SetActive(set);
            }
        }
        if(ToothbrushOnGround.activeSelf == false)
        {
            Toothbrush.SetActive(true);
        }
        else
        {
            
        }
    }
}
