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
    public abstract class SkillCommandBase : SerializedMonoBehaviour, IUseSkillCommand
    {
        [Title("Required")]
        [OdinSerialize, Required] Profile.PlayerProfile m_UserStatus;
        [OdinSerialize, Required] DB.Skill m_SkillData;
        [OdinSerialize, Required] IDeadWatch m_IDeadWatch;

        [Title("Info")]
        [OdinSerialize] float m_RemainingUsingTimeSec;
        [OdinSerialize] float m_RemainingCoolTimeSec;

        void ConsumeCost()
        {
            m_UserStatus.DecreaseMP(m_SkillData.CostMP);
        }

        /// <summary>
        /// コマンドを実行可能かどうか判定します。
        /// </summary>
        /// <returns></returns>
        public bool CanExecute()
        {
            if (m_UserStatus.MP < m_SkillData.CostMP) return false;
            if (m_RemainingUsingTimeSec > 0f) return false;
            if (m_RemainingCoolTimeSec > 0f) return false;
            if (m_IDeadWatch.IsDead()) return false;

            return true;
        }

        public void Initialize()
        {
            m_RemainingUsingTimeSec = 0f;
            m_RemainingCoolTimeSec = 0f;
        }

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        /// <returns>成功時にtrue、失敗時にfalseを返します。</returns>
        public bool Execute()
        {
            if (!CanExecute()) return false;

            ConsumeCost();
            m_RemainingUsingTimeSec = m_SkillData.UsingTimeSec;
            m_RemainingCoolTimeSec = m_SkillData.CoolTimeSec;
            MainProcess();

            return true;
        }

        protected abstract void MainProcess();

        private void Update()
        {
            m_RemainingUsingTimeSec -= Time.deltaTime;
            m_RemainingCoolTimeSec -= Time.deltaTime;

            if (m_RemainingUsingTimeSec < 0f) m_RemainingUsingTimeSec = 0f;
            if (m_RemainingCoolTimeSec < 0f) m_RemainingCoolTimeSec = 0f;
        }

        bool IUseSkillCommand.Execute()
        {
            return Execute();
        }
    }
}