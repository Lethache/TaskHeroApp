using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TaskHero.Models
{
    public  class Tasks : INotifyPropertyChanged 
    {
        private string _taskName;
        private string _description;
        private string _owner;

        public bool IsComplete
        {
            get { return _taskStatus == TaskStatusE.Completed; }
        }
        public bool IsExpanded
        {
            get { return _isExpanded; }
            set { _isExpanded = value; OnPropertyChanged(nameof(IsExpanded)); }
        }

        private string _childId;
        private TaskStatusE _taskStatus = TaskStatusE.Pending;

        private int _reward;
        private bool _isExpanded;

        public string TaskName
        {
            get { return _taskName; }

        }
        public string Description
        {
            get { return _description; }
        }
        public string Owner
        {
            get { return _owner; }
        }
        public string ChildId
        {
            get{ return _childId; }
        }
        public TaskStatusE TaskStatusE
        {
            get { return _taskStatus;}
            set { _taskStatus = value; }
        }
        public int Reward
        {
            get { return _reward;}
        }
        public string TaskStatusText
        {
            get { switch (TaskStatusE)
                {
                    case TaskStatusE.Pending: return "Pending"; 
                        break;
                    case TaskStatusE.Completed:
                        return "Completed";
                        break;
                    case TaskStatusE.Canceled:
                        return "Canceled";
                        break;

                    default: return "";
                }
            }
        }


        public Tasks(string taskName, string description, string owner, string childId)
        {
            _taskName = taskName;
            _description = description;
            _owner = owner;
            _childId = childId;
        }

        
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
