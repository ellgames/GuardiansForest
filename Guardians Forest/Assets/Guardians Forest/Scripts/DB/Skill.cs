using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.DB
{
    [CreateAssetMenu(menuName = "EllGames/DB/Skill", fileName = "Skill")]
    public class Skill : SerializedScriptableObject
    {
        [Title("Required")]
        [OdinSerialize, Required] Profile.SystemProfile m_SystemProfile;

        [Title("UI")]
        [OdinSerialize] Sprite m_Icon;

        [Title("Meta")]
        [OdinSerialize] SKILL_CATEGORY m_SkillCategory;
        public SKILL_CATEGORY SkillCategory
        {
            get { return m_SkillCategory; }
        }

        [Title("Basic")]
        [OdinSerialize] string m_SkillName_Jpn;
        public string SkillName_Jpn
        {
            get { return m_SkillName_Jpn; }
        }

        [OdinSerialize] string m_SkillName_Eng;
        public string SkillName_Eng
        {
            get { return m_SkillName_Eng; }
        }

        [OdinSerialize] string m_Description_Jpn;
        public string Description_Jpn
        {
            get { return m_Description_Jpn; }
        }

        [OdinSerialize] string m_Description_Eng;
        public string Description_Eng
        {
            get { return m_Description_Eng; }
        }

        [Title("Spec")]
        [OdinSerialize] int m_AddingDamage = 0;
        public int AddingDamage
        {
            get { return m_AddingDamage; }
        }

        [OdinSerialize] int m_CostMP = 0;
        public int CostMP
        {
            get { return m_CostMP; }
        }

        [OdinSerialize] float m_UsingTimeSec = 0f;
        public float UsingTimeSec
        {
            get { return m_UsingTimeSec; }
        }

        [OdinSerialize] float m_CoolTimeSec = 0f;
        public float CoolTimeSec
        {
            get { return m_CoolTimeSec; }
        }

        public string SkillName()
        {
            switch (m_SystemProfile.Language)
            {
                default:
                    return null;
                case LANGUAGE.Japanese:
                    return m_SkillName_Jpn;
                case LANGUAGE.English:
                    return m_SkillName_Eng;
            }
        }

        [Title("Developper")]
        [OdinSerialize, TextArea(3, 5)] string m_Memo;
    }
}