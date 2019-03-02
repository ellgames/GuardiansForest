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
    [CreateAssetMenu(menuName = "EllGames/Profile/SystemProfile", fileName = "SystemProfile")]
    public class SystemProfile : SerializedScriptableObject
    {
        [Title("Meta")]
        [OdinSerialize] LANGUAGE m_Language = LANGUAGE.Japanese;
        public LANGUAGE Language
        {
            get { return m_Language; }
            set { m_Language = value; }
        }

        [Title("Save")]
        [OdinSerialize] string m_DefaultSaveDirectory = "SaveData/";

        [Title("Battle")]
        [OdinSerialize] int m_MaxComboCount;
        public int MaxComboCount
        {
            get { return m_MaxComboCount; }
        }
    }
}