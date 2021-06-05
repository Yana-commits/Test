using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Gun.Models
{
    [CreateAssetMenu(menuName = "Models/Tank repository")]
    public class TankRepository : ScriptableObject
    {
        [SerializeField]
        private List<Corp> corpsList = new List<Corp>();

        [SerializeField]
        private List<Tower> towerList = new List<Tower>();

        [SerializeField]
        private Gun gun;
    }

    [Serializable]
    public class Corp
    {
        public float damageKoef;
        public float speed;
    }

    [Serializable]
    public class Tower
    {
        public float precision;
    }

    [Serializable]
    public class Gun
    {
        public GunType type;

        [SerializeField]
        private List<Rate> rateguns = new List<Rate>();

        [SerializeField]
        private List<Armour> armourguns = new List<Armour>();

    }

    [Serializable]
    public class TankGunType
    {

    }

    [Serializable]
    public class Rate: TankGunType
    {
        public float damager;
        public float lenth;
        public float mmm;
    }

    [Serializable]
    public class Armour : TankGunType
    {
        public float damager;
        public float lenth;
    }
}

public enum GunType
{
   RateGun,
   ArmourGun
}

