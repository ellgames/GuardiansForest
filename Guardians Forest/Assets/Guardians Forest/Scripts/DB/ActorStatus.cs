using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.DB.Actor
{
    [CreateAssetMenu(menuName = "EllGames/DB/ActorStatus", fileName = "ActorStatus")]
    public class ActorStatus : SerializedScriptableObject
    {
        [Title("Basic")]
        [OdinSerialize] string m_ActorName = "Actor Name Here";
        public string ActorName
        {
            get { return m_ActorName; }
        }

        [Title("Advanced")]
        [OdinSerialize] bool m_IsBoss = false;
        public bool IsBoss
        {
            get { return m_IsBoss; }
        }

        [Title("Spec")]
        [OdinSerialize] int m_MaxHP = 1000;
        public int MaxHP
        {
            get { return m_MaxHP; }
        }

        [OdinSerialize] int m_MaxMP = 1000;
        public int MaxMP
        {
            get { return m_MaxMP; }
        }

        [OdinSerialize] int m_MaxATK = 100;
        public int MaxATK
        {
            get { return m_MaxATK; }
        }

        [OdinSerialize] int m_MaxDEF = 100;
        public int MaxDEF
        {
            get { return m_MaxDEF; }
        }

        [OdinSerialize] int m_HP = 1000;
        public int HP
        {
            get { return m_HP; }
        }

        [OdinSerialize] int m_MP = 1000;
        public int MP
        {
            get { return m_MP; }
        }

        [OdinSerialize] int m_ATK = 1;
        public int ATK
        {
            get { return m_ATK; }
        }

        [OdinSerialize] int m_DEF = 1;
        public int DEF
        {
            get { return m_DEF; }
        }
    }
}