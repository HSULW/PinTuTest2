using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer5X5_New : MonoBehaviour
{
    public GameObject P1; //PinTu1
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;
    public GameObject P10;
    public GameObject P11;
    public GameObject P12;
    public GameObject P13;
    public GameObject P14;
    public GameObject P15;
    public GameObject P16;
    public GameObject P17;
    public GameObject P18;
    public GameObject P19;
    public GameObject P20;
    public GameObject P21;
    public GameObject P22;
    public GameObject P23;
    public GameObject P24;
    public GameObject P25;
    public GameObject SuccessPanel;
    public GameObject AlmostSuccessPanel;
    public GameObject FailPanel;

    public void check()
    {
        Vector3 Position1 = P1.transform.position;
        Vector3 Position2 = P2.transform.position;
        Vector3 Position3 = P3.transform.position;
        Vector3 Position4 = P4.transform.position;
        Vector3 Position5 = P5.transform.position;
        Vector3 Position6 = P6.transform.position;
        Vector3 Position7 = P7.transform.position;
        Vector3 Position8 = P8.transform.position;
        Vector3 Position9 = P9.transform.position;
        Vector3 Position10 = P10.transform.position;
        Vector3 Position11 = P11.transform.position;
        Vector3 Position12 = P12.transform.position;
        Vector3 Position13 = P13.transform.position;
        Vector3 Position14 = P14.transform.position;
        Vector3 Position15 = P15.transform.position;
        Vector3 Position16 = P16.transform.position;
        Vector3 Position17 = P17.transform.position;
        Vector3 Position18 = P18.transform.position;
        Vector3 Position19 = P19.transform.position;
        Vector3 Position20 = P20.transform.position;
        Vector3 Position21 = P21.transform.position;
        Vector3 Position22 = P22.transform.position;
        Vector3 Position23 = P23.transform.position;
        Vector3 Position24 = P24.transform.position;
        Vector3 Position25 = P25.transform.position;

        int correct = 0;

        if(Position1.x < Position2.x && Position1.y > Position6.y ){
            correct++;
        }
        if(Position2.x > Position1.x && Position2.x < Position3.x && Position2.y > Position7.y){
            correct++;
        }
        if(Position3.x > Position2.x && Position3.x < Position4.x && Position3.y > Position8.y){
            correct++;
        }
        if(Position4.x > Position3.x && Position4.x < Position5.x && Position4.y > Position9.y){
            correct++;
        }
        if(Position5.x > Position4.x && Position5.y > Position10.y){
            correct++;
        }
        if(Position6.x < Position7.x && Position6.y < Position1.y && Position6.y > Position11.y){
            correct++;
        }
        if(Position7.x < Position8.x && Position7.x > Position6.x && Position7.y < Position2.y && Position7.y > Position12.y){
            correct++;
        }
        if(Position8.x > Position7.x && Position8.x < Position9.x && Position8.y < Position3.y && Position8.y > Position13.y){
            correct++;
        }
        if(Position9.x < Position10.x && Position9.x > Position8.x && Position9.y < Position4.y && Position9.y > Position14.y){
            correct++;
        }
        if(Position10.x > Position9.x && Position10.y < Position5.y && Position10.y > Position15.y){
            correct++;
        }
        if(Position11.x < Position12.x && Position11.y < Position6.y && Position11.y > Position16.y){
            correct++;
        }
        if(Position12.x > Position11.x && Position12.x < Position13.x && Position12.y < Position7.y && Position12.y > Position17.y){
            correct++;
        }
        if(Position13.x < Position14.x && Position13.x > Position12.x && Position13.y < Position8.y && Position13.y > Position18.y){
            correct++;
        }
        if(Position14.x > Position13.x && Position14.x < Position15.x && Position14.y < Position9.y && Position14.y > Position19.y){
            correct++;
        }
        if(Position15.x > Position14.x && Position15.y < Position10.y && Position15.y > Position20.y){
            correct++;
        }
        if(Position16.x < Position17.x && Position16.y < Position11.y && Position16.y > Position21.y){
            correct++;
        }
        if(Position17.x < Position18.x && Position17.x > Position16.x && Position17.y < Position12.y && Position17.y > Position22.y){
            correct++;
        }
        if(Position18.x < Position19.x && Position18.x > Position17.x && Position18.y < Position13.y && Position18.y > Position23.y){
            correct++;
        }
        if(Position19.x < Position20.x && Position19.x > Position18.x && Position19.y < Position14.y && Position19.y > Position24.y){
            correct++;
        }
        if(Position20.x > Position19.x && Position20.y < Position15.y && Position20.y > Position25.y){
            correct++;
        }
        if(Position21.x < Position22.x && Position21.y < Position16.y){
            correct++;
        }
        if(Position22.x > Position21.x && Position22.x < Position23.x && Position22.y < Position17.y){
            correct++;
        }
        if(Position23.x > Position22.x && Position23.x < Position24.x && Position23.y < Position18.y){
            correct++;
        }
        if(Position24.x > Position23.x && Position24.x < Position25.x && Position24.y < Position19.y){
            correct++;
        }
        if(Position25.x > Position24.x && Position25.y < Position20.y){
            correct++;
        }

        if(correct == 25){
            //判斷拼圖間的距離有沒有小於0.2
            if((Position2.x - Position1.x) < 0.2 && (Position3.x - Position2.x) < 0.2 && (Position4.x - Position3.x) < 0.2 && (Position5.x - Position4.x) < 0.2 && (Position7.x - Position6.x) < 0.2 && (Position8.x - Position7.x) < 0.2 && (Position9.x - Position8.x) < 0.2 && (Position10.x - Position9.x) < 0.2 && (Position12.x - Position11.x) < 0.2 && (Position13.x - Position12.x) < 0.2 && (Position14.x - Position13.x) < 0.2 && (Position15.x - Position14.x) < 0.2  && (Position17.x - Position16.x) < 0.2  && (Position18.x - Position17.x) < 0.2 && (Position19.x - Position18.x) < 0.2  && (Position20.x - Position19.x) < 0.2  && (Position22.x - Position21.x) < 0.2  && (Position23.x - Position22.x) < 0.2 && (Position24.x - Position23.x) < 0.2 && (Position25.x - Position24.x) < 0.2 
            && (Position1.y - Position6.y) < 0.2 && (Position6.y - Position11.y) < 0.2 && (Position11.y - Position16.y) < 0.2 && (Position16.y - Position21.y) < 0.2 && (Position2.y - Position7.y) < 0.2 && (Position7.y - Position12.y) < 0.2 && (Position12.y - Position17.y) < 0.2  && (Position17.y - Position22.y) < 0.2 && (Position3.y - Position8.y) < 0.2 && (Position8.y - Position13.y) < 0.2 && (Position13.y - Position18.y) < 0.2 && (Position18.y - Position23.y) < 0.2 && (Position4.y - Position9.y) < 0.2 && (Position9.y - Position14.y) < 0.2 && (Position14.y - Position19.y) < 0.2 && (Position19.y - Position24.y) < 0.2 && (Position5.y - Position10.y) < 0.2 && (Position10.y - Position15.y) < 0.2 && (Position15.y - Position20.y) < 0.2 && (Position20.y - Position25.y) < 0.2){
                Debug.Log("拼圖正確");
                SuccessPanel.SetActive(true);
            }
            else{
                Debug.Log("相對位置對，但距離太遠");
                AlmostSuccessPanel.SetActive(true);
            }
        }
        else{
            Debug.Log("拼圖位置不正確，Correct為:" + correct);
            FailPanel.SetActive(true);
        }
    }
}
