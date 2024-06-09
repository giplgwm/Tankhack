using System;
using MelonLoader;
using UnityEngine;

namespace Tankhack
{
    public class Tankhax : MelonMod
    {
        public Rect windowRect = new Rect(20, 100, 200, 250);
        public override void OnGUI()
        {
            windowRect = GUI.Window(420024, windowRect, MakeGuiWork, "Tank Cheats");
        }

        public void MakeGuiWork(int windowID)
        {
            if (GUILayout.Button("Give Coins"))
            {
                GameObject player = GameObject.Find("Player(Clone)");
                TankPlayer tp = player.GetComponent<TankPlayer>();
                CoinWallet cw = player.GetComponent<CoinWallet>();
                cw.SpendCoins(-100000);
            }

            if (GUILayout.Button("Remove Treads"))
            {
                GameObject player = GameObject.Find("Player(Clone)");
                GameObject treads = player.transform.GetChild(0).gameObject;
                treads.SetActive(false);
            }
        }
    }
}
