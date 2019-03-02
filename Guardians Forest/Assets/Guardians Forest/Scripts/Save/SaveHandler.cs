using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.Save
{
    [CreateAssetMenu(menuName = "EllGames/Save/SaveHandler", fileName = "SaveHandler")]
    public class SaveHandler : SerializedScriptableObject
    {
        [Title("Required")]
        [OdinSerialize, Required] Profile.SystemProfile m_SystemProfile;

        [Button("Save")]
        public void Save()
        {

        }

        [Button("Load")]
        public void Load()
        {

        }
    }
}