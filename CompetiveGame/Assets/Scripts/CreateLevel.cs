﻿using UnityEngine;
using System.Collections;

public class CreateLevel : MonoBehaviour {
    public GameObject destructablePrefab;
    public Material Bottom;
    public Material Tier1;
    public Material Tier2;
    public Material TierFinal;
    public GameObject player1;
    public GameObject player2;
    private bool isInit = false;
    public int level = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(isInit)
        {
            return;
        }
        if(level == 1)
        { Level1(); }
        else if(level == 2)
        { Level2(); }
        else if(level == 3)
        { Level3(); }
        
        isInit = true;
    }
    //The hill
    void Level1()
    {
        //Generated code using external program
        int[][] Level1;
        Level1 = new int[40][];
        Level1[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level1[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level1[2] = new int[] { 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0 };
        Level1[3] = new int[] { 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 0, 0, 0 };
        Level1[4] = new int[] { 0, 0, 0, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 0, 0, 0 };
        Level1[5] = new int[] { 0, 0, 0, 3, 3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 2, 0, 0, 0 };
        Level1[6] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[7] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[8] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[9] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[10] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[11] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[12] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[13] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[14] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[15] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[16] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[17] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[18] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[19] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[20] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[21] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[22] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[23] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[24] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[25] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[26] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[27] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[28] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[29] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[30] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[31] = new int[] { 0, 0, 0, 3, 3, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 3, 2, 0, 0, 0 };
        Level1[32] = new int[] { 0, 0, 0, 3, 3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 2, 0, 0, 0 };
        Level1[33] = new int[] { 0, 0, 0, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 0, 0, 0 };
        Level1[34] = new int[] { 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 0, 0, 0 };
        Level1[35] = new int[] { 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 0, 0, 0 };
        Level1[36] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level1[37] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level1[38] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level1[39] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        CreateLevelFunc(Level1, 1.75f, new Vector3(0, 4, 0), new Vector3(14, 8, 36), new Vector3(55, 8, 36), new Vector3(0,90,0), new Vector3(0,-90,0));
    }

    //The Tower
    void Level2()
    {
        //Generated code using external program
        int[][] Level2;
        Level2 = new int[40][];
        Level2[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[2] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[3] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[4] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[5] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[6] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[7] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[8] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[9] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[10] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[11] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[12] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[13] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[14] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[15] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[16] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 1, 1, 1, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[17] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 4, 4, 4, 4, 4, 0, 0, 0, 1, 1, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[18] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0 };
        Level2[19] = new int[] { 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 7, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0 };
        Level2[20] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0 };
        Level2[21] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 1, 1, 1, 0, 0, 0, 4, 4, 4, 4, 4, 0, 0, 0, 1, 1, 1, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[22] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[23] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[24] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[25] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[26] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 3, 3, 3, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[27] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[28] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[29] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[30] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 1, 1, 1, 1, 1, 1, 1, 2, 3, 3, 3, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0 };
        Level2[31] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0 };
        Level2[32] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0 };
        Level2[33] = new int[] { 0, 0, 0, 0, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[34] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[35] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[36] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[37] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[38] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level2[39] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        CreateLevelFunc(Level2, 1.75f, new Vector3(0, 4, 0), new Vector3(34,9.2f,56.5f), new Vector3(33,9.2f,12.3f), new Vector3(0, 180, 0), new Vector3(0, 0, 0));
    }
    //The bridge
    void Level3()
    {
        //Generated code using external program
        int[][] Level3;
        Level3 = new int[40][];
        Level3[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level3[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level3[2] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level3[3] = new int[] { 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 0, 0, 0 };
        Level3[4] = new int[] { 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 0, 0, 0 };
        Level3[5] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1, 1, 1, 1, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 1, 1, 1, 1, 1, 2, 2, 2, 2, 0, 0, 0, 0 };
        Level3[6] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 0, 0, 0, 0 };
        Level3[7] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 0, 0, 0, 0 };
        Level3[8] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0 };
        Level3[9] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0 };
        Level3[10] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0 };
        Level3[11] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0 };
        Level3[12] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 0, 0, 0, 0, 0 };
        Level3[13] = new int[] { 0, 0, 0, 0, 0, 0, 1, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 1, 0, 0, 0, 0 };
        Level3[14] = new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 0, 0, 0 };
        Level3[15] = new int[] { 0, 0, 0, 0, 0, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 0, 1, 1, 1, 1, 1, 1, 2, 1, 1, 0, 0, 0 };
        Level3[16] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
        Level3[17] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
        Level3[18] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
        Level3[19] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
        Level3[20] = new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 };
        Level3[21] = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 };
        Level3[22] = new int[] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 };
        Level3[23] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[24] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[25] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[26] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[27] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[28] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[29] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[30] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 };
        Level3[31] = new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 0, 0, 0, 0, 0 };
        Level3[32] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 1, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 0, 0, 0, 0 };
        Level3[33] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 0, 0, 0, 0 };
        Level3[34] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 1, 1, 1, 0, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 0, 1, 1, 1, 2, 2, 2, 2, 2, 0, 0, 0, 0 };
        Level3[35] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 1, 1, 1, 1, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 1, 1, 1, 1, 2, 2, 2, 2, 2, 0, 0, 0, 0 };
        Level3[36] = new int[] { 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0 };
        Level3[37] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level3[38] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Level3[39] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        CreateLevelFunc(Level3, 1.75f, new Vector3(0, 4, 0), new Vector3(50, 9.2f, 36), new Vector3(21, 9.2f, 36), new Vector3(0, 270, 0), new Vector3(0, 90, 0));
    }

        void CreateLevelFunc(int[][] data, float scale, Vector3 startingPos, Vector3 play1pos, Vector3 play2pos, Vector3 rotation1, Vector3 rotation2)
    {
        Vector3 newScale = new Vector3(scale, scale, scale);
        for(int i = 0; i < data.Length; ++i)
        {
            for (int j = 0; data[i] != null && j < data[i].Length; ++j)
            {
                for (int k = 0; k < data[i][j]; ++k)
                {
                    Vector3 newPos = new Vector3(startingPos.x + (i * scale), startingPos.y + (k * scale), startingPos.z + (j * scale));
                    GameObject obj = (GameObject)Instantiate(destructablePrefab, newPos, Quaternion.identity);
                    obj.transform.localScale = newScale;
                    if (k == 0)
                    {
                        obj.GetComponent<MeshRenderer>().material = Bottom;
                    }
                    else if(k == 1)
                    {
                        obj.GetComponent<MeshRenderer>().material = Tier1;
                    }
                    else if(k == 2)
                    {
                        obj.GetComponent<MeshRenderer>().material = Tier2;
                    }
                    else
                    {
                        obj.GetComponent<MeshRenderer>().material = TierFinal;
                    }
                }
            }

        }
        player1.transform.position = play1pos;
        player1.transform.rotation = Quaternion.Euler(rotation1.x, rotation1.y, rotation1.z);

        player2.transform.position = play2pos;
        player2.transform.rotation = Quaternion.Euler(rotation2.x, rotation2.y, rotation2.z);

    }
}