﻿using FRC.NetworkTables;
using FRC.NetworkTables.Interop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {

    NetworkTable orbSlamTable;
    NetworkTable tensorTable;

    // Start is called before the first frame update
    void Start() {
        NetworkTableInstance inst = NetworkTableInstance.Default;
        inst.StartClientTeam(2903);
        inst.StartDSClient();
        orbSlamTable = inst.GetTable("orbslam2");
        tensorTable = inst.GetTable("tensorflow");
    }

    // Update is called once per frame
    void Update() {
        float x = (float) orbSlamTable.GetEntry("xpos").GetDouble(0.0);
        float y = (float) orbSlamTable.GetEntry("ypos").GetDouble(0.0);
        float z = (float) orbSlamTable.GetEntry("zpos").GetDouble(0.0);
        gameObject.transform.position = new Vector3(x, y, z);
    }
}
