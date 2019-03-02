using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.Events;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using EllGames.GF.Meta;

namespace EllGames.GF.Exception
{
    [CreateAssetMenu(menuName = "EllGames/Exception/ExceptionHandler", fileName = "ExceptionHandler")]
    public class ExceptionHandler : SerializedScriptableObject
    {
        public void ThrowException(EXCEPTION_TYPE type)
        {
            switch (type)
            {
                case EXCEPTION_TYPE.UnregisteredSkillException:
                    Debug.Log("該当のスキルが登録されていません。");
                    return;
            }
        }
    }
}