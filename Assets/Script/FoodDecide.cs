using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodDecide : MonoBehaviour
{
    [SerializeField] List<Sprite> litsFoodSprite = new List<Sprite>();
    [SerializeField] Image foodImg;
    [HideInInspector] 

    public string foodName;
    private int randFood;
    private void Start() => SetImage(0, 0);
    private void SetImage(int state, int randF) 
    {
        if (state == 0) { foodImg.GetComponent<Image>().sprite = litsFoodSprite[0]; }
        else if (state >= 1) { foodImg.GetComponent<Image>().sprite = litsFoodSprite[randF]; }
    }
    public void FoodDecider()
    {
        randFood = Random.Range(1, 23);
        FoodPooling(randFood);
        SetImage(randFood, randFood);
    }
    private string FoodPooling(int foodOder)
    {
        switch (foodOder)
        {
            case 1:
                foodName = "Cơm Tấm";
                break;
            case 2:
                foodName = "Cơm Gà";
                break;
            case 3:
                foodName = "Cơm Chiên Gà Xối Mỡ";
                break;
            case 4:
                foodName = "Phở Bò";
                break;
            case 5:
                foodName = "Hủ Tiếu Nam Vang";
                break;
            case 6:
                foodName = "Bún Bò";
                break;
            case 7:
                foodName = "Bún Riêu";
                break;
            case 8:
                foodName = "Bún Dau Mắm Tom";
                break;
            case 9:
                foodName = "Beefsteak";
                break;
            case 10:
                foodName = "Bánh Mì";
                break;
            case 11:
                foodName = "Bò Né/Bít Tết";
                break;
            case 12:
                foodName = "Bún Mọc";
                break;
            case 13:
                foodName = "Bún Mắm";
                break;
            case 14:
                foodName = "Bún Thái";
                break;
            case 15:
                foodName = "Bún Thịt Nướng";
                break;
            case 16:
                foodName = "Bánh Xèo";
                break;
            case 17:
                foodName = "Bột Chiên";
                break;
            case 18:
                foodName = "Bánh Tráng Trộn";
                break;
            case 19:
                foodName = "Bánh Bao";
                break;
            case 20:
                foodName = "Sủi Cảo";
                break;
            case 21:
                foodName = "Há Cảo";
                break;
            case 22:
                foodName = "Mì Ý";
                break;
            case 23:
                foodName = "Hamburger";
                break;
        }

        return foodName;
    }
}
