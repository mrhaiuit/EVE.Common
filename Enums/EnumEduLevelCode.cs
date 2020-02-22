
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EVE.Commons
{
    public sealed class EnumEduLevelCode : StringEnumClass
    {

        #region SYS CODE REF

        public static readonly EnumEduLevelCode Department = new EnumEduLevelCode("DEPARMENT");
        public static readonly EnumEduLevelCode Ministry = new EnumEduLevelCode("MINISTRY");
        public static readonly EnumEduLevelCode Province = new EnumEduLevelCode("PROVINCE");
        public static readonly EnumEduLevelCode School = new EnumEduLevelCode("SCHOOL");
        public static readonly EnumEduLevelCode TAdmin = new EnumEduLevelCode("TADMIN");

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        private EnumEduLevelCode(String code)
            : base(code)
        {

        }

        #endregion

    }
}
