using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Vive_Inputs : MonoBehaviour
{
    public SteamVR_Action_Boolean m_booleanAction;

    private void Awake()
    {
        m_booleanAction[SteamVR_Input_Sources.Any].onState += Test;
    }


    private void Test(SteamVR_Action_Boolean action, SteamVR_Input_Sources source)
    {
        GunShooter gunShooter = GetComponentInChildren<GunShooter>();
        gunShooter.AskShoot();
    }

}

