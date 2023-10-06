using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class FoodPanelSC : MonoBehaviour
{
    [SerializeField] Text SupportTxt;
    [SerializeField] Text FoodNameTxt;
    [SerializeField] Text hourTxt;
    [SerializeField] FoodDecide food;
    private void Start() => SettingStart();
    private void Update() => UpdateCurTime();
    void SettingStart() => SupportTxt.text = "Nếu không biết ăn gì, để ông trời quyết định!!!";
    public IEnumerator OnWaitToShow(GameObject gb, float timeToWait, bool show)
    {
        yield return new WaitForSeconds(timeToWait);
        gb.SetActive(show);
    }
    public void OnClickGenerateFood() => GetMeal();
    private void GetMeal()
    {
        food.FoodDecider();
        SupportTxt.text = "Chúc bạ may mắn thuyết phục được người yêu ăn món này nhé :))";
        FoodNameTxt.text = food.foodName;
    }
    void UpdateCurTime()
    {
        hourTxt.text = string.Format("{0:HH:mm:ss:ttt}", DateTime.Now);
    }
}