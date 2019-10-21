using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestServer : MonoBehaviour
{
    #region SINGLETON
    static TestServer _instance;

    public static TestServer Instance
    {

        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }
    #endregion

    List<DataClass.GoodData> buyDatas = new List<DataClass.GoodData>();

    private void Start()
    {
        DataClass.GoodData data1 = new DataClass.GoodData();
        DataClass.GoodData data2 = new DataClass.GoodData();
        DataClass.GoodData data3 = new DataClass.GoodData();
        DataClass.GoodData data4 = new DataClass.GoodData();
        DataClass.GoodData data5 = new DataClass.GoodData();
        DataClass.GoodData data6 = new DataClass.GoodData();

        data1.name = "MerchandiseA";
        data1.id = "10001";
        data1.info = "ClickA";
        data1.isSelled = false;
        data1.price = 100;
        data1.icon = "A";

        data2.name = "MerchandiseB";
        data2.id = "10002";
        data2.info = "ClickB";
        data2.isSelled = false;
        data2.price = 150;
        data2.icon = "B";

        data3.name = "MerchandiseC";
        data3.id = "10003";
        data3.info = "ClickC";
        data3.isSelled = false;
        data3.price = 250;
        data3.icon = "C";

        data4.name = "MerchandiseA";
        data4.id = "10004";
        data4.info = "ClickA";
        data4.isSelled = true;
        data4.price = 300;
        data4.icon = "A";

        data5.name = "MerchandiseAAA";
        data5.id = "10005";
        data5.info = "TripleHappy";
        data5.isSelled = false;
        data5.price = 850;
        data5.icon = "B";

        data6.name = "MerchandiseABC";
        data6.id = "10006";
        data6.info = "ClickABC";
        data6.isSelled = false;
        data6.price = 150;
        data6.icon = "C";

        buyDatas.Add(data1);
        buyDatas.Add(data2);
        buyDatas.Add(data3);
        buyDatas.Add(data4);
        buyDatas.Add(data5);
        buyDatas.Add(data6);
    }


    public List<DataClass.GoodData> GetBuyDatas()
    {
        return buyDatas;
    }


    public void BuyGoodRequest(string id)
    {
        BuyGood(id);
        StartCoroutine(IBuyGoodResponse());
    }


    IEnumerator IBuyGoodResponse()
    {
        yield return new WaitForSeconds(2f);
        BuyGoodResponse();
    }


    void BuyGood(string id)
    {
        for (int i = 0; i < buyDatas.Count; i++)
        {
            if (id == buyDatas[i].id)
            {
                buyDatas[i].isSelled = true;
            }
        }

    }


    public void BuyGoodResponse()
    {
        Debug.Log("BuyCorrespondingGoods");
        UIShop.Instance.Show(GetBuyDatas());

    }



    public void RefreshRequest()
    {

        Debug.Log("SendRequest");
        StartCoroutine(IRefreshRequest());
    }


    IEnumerator IRefreshRequest()
    {

        yield return new WaitForSeconds(1.5f);
        RefreshResponse();
    }


    public void RefreshResponse()
    {
        Debug.Log("RefreshSent");
        UIShop.Instance.Show(GetDatas());
    }



    List<DataClass.GoodData> GetDatas()
    {

        List<DataClass.GoodData> datas = new List<DataClass.GoodData>();


        DataClass.GoodData data1 = new DataClass.GoodData();
        DataClass.GoodData data2 = new DataClass.GoodData();
        DataClass.GoodData data3 = new DataClass.GoodData();
        DataClass.GoodData data4 = new DataClass.GoodData();
        DataClass.GoodData data5 = new DataClass.GoodData();
        DataClass.GoodData data6 = new DataClass.GoodData();

        data1.name = "ShitA";
        data1.info = "SSA";
        data1.isSelled = false;
        data1.price = 130;
        data1.icon = "A";

        data2.name = "ShitBB";
        data2.info = "SSB";
        data2.isSelled = false;
        data2.price = 200;
        data2.icon = "C";

        data3.name = "ShitCC";
        data3.info = "SSC";
        data3.isSelled = false;
        data3.price = 250;
        data3.icon = "B";

        data4.name = "SHITDD";
        data4.info = "ClickDD";
        data4.isSelled = false;
        data4.price = 300;
        data4.icon = "A";

        data5.name = "SHITTriple3a";
        data5.info = "TripleHappyREAL?";
        data5.isSelled = false;
        data5.price = 850;
        data5.icon = "A";

        data6.name = "SHITQuadruple";
        data6.info = "QUadruple";
        data6.isSelled = false;
        data6.price = 300;
        data6.icon = "B";

        datas.Add(data1);
        datas.Add(data2);
        datas.Add(data3);
        datas.Add(data4);
        datas.Add(data5);
        datas.Add(data6);

        return datas;

    }



}
