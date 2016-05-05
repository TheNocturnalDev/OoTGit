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
    public int time = 0;
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


    /* Items Variables:
     0 = Not Equipped
     1 = equipped
     2 = Not Acquired
     3 = Not Available (Wrong time or area)
     */
    public int ITEMS = 666;
    public int Deku_Stick = 2;
    public int Deku_Nut = 2;
    public int Fairy_Slingshot = 2;
    public int Boomerang = 2;
    public int Bomb = 2;
    public int Bombchu = 2;
    public int Fairy_Bow = 2;
    public int Fire_Arrow = 2;
    public int Ice_Arrow = 2;
    public int Light_Arrow = 2;
    public int Fairy_Ocarina = 2;
    public int Ocarina_of_Time = 2;
    public int Hookshot = 2;
    public int Longshot = 2;
    public int Lens_of_Truth = 2;
    public int Dins_Fire = 2;
    public int Farores_Wind = 2;
    public int Nayrus_Love = 2;
    public int Magic_Beans = 2;
    public int Megaton_Hammer = 2;

    //EQUIPMENT
    public int EQUIPMENT = 666;
    public int Kokiri_Sword = 2;
    public int Master_Sword = 2;
    public int Biggoron_Sword = 2;
    public int Deku_Shield = 2;
    public int Hylian_Shield = 2;
    public int Mirror_Shield = 2;
    public int Kokiri_Tunic = 2;
    public int Goron_Tunic = 2;
    public int Zora_Tunic = 2;
    public int Kokiri_Boots = 1;
    public int Iron_Boots = 2;
    public int Hovor_Boots = 2;
    public int Gorons_Bracelet = 2;
    public int Silver_Gauntlets = 2;
    public int Golden_Gauntlets = 2;
    public int Silver_Scale = 2;
    public int Golden_Scale = 2;
    public int Giants_Knife = 2;
    //SPIRIT STONES
    public int SPIRIT_STONES = 666;
    public int Kokiris_Emerald = 2;
    public int Gorons_Ruby = 2;
    public int Zoras_Sapphire = 2;
    //MEDALLIONS
    
    public int MEDALLIONS = 666;
    public int Light_Medallion = 2;
    public int Forest_Medallion = 2;
    public int Fire_Medallion = 2;
    public int Water_Medallion = 2;
    public int Spirit_Medallion = 2;
    public int Shadow_Medallion = 2;
    //MASKS
    public int MASKS = 666;
    public int Keaton_Mask = 2;
    public int Skull_Mask = 2;
    public int Spooky_Mask = 2;
    public int Bunny_Hood = 2;
    public int Zora_Mask = 2;
    public int Goron_Mask = 2;
    public int Gerudo_Mask = 2;
    public int Mask_of_Truth = 2;
    //Bottle Stuff
    public int BOTTLESTUFF = 666;
    public int Bottle1 = 2;
    public int Bottle2 = 2;
    public int Bottle3 = 2;
    public int Bottle4 = 2;
    public int Red_Potion_Bottle1 = 2;
    public int Red_Potion_Bottle2 = 2;
    public int Red_Potion_Bottle3 = 2;
    public int Red_Potion_Bottle4 = 2;
    public int Green_Potions_Bottle1 = 2;
    public int Green_Potions_Bottle2 = 2;
    public int Green_Potions_Bottle3 = 2;
    public int Green_Potions_Bottle4 = 2;
    public int Blue_Potions_Bottle1 = 2;
    public int Blue_Potions_Bottle2 = 2;
    public int Blue_Potions_Bottle3 = 2;
    public int Blue_Potions_Bottle4 = 2;
    public int Lon_Lon_Milk_Bottle1 = 2;
    public int Lon_Lon_Milk_Bottle2 = 2;
    public int Lon_Lon_Milk_Bottle3 = 2;
    public int Lon_Lon_Milk_Bottle4 = 2;
    public int Lon_Lon_Milk_Half_Bottle1 = 2;
    public int Lon_Lon_Milk_Half_Bottle2 = 2;
    public int Lon_Lon_Milk_Half_Bottle3 = 2;
    public int Lon_Lon_Milk_Half_Bottle4 = 2;
    public int Fairy_Bottle1 = 2;
    public int Fairy_Bottle2 = 2;
    public int Fairy_Bottle3 = 2;
    public int Fairy_Bottle4 = 2;
    public int Bottled_Bugs_Bottle1 = 2;
    public int Bottled_Bugs_Bottle2 = 2;
    public int Bottled_Bugs_Bottle3 = 2;
    public int Bottled_Bugs_Bottle4 = 2;
    public int Fish_Bottle1 = 2;
    public int Fish_Bottle2 = 2;
    public int Fish_Bottle3 = 2;
    public int Fish_Bottle4 = 2;
    public int Poe_Soul_Bottle1 = 2;
    public int Poe_Soul_Bottle2 = 2;
    public int Poe_Soul_Bottle3 = 2;
    public int Poe_Soul_Bottle4 = 2;
    public int Big_Poe_Soul_Bottle1 = 2;
    public int Big_Poe_Soul_Bottle2 = 2;
    public int Big_Poe_Soul_Bottle3 = 2;
    public int Big_Poe_Soul_Bottle4 = 2;
    public int Blue_Fire_Bottle1 = 2;
    public int Blue_Fire_Bottle2 = 2;
    public int Blue_Fire_Bottle3 = 2;
    public int Blue_Fire_Bottle4 = 2;
    public int Letter_Bottle1 = 2;
    public int Letter_Bottle2 = 2;
    public int Letter_Bottle3 = 2;
    public int Letter_Bottle4 = 2;
    //TRADE ITEMS
    public int TRADE_ITEMS = 666;
    public int Pocket_Egg = 2;
    public int Pocket_Cucco = 2;
    public int Cojiro = 2;
    public int Odd_Mushroom = 2;
    public int Odd_Potion = 2;
    public int Poachers_Saw = 2;
    public int Broken_Goron_Sword = 2;
    public int Prescription = 2;
    public int Eyeball_Frog = 2;
    public int Eye_Drops = 2;
    public int Claim_Check = 2;
    //OTHER ITEMS
    public int OTHER_ITEMS = 666;
    public int Weird_Egg = 2;
    public int Cucco = 2;
    public int Zeldas_Letter = 2;
    public int Gerudo_Token = 2;
    public int Shard_of_Agony = 2;
    //Ammo ITems
    public int AMMO_ITEMS = 666;
    public int Max_Sling_Ammo = 30;
    public int Max_Bomb_Ammo = 10;
    public int Max_Arrow_Ammo = 20;
    public int Max_Ruppees = 99;


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
        if (time > 179)
        {
            time = 0;
        }
        
	}

    public void devmodechange(int dev)
    {
        devmode = dev;
    }
}
