using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class saveLoad : MonoBehaviour {
    public static saveLoad saveAndLoad;
    // Use this for initialization
    void Start() {

    }
    void Awake() {

        loadGoldQnt();
        loadLighterQnt();
        loadTimerFreezeQnt();
        //loadappPurchased();

        saveAndLoad = this;
    }
    
        public void saveGold()
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Create(Application.persistentDataPath + "/sG.dat");

            saveManager saver = new saveManager();
            saver.coins = MoneyScript.moneys.coins;//things to save

            binary.Serialize(fStream, saver);
            fStream.Close();

        }
        public void savetimerQnt()
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Create(Application.persistentDataPath + "/sT.dat");

            saveManager saver = new saveManager();
            saver.timeFreezer = timeFreezerScript.tFreezer.timeFreezer;//things to save

            binary.Serialize(fStream, saver);
            fStream.Close();

        }

        public void saveLighterQnt()
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream fStream = File.Create(Application.persistentDataPath + "/sL.dat");

            saveManager saver = new saveManager();
            saver.lighter = LighterScript.lighters.lighter;//things to save

            binary.Serialize(fStream, saver);
            fStream.Close();

        }





          public void loadGoldQnt()
        {
            if (File.Exists(Application.persistentDataPath + "/sG.dat")) {
                BinaryFormatter binary = new BinaryFormatter();
                FileStream fStream = File.Open(Application.persistentDataPath + "/sG.dat", FileMode.Open);
                saveManager saver = (saveManager)binary.Deserialize(fStream);
                fStream.Close();
                MoneyScript.moneys.coins = saver.coins;//all sttuff to load
            }



        }
          public void loadTimerFreezeQnt()
        {
            if (File.Exists(Application.persistentDataPath + "/sT.dat")) {
                BinaryFormatter binary = new BinaryFormatter();
                FileStream fStream = File.Open(Application.persistentDataPath + "/sT.dat", FileMode.Open);
                saveManager saver = (saveManager)binary.Deserialize(fStream);
                fStream.Close();
                timeFreezerScript.tFreezer.timeFreezer = saver.timeFreezer;//all sttuff to load
            }
        }


           public void loadLighterQnt()
        {
            if (File.Exists(Application.persistentDataPath + "/sL.dat")) {
                BinaryFormatter binary = new BinaryFormatter();
                FileStream fStream = File.Open(Application.persistentDataPath + "/sL.dat", FileMode.Open);
                saveManager saver = (saveManager)binary.Deserialize(fStream);
                fStream.Close();
                LighterScript.lighters.lighter = saver.lighter;//things to save//all sttuff to load
            }
        }

  
        }
    [Serializable]
    class saveManager {
        public bool soundMode;
        public int coins;
        public int lighter;
        public int timeFreezer;

    }
//}
