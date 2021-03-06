﻿

using System;

namespace EVE.Commons
{
    /// <summary>
    /// The class includes all Sys Code constant defined in project 
    /// </summary>
    public sealed class EnumUserGroup : StringEnumClass
    {
        public static readonly EnumUserGroup EduDepartment = new EnumUserGroup("DEPT");

        public static readonly EnumUserGroup SchoolCombiner= new EnumUserGroup("GSCH");

        public static readonly EnumUserGroup SchoolIT = new EnumUserGroup("ITSC");

        public static readonly EnumUserGroup SystemIT = new EnumUserGroup("ITST");

        public static readonly EnumUserGroup EduMinistry = new EnumUserGroup("MNST");

        public static readonly EnumUserGroup SchoolPrimary = new EnumUserGroup("PRIN");

        public static readonly EnumUserGroup Officer = new EnumUserGroup("OFFI");

        public static readonly EnumUserGroup SubSchoolPrimary = new EnumUserGroup("SPRIN");

        public static readonly EnumUserGroup EduProvince = new EnumUserGroup("PROV");

        public static readonly EnumUserGroup SchoolTeacher = new EnumUserGroup("TEAC");

        public static readonly EnumUserGroup LeadSubject = new EnumUserGroup("TLEAD");

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        private EnumUserGroup(String code)
            : base(code)
        {

        }
        
    }
}


