using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

namespace NotTheBees
{

    public class Flower : MonoBehaviour
    {
        [SerializeField] public GameObject FlowerObject = new GameObject();

        [SerializeField] public float nectarRate = 3f;

        [SerializeField] public bool hasNectar = false;

        [SerializeField] public Color NoNectar;

        [SerializeField] public Color Nectar;

        void Start()
        {
            FlowerObject.GetComponent<SpriteRenderer>();
            FlowerObject.GetComponent<SpriteRenderer>().material.color = NoNectar;

        }

        private void TimeCheck()
        {

            float nectarCountdown = 3;

            if (nectarCountdown > 0)
            {

                nectarCountdown -= Time.deltaTime;
                FlowerObject.GetComponent<SpriteRenderer>().material.color = NoNectar;
                hasNectar = false;

            }

            else
            {
                hasNectar = true;
                FlowerObject.GetComponent<SpriteRenderer>().material.color = Nectar;
                nectarCountdown = 3;
            }

        }

        private void Update()
        {

            TimeCheck();

        }

    }
}
