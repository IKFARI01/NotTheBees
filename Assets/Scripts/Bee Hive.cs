using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


namespace NotTheBees
{
    public class BeeHive : MonoBehaviour
    {

        [SerializeField] public GameObject BeeHiveObject = new GameObject();
        [SerializeField] public BeeHive beeHive = new BeeHive();

        int starterBees = 2;
        float honeyProduction = 3;
        int nectarAmount = 0;
        int HoneyAmount = 0;
        float timePassed;

        private void Start()
        {
            //Instantiates 5 starter bees
            for (int i = 0; i < starterBees; i++)
            {

                Instantiate(BeeHiveObject);
                i++;

            }

        }

        private void MakeHoney()
        {
            timePassed = -10;

            if (timePassed <= 0)
            {

                nectarAmount--;
                HoneyAmount++;

                if (nectarAmount > 0) { MakeHoney(); }

            }

        }

        public void GiveNectar()
        {

            nectarAmount++;
            MakeHoney();

        }

        private void Update()
        {

            if (nectarAmount > 0)
            {

                timePassed += Time.deltaTime;

                if (timePassed >= 0)
                {

                    nectarAmount--;
                    HoneyAmount++;

                    MakeHoney();

                }

            }

        }

    }
}
