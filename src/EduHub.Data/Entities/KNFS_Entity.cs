﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Family/Student ID Sequence Numbers
    /// </summary>
    public class KNFS_Entity : EntityBase
    {
        /// <summary>
        /// First 3 characters of Family/Student Name [Uppercase Alphanumeric: u3]
        /// </summary>
        public string KNFSKEY { get; internal set; }
        /// <summary>
        /// Next sequence number to be used [Uppercase Alphanumeric: u4]
        /// </summary>
        public string NEXT_NUMBER { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
