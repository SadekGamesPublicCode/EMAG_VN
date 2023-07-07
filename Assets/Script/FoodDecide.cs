using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDecide : MonoBehaviour
{
    public string foodName;
    private int randFood;
    public void FoodDecider()
    {
        randFood = Random.Range(0, 20);
        FoodStore(randFood);
        print(foodName + "in Food Decider script");
    }

    private string FoodStore(int foodOder)
    {
        switch (foodOder)
        {
            case 0:
                foodName = "Cơm Tấm";
                break;
            case 1:
                foodName = "Cơm Gà";
                break;
            case 2:
                foodName = "Cơm Chiên Gà Xối Mỡ";
                break;
            case 3:
                foodName = "Phở Bò";
                break;
            case 4:
                foodName = "Hủ Tiếu Nam Vang";
                break;
            case 5:
                foodName = "Bún Bò";
                break;
            case 6:
                foodName = "Bún Riêu";
                break;
            case 7:
                foodName = "Bún Dau Mắm Tom";
                break;
            case 8:
                foodName = "Phở Gà";
                break;
            case 9:
                foodName = "Bánh Mì";
                break;
            case 10:
                foodName = "Bò Né/Bít Tết";
                break;
            case 11:
                foodName = "Bún Mọc";
                break;
            case 12:
                foodName = "Bún Mắm";
                break;
            case 13:
                foodName = "Lẩu Thái";
                break;
            case 14:
                foodName = "Lẩu Mắm";
                break;
            case 15:
                foodName = "Hủ Tiếu MÌ Tàu";
                break;
            case 16:
                foodName = "Cơm Bò Cào";
                break;
            case 17:
                foodName = "Bánh Tráng Trộn";
                break;
            case 18:
                foodName = "MÌ xao";
                break;
            case 19:
                foodName = "Sủi Cảo";
                break;
            case 20:
                foodName = "Há Cảo";
                break;
        }

        return foodName;
    }
}
