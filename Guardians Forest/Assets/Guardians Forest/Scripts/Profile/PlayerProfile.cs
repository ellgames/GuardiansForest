using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.Profile
{
    [CreateAssetMenu(menuName = "EllGames/Profile/PlayerProfile", fileName = "PlayerProfile")]
    public class PlayerProfile : SerializedScriptableObject, GameSystem.PlayerBehaviour.IDeadWatch
    {
        [Title("Required")]
        [OdinSerialize, Required] SystemProfile m_SystemProfile;

        [Title("Job")]
        [OdinSerialize] DB.Job m_DefaultJob;
        public DB.Job DefaultJob
        {
            get { return m_DefaultJob; }
        }

        [OdinSerialize] DB.Job m_CurrentJob;
        public DB.Job CurrentJob
        {
            get { return m_CurrentJob; }
        }

        [Title("Status")]
        [OdinSerialize] int m_HP;
        public int HP
        {
            get { return m_HP; }
        }

        [OdinSerialize] int m_MP;
        public int MP
        {
            get { return m_MP; }
        }

        [OdinSerialize] int m_ATK;
        public int ATK
        {
            get { return m_ATK; }
        }

        [OdinSerialize] int m_DEF;
        public int DEF
        {
            get { return m_DEF; }
        }

        public bool DecreaseMP(int amount)
        {
            if (m_MP - amount < 0) return false;
            else
            {
                m_MP -= amount;
                return true;
            }
        }

        bool GameSystem.PlayerBehaviour.IDeadWatch.IsDead()
        {
            return m_HP == 0;
        }
    }
}