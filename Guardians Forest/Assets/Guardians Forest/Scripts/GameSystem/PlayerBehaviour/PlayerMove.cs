using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.GameSystem.PlayerBehaviour
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMove : SerializedMonoBehaviour
    {
        // WayPointMove中に方向移動入力が入った場合、方向移動が優先されます。


        [Title("Required")]

        [Title("Ray")]
        [OdinSerialize] float m_Ray;

        [Title("Read Only")]
        [OdinSerialize, ReadOnly] bool m_MoveIsAllowed = true;

        CharacterController m_CharacterController;

        void MoveByWayPointMove()
        {

        }

        [Title("Buttons")]

        [Button("Allow Move")]
        public void AllowMove()
        {
            m_MoveIsAllowed = true;
        }

        [Button("Disallow Move")]
        public void DisallowMove()
        {
            Stop();

            m_MoveIsAllowed = false;
        }

        [Button("Stop")]
        public void Stop()
        {

        }

        [Button("Move Forward")]
        public void MoveForward()
        {

        }

        [Button("Move Backward")]
        public void MoveBackward()
        {

        }

        [Button("Move Right")]
        public void MoveRight()
        {

        }

        [Button("Move Left")]
        public void MoveLeft()
        {

        }

        private void Update()
        {
            Debug.Assert(m_CharacterController != null);
        }
    }
}