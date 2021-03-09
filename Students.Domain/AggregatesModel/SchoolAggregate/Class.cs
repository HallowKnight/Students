﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Students.Domain.AggregatesModel.UserAggregate;
using Students.Domain.Common;

namespace Students.Domain.AggregatesModel.SchoolAggregate
{
    public class Class : Entity
    {
        #region Contsructor

        public Class(int schoolId, string classTitle) 
        {
            _schoolId = schoolId;
            ClassTitle = !String.IsNullOrEmpty(classTitle) ? classTitle : throw new ArgumentNullException(classTitle);
        }

        #endregion

        public string ClassTitle { get; private set; }

        public int SchoolId => _schoolId;
        private int _schoolId;


        #region Relations

        public School School { get; private set; }

        public List<User> Users { get; private set; }

        #endregion


    }
}