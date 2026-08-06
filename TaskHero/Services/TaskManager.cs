
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TaskHero.Models;

namespace TaskHero.Services
{
    public class TaskManager : INotifyPropertyChanged
    {
        private ObservableCollection<Tasks> _taskList = new ObservableCollection<Tasks>();
        private ObservableCollection<Tasks> _crtTask = new ObservableCollection<Tasks>();

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Tasks> CrtTask
        {
            get { return _crtTask; }
        }
        public TaskManager()
        {
            _taskList = new ObservableCollection<Tasks>
            {
                new Tasks("Clean Room", "take plates from the room", "Misha" , "ABC123")
                
            };
        }

        public void AddTask(Tasks task)
        {
            _taskList.Add(task);
        }
        public void GetTaskByOwner(string owner)
        { 
            _crtTask.Clear();
            if (_taskList.Count > 0)
            {
                foreach (Tasks task in _taskList) 
                {
                    if(task.Owner == owner)
                    {
                       _crtTask.Add(task);
                    }
                }
                
            }
            
            
        }

        public void GetTaskByChildren(string childrenId)
        {
            _crtTask.Clear();
            if (_taskList.Count > 0)
            {
                foreach (Tasks task in _taskList)
                {
                    if (task.ChildId == childrenId)
                    {
                        _crtTask.Add(task);
                    }
                }

            }
            
        }
        public void CompleteTask(Tasks task)
        {
            task.TaskStatusE = TaskStatusE.Completed;
        }

        public void ConfirmTask(Tasks task)
        {
            //adding a reward
            _taskList.Remove(task);
        }

        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
