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
    [CreateAssetMenu(menuName = "EllGames/Profile/ComboProfile", fileName = "ComboProfile")]
    public class ComboProfile : SerializedScriptableObject
    {
        [Title("Required")]
        [OdinSerialize, Required] SystemProfile m_SystemProfile;

        [Title("Combo")]
        [OdinSerialize] int m_ComboCount;
        public int ComboCount
        {
            get { return m_ComboCount; }
        }

        /// <summary>
        /// コンボを加算します。
        /// </summary>
        /// <returns>成功時にtrueを返し、失敗時にfalseを返します。</returns>
        public bool AddComboCount()
        {
            if (m_ComboCount + 1 > m_SystemProfile.MaxComboCount) return false;

            m_ComboCount++;

            return true;
        }

        /// <summary>
        /// コンボを0にします。
        /// </summary>
        public void SetZeroCombo()
        {
            m_ComboCount = 0;
        }
    }
}