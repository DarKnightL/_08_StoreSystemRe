﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObjectPooler : MonoBehaviour
{
    public GameObject _gameObject;          //需要创建的预制对象
    public int int_PooledAmount = 15;       //初始化数量
    public Transform _tranForm;             //放置预制对象的容器
    public bool bool_IsGrow = true;         //动态创建
    List<GameObject> _gameObjects;

    private void Awake()
    {
        _gameObjects = new List<GameObject>();

        for (int i = 0; i < int_PooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(_gameObject);
            obj.transform.SetParent(_tranForm);
            obj.transform.localScale = Vector3.one;
            obj.transform.position = _tranForm.position;
            obj.transform.rotation = _tranForm.rotation;
            obj.SetActive(false);
            _gameObjects.Add(obj);
        }
    }

    public void Reset()
    {
        for (int i = 0; i < _gameObjects.Count; i++)
        {
            _tranForm.GetChild(i).gameObject.SetActive(false);
        }
    }

    public GameObject GetPooledGameObject()
    {
        for (int i = 0; i < _gameObjects.Count; i++)
        {
            if (!_gameObjects[i].activeInHierarchy)
            {
                return _gameObjects[i];
            }
        }

        if (bool_IsGrow)
        {
            GameObject obj = (GameObject)Instantiate(_gameObject);
            obj.transform.SetParent(_tranForm);
            obj.transform.localScale = Vector3.one;
            obj.transform.position = _tranForm.position;
            obj.transform.rotation = _tranForm.rotation;
            _gameObjects.Add(obj);
            return obj;  
      }

        return null;
    }

}
