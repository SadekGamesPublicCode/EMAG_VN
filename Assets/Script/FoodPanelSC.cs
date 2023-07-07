using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class FoodPanelSC : MonoBehaviour
{
    [SerializeField] Animation foodAnim;
    [SerializeField] Text SupportTxt;
    [SerializeField] FoodDecide food;

    DateTime now;
    private int countPlay;
    private void Start()
    {
       SettingStart();
    }
    private void Update()
    {
        now = DateTime.Now;
    }
    void SettingStart()
    {
        SupportTxt.text = "Nếu không biết ăn gì, để ông trời quyết định!!!";
    }
    public IEnumerator OnWaitToShow(GameObject gb, float timeToWait, bool show)
    {
        yield return new WaitForSeconds(timeToWait);
        gb.SetActive(show);
    }

    public void OnClickGenerateFood()
    {
        countPlay = 0;
        DoFoodAnim();
    }

    private void GetMeal()
    {
        food.FoodDecider();
        SupportTxt.text = "Ăn " + food.foodName + " nhé";
    }

    private void DoFoodAnim()
    {
        foodAnim.Play();
        GetMeal();
    }
}