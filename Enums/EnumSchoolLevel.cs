using System;

namespace EVE.Commons
{
    public sealed class EnumSchoolLevel : StringEnumClass
    {
        public static readonly EnumSchoolLevel HighSchool = new EnumSchoolLevel("HISC");
        public static readonly EnumSchoolLevel JuniorHighSchool = new EnumSchoolLevel("JUHS");
        public static readonly EnumSchoolLevel PresSchool = new EnumSchoolLevel("PRES");
        public static readonly EnumSchoolLevel PrimarySchool = new EnumSchoolLevel("PRIM");

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        private EnumSchoolLevel(String code)
            : base(code)
        {

        }
        
    }
}


