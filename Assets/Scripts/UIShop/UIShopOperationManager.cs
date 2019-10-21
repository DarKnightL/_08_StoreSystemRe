using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopOperationManager : MonoBehaviour
{
    public UIGoodsPanel goodsPanel;
    public UIShopDataManager shopDataManager;




    public void OnBtnCloseClick(){
        UIShop.Instance.Hide();
    }


    public void SetData(){
        goodsPanel.SetData(shopDataManager.GetData());
    }


    public void OnBtnFreshClick(){
        TestServer.Instance.RefreshRequest();
    }






}
