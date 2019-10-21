using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public NewObjectPooler objectPooler;

	void Start () {
        objectPooler.Reset();
        List<DataClass.GoodData> datas = new List<DataClass.GoodData>();

        DataClass.GoodData data1 = new DataClass.GoodData();
        data1.name = "PRODUCTA";
        data1.info = "THIS IS A";
        data1.icon = "A";
        data1.price = 100;
        data1.isSelled = false;

        DataClass.GoodData data2 = new DataClass.GoodData();
        data2.name = "PRODUCTB";
        data2.info = "THIS IS B";
        data2.icon = "B";
        data2.price = 200;
        data2.isSelled = false;

        DataClass.GoodData data3 = new DataClass.GoodData();
        data3.name = "PRODUCTC";
        data3.info = "THIS IS C";
        data3.icon = "C";
        data3.price = 130;
        data3.isSelled = false;

        DataClass.GoodData data4 = new DataClass.GoodData();
        data4.name = "PRODUCTA";
        data4.info = "THIS IS A";
        data4.icon = "A";
        data4.price = 100;
        data4.isSelled = true;

        datas.Add(data1);
        datas.Add(data2);
        datas.Add(data3);
        datas.Add(data4);

        for (int i = 0; i < datas.Count; i++)
        {
            GameObject obj = objectPooler.GetPooledGameObject();
            obj.SetActive(true);
            UIGoodItem item = obj.GetComponent<UIGoodItem>();
            item.SetData(datas[i]);
        }

    }
	
}
