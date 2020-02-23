

using System;

namespace EVE.Commons
{
    /// <summary>
    /// The class includes all Sys Code constant defined in project 
    /// </summary>
    public sealed class EnumEvalType : StringEnumClass
    {
        public static readonly EnumEvalType Primary = new EnumEvalType("PRIMA");

        public static readonly EnumEvalType Teacher = new EnumEvalType("TEACH");

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        private EnumEvalType(String code)
            : base(code)
        {

        }
        
    }
}


