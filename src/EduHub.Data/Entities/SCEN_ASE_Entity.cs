﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Student Excluded Data
    /// </summary>
    public class SCEN_ASE_Entity : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed): l]
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? ID_RETURN { get; internal set; }
        /// <summary>
        ///  [Integer (16bit signed nullable): i]
        /// </summary>
        public short? REGISTRATION { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ASE_TYPE { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string CREATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        ///  [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LUPDATEUSER { get; internal set; }
        /// <summary>
        ///  [Date Time nullable: d]
        /// </summary>
        public DateTime? LUPDATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}
