using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShop : MonoBehaviour
{
    #region SINGLETON
    static UIShop _instance;


    public static UIShop Instance
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

    public GameObject go_Menu;

    public UIShopDataManager shopDataManager;
    public UIShopOperationManager shopOperationManager;


    public void Show(List<DataClass.GoodData> datas)
    {
        go_Menu.SetActive(true);
        shopDataManager.SetData(datas);
        shopOperationManager.SetData();
    }


    public void Hide()
    {
        go_Menu.SetActive(false);
    }



}
