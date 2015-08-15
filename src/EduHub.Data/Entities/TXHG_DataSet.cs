﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Group Daily Attendance Records Data Set
    /// </summary>
    public sealed class TXHG_DataSet : SetBase<TXHG_Entity>
    {
        private Lazy<Dictionary<int, TXHG_Entity>> TXHG_ID_Index;

        internal TXHG_DataSet(EduHubContext Context)
            : base(Context)
        {
            TXHG_ID_Index = new Lazy<Dictionary<int, TXHG_Entity>>(() => this.ToDictionary(e => e.TXHG_ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "TXHG"; } }

        /// <summary>
        /// Find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">TXHG_ID value didn't match any TXHG entities</exception>
        public TXHG_Entity FindByTXHG_ID(int Key)
        {
            TXHG_Entity result;
            if (TXHG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <param name="Value">Related TXHG entity</param>
        /// <returns>True if the TXHG Entity is found</returns>
        public bool TryFindByTXHG_ID(int Key, out TXHG_Entity Value)
        {
            return TXHG_ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TXHG by TXHG_ID key field
        /// </summary>
        /// <param name="Key">TXHG_ID value used to find TXHG</param>
        /// <returns>Related TXHG entity, or null if not found</returns>
        public TXHG_Entity TryFindByTXHG_ID(int Key)
        {
            TXHG_Entity result;
            if (TXHG_ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TXHG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TXHG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TXHG_ID":
                        mapper[i] = (e, v) => e.TXHG_ID = int.Parse(v);
                        break;
                    case "TXHG_DATE":
                        mapper[i] = (e, v) => e.TXHG_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOME_GROUP":
                        mapper[i] = (e, v) => e.HOME_GROUP = v;
                        break;
                    case "AM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.AM_ROLL_MARKED = v;
                        break;
                    case "PM_ROLL_MARKED":
                        mapper[i] = (e, v) => e.PM_ROLL_MARKED = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}
