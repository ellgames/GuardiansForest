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
    public class SkillManager : SerializedMonoBehaviour
    {
        [Title("Required")]
        [OdinSerialize, Required] Exception.ExceptionHandler m_ExceptionHandler;
        [OdinSerialize, Required] Profile.PlayerProfile m_PlayerProfile;

        [Title("Settings")]
        [OdinSerialize] Dictionary<SKILL_CATEGORY, IUseSkillCommand> m_IUseSkillCommands = new Dictionary<SKILL_CATEGORY, IUseSkillCommand>();
        // TODO: こいつをDB.SkillをkeyにしてIUseSkillCommandを指定できるようにする

        public bool UseSkill(SKILL_CATEGORY category)
        {
            if (m_IUseSkillCommands == null) return false;
            if (m_IUseSkillCommands.Count == 0) return false;

            switch (category)
            {
                default:
                    m_ExceptionHandler.ThrowException(EXCEPTION_TYPE.UnregisteredSkillException);
                    return false;
                case SKILL_CATEGORY.FirstSkill:
                    Debug.Assert(m_IUseSkillCommands.ContainsKey(SKILL_CATEGORY.FirstSkill));
                    if (m_IUseSkillCommands[SKILL_CATEGORY.FirstSkill] == null) return false;
                    return m_IUseSkillCommands[SKILL_CATEGORY.FirstSkill].Execute();
                case SKILL_CATEGORY.SecondSkill:
                    Debug.Assert(m_IUseSkillCommands.ContainsKey(SKILL_CATEGORY.SecondSkill));
                    if (m_IUseSkillCommands[SKILL_CATEGORY.SecondSkill] == null) return false;
                    return m_IUseSkillCommands[SKILL_CATEGORY.SecondSkill].Execute();
                case SKILL_CATEGORY.ThirdSkill:
                    Debug.Assert(m_IUseSkillCommands.ContainsKey(SKILL_CATEGORY.ThirdSkill));
                    if (m_IUseSkillCommands[SKILL_CATEGORY.ThirdSkill] == null) return false;
                    return m_IUseSkillCommands[SKILL_CATEGORY.ThirdSkill].Execute();
                case SKILL_CATEGORY.FourthSkill:
                    Debug.Assert(m_IUseSkillCommands.ContainsKey(SKILL_CATEGORY.FourthSkill));
                    if (m_IUseSkillCommands[SKILL_CATEGORY.FourthSkill] == null) return false;
                    return m_IUseSkillCommands[SKILL_CATEGORY.FourthSkill].Execute();
                case SKILL_CATEGORY.FifthSkill:
                    Debug.Assert(m_IUseSkillCommands.ContainsKey(SKILL_CATEGORY.FifthSkill));
                    if (m_IUseSkillCommands[SKILL_CATEGORY.FifthSkill] == null) return false;
                    return m_IUseSkillCommands[SKILL_CATEGORY.FifthSkill].Execute();
            }
        }
    }
}