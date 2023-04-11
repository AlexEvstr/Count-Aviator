using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.ScoreGame;
using Evstr.Background;

namespace Evstr.GUI
{
    public class UIFalseButton : UIBaseButton
    {
        [SerializeField] private GameObject _taskPanel;
        [SerializeField] private TaskManager _taskManager;

        public override void OnClick()
        {
            Score.timeIndex += 0.1f;
            BackgroundMove.speed -= 2f;
            _taskPanel.SetActive(false);
            _taskManager.SetNewTask();
        }
    }
}
