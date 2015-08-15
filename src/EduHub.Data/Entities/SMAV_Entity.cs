﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Room Availablity Extras
    /// </summary>
    public class SMAV_Entity : EntityBase
    {
#region Navigation Property Cache
        private SM_Entity _ROOM_SM;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Room key [Uppercase Alphanumeric: u4]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// Day of timetable cycle [Integer (16bit signed nullable): i]
        /// </summary>
        public short? DAY_NUMBER { get; internal set; }
        /// <summary>
        /// Start time of availability [Date Time nullable: d]
        /// </summary>
        public DateTime? START_TIME { get; internal set; }
        /// <summary>
        /// Finish time of availability [Date Time nullable: d]
        /// </summary>
        public DateTime? END_TIME { get; internal set; }
        /// <summary>
        /// Exception date for emergency teachers [Date Time nullable: d]
        /// </summary>
        public DateTime? AVAILABLE_DATE { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [ROOM] => [SM_Entity].[ROOM]
        /// Room key
        /// </summary>
        public SM_Entity ROOM_SM {
            get
            {
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
