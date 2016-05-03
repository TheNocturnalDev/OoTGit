using UnityEngine;
using System.Collections;
using System;

public class VarTracker : MonoBehaviour {
    public int devmode = 0;
    public int hp = 12;
    public int HeartCount = 3;
    public int mp = 100;
    public int keycount = 1;
    public int Location = 0;
    /* Loctions:
    0: Hyrule Field
    1: Kokiri Forest
    2: Lost Woods
    3: Kakariko Village
    4: Graveyard
    5: Goron Mountain
    6: Lake Hylia
    7: Lon Lon Ranch
    8: Market
    9: Castle Out
    */



	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject);
    }


    // Update is called once per frame
    void Update () {
        //Prevents Health from going over MAXHP
        int maxhp = HeartCount * 4;
        if (hp > maxhp)
        {
            hp = maxhp;
        }
	}

    public void devmodechange(int dev)
    {
        devmode = dev;
    }
}
