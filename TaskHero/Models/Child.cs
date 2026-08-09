using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHero.Models 
{
    public class Child :Account
    {
        private string _childNickName;
        private string _parentId;
        private string _childName;

        public Child(string childName,string childNickName, string parentId )
        {
            _childName = childName;
            _childNickName = childNickName;
            _parentId = parentId;
            
        }
        public string ChildNickName
        {
            get => _childNickName;

        }

        public string ParentId
        {
            get => _parentId;
          
        }
        public string ChildName { get => _childName; }
    }
}
