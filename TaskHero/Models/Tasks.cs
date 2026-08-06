using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHero.Models
{
    public  class Tasks
    {
        private string _taskName;
        private string _description;
        private string _owner;

        private string _childId;
        private TaskStatusE _taskStatus = TaskStatusE.Pending;

        private int _reward;

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


        public Tasks(string taskName, string description, string owner, string childId)
        {
            _taskName = taskName;
            _description = description;
            _owner = owner;
            _childId = childId;
        }

    }
}
