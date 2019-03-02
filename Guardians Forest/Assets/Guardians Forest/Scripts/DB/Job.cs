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
    [CreateAssetMenu(menuName = "EllGames/DB/Job", fileName = "Job")]
    public class Job : SerializedScriptableObject
    {
        [Title("Required")]
        [OdinSerialize, Required] Profile.SystemProfile m_SystemProfile;

        [Title("Settings")]
        [OdinSerialize] string m_JobName_JP;
        [OdinSerialize] string m_JobName_EN;
        public string JobName
        {
            get
            {
                switch (m_SystemProfile.Language)
                {
                    default:
                        return null;
                    case LANGUAGE.Japanese:
                        return m_JobName_JP;
                    case LANGUAGE.English:
                        return m_JobName_EN;
                }
            }
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

        [Title("Skill")]
        [OdinSerialize] DB.Skill m_FirstSkill;     
        public DB.Skill FirstSkill
        {
            get { return m_FirstSkill; }
        }

        [OdinSerialize] DB.Skill m_SecondSkill;
        public DB.Skill SecondSkill
        {
            get { return m_SecondSkill; }
        }

        [OdinSerialize] DB.Skill m_ThirdSkill;  
        public DB.Skill ThirdSkill
        {
            get { return m_ThirdSkill; }
        }

        [OdinSerialize] DB.Skill m_FourthSkill;     
        public DB.Skill FourthSkill
        {
            get { return m_FourthSkill; }
        }

        [OdinSerialize] DB.Skill m_FifthSkill;    
        public DB.Skill FifthSkill
        {
            get { return m_FifthSkill; }
        }

        [Title("Developper")]
        [OdinSerialize, TextArea(5, 10)] string m_Memo;
    }
}