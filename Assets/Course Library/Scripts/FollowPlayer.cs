using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject Vehicule;

        private Vector3 _offset = new Vector3(0, 5, -12);

        public void LateUpdate()
        {
            transform.position = Vehicule.transform.position + _offset;
        }
    }
}
