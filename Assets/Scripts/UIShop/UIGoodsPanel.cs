using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGoodsPanel : MonoBehaviour
{

    public NewObjectPooler objectPooler;

    public void SetData(List<DataClass.GoodData> datas)
    {
        objectPooler.Reset();
        for (int i = 0; i < datas.Count; i++)
        {
            GameObject obj = objectPooler.GetPooledGameObject();
            obj.SetActive(true);
            UIGoodItem item = obj.GetComponent<UIGoodItem>();
            item.SetData(datas[i]);
        }

    }
}
