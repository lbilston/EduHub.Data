﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Awards and Prizes
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGW : EntityBase
    {

        #region Foreign Navigation Properties

        private IReadOnlyList<STMB> Cache_AWARD_STMB_AWARD;

        #endregion

        #region Field Properties

        /// <summary>
        /// Award code
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string AWARD { get; internal set; }

        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }

        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }

        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }

        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }

        #endregion

        #region Foreign Navigation Properties

        /// <summary>
        /// STMB (Student Merit Behaviour Details) related entities by [KGW.AWARD]-&gt;[STMB.AWARD]
        /// Award code
        /// </summary>
        public IReadOnlyList<STMB> AWARD_STMB_AWARD
        {
            get
            {
                if (Cache_AWARD_STMB_AWARD == null &&
                    !Context.STMB.TryFindByAWARD(AWARD, out Cache_AWARD_STMB_AWARD))
                {
                    Cache_AWARD_STMB_AWARD = new List<STMB>().AsReadOnly();
                }

                return Cache_AWARD_STMB_AWARD;
            }
        }

        #endregion

    }
}
