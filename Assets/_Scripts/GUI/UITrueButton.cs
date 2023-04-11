using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.GUI
{
    public class UITrueButton : UIBaseButton
    {
        [SerializeField] private GameObject _taskPanel;
        [SerializeField] private TaskManager _taskManager;

        public override void OnClick()
        {
            Score.Score.timeIndex -= 0.3f;
            Background.BackgroundMove.speed += 5f;
            _taskPanel.SetActive(false);
            _taskManager.SetNewTask();
        }
    }
}
