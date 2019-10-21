using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnShop : MonoBehaviour
{
    List<DataClass.GoodData> datas = new List<DataClass.GoodData>();


    void Test()
    {
        DataClass.GoodData data1 = new DataClass.GoodData();
        DataClass.GoodData data2 = new DataClass.GoodData();
        DataClass.GoodData data3 = new DataClass.GoodData();
        DataClass.GoodData data4 = new DataClass.GoodData();
        DataClass.GoodData data5 = new DataClass.GoodData();
        DataClass.GoodData data6 = new DataClass.GoodData();

        data1.name = "MerchandiseA";
        data1.info = "ClickA";
        data1.isSelled = false;
        data1.price = 100;
        data1.icon = "A";

        data2.name = "MerchandiseB";
        data2.info = "ClickB";
        data2.isSelled = false;
        data2.price = 150;
        data2.icon = "B";

        data3.name = "MerchandiseC";
        data3.info = "ClickC";
        data3.isSelled = false;
        data3.price = 250;
        data3.icon = "C";

        data4.name = "MerchandiseA";
        data4.info = "ClickA";
        data4.isSelled = true;
        data4.price = 300;
        data4.icon = "A";

        data5.name = "MerchandiseAAA";
        data5.info = "TripleHappy";
        data5.isSelled = false;
        data5.price = 850;
        data5.icon = "B";

        data6.name = "MerchandiseABC";
        data6.info = "ClickABC";
        data6.isSelled = false;
        data6.price = 150;
        data6.icon = "C";

        datas.Add(data1);
        datas.Add(data2);
        datas.Add(data3);
        datas.Add(data4);
        datas.Add(data5);
        datas.Add(data6);

    }


    public void OnBtnClick()
    {
        Test();
        UIShop.Instance.Show(datas);
    }


    public void OnBtnClose(){

        UIShop.Instance.Hide();
    }

}
