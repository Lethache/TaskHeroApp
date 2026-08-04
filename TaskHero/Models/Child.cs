using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHero.Models 
{
    internal class Child :Account
    {
        private string _childCode;
        private string _parentId;
        private string _childName;

        public Child(string childName,string childCode , string parentId , AccessType accessType)
        {
            _childName = childName;
            _childCode = childCode;
            _parentId = parentId;
            _accessType = accessType;
        }
        public string ChildCode
        {
            get => _childCode;

        }

        public string ParentId
        {
            get => _parentId;
          
        }
    }
}
