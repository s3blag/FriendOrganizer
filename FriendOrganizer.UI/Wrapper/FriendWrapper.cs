﻿using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Wrapper
{
    public class FriendWrapper : ModelWrapper<Friend>
    {
        public FriendWrapper(Friend model) : base(model)
        {
        }

        public int Id { get { return Model.Id; } }

        public string FirstName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string LastName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        //private void ValidateProperty(string propertyName)
        //{
        //    ClearErrors(propertyName);
        //    switch(propertyName)
        //    {
        //        case nameof(FirstName):
        //            if(string.Equals(FirstName,"Robot",StringComparison.OrdinalIgnoreCase))
        //            {
        //                AddError(propertyName, "Robots are not valid friend");
        //            }
        //            break;
        //    }
        //}

        protected override IEnumerable<string> ValidateProperty(string propertyName)
        {
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return "Robots are not valid friend";
                    }
                    break;
            }
        }
        }
}
