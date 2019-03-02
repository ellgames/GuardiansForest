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
    public class SwingCommand : SkillCommandBase
    {
        protected override void MainProcess()
        {
            Debug.Log("Swing.");
        }
    }
}