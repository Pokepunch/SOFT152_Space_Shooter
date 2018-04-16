﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundInit : MonoBehaviour
{
    public Sprite[] tiles;
    public GameObject backgroundObject;
    GameObject background_1;
    GameObject background_2;

    void Awake()
    {
        background_1 = Instantiate(backgroundObject, new Vector3(.1f, .0f, .0f), new Quaternion(.0f, .0f, .0f, .0f));
        background_1.GetComponent<SpriteRenderer>().sprite = tiles[0];
        background_2 = Instantiate(backgroundObject, new Vector3(background_1.transform.position.x + background_1.GetComponent<SpriteRenderer>().bounds.size.x, .0f), new Quaternion(.0f, .0f, .0f, .0f));
        background_2.GetComponent<SpriteRenderer>().sprite = tiles[0];
    }
}
