using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static NotTheBees.Flower;
using System;

namespace NotTheBees
{
    public class Bee : MonoBehaviour
    {

        [SerializeField] BeeHive BirthHive;
        [SerializeField] Flower flowerObject;
        [SerializeField] System.Random random = new System.Random();
        NotTheBees.Flower[] array = new NotTheBees.Flower[8];


        public void Init(BeeHive hive)
        {

            hive = BirthHive; 

        }

        void CheckAnyFlower()
        {

            if (flowerObject.hasNectar == true) 
            {

                BirthHive.GiveNectar();

            }

        }

        private void MoveBee()
        {

            FindObjectsByType<Flower>(FindObjectsSortMode.None);

        }
  
    }

}

