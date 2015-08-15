﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// School Associations Data Set
    /// </summary>
    public sealed class SCA_DataSet : SetBase<SCA_Entity>
    {
        private Lazy<Dictionary<string, SCA_Entity>> SCAKEY_Index;

        internal SCA_DataSet(EduHubContext Context)
            : base(Context)
        {
            SCAKEY_Index = new Lazy<Dictionary<string, SCA_Entity>>(() => this.ToDictionary(e => e.SCAKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCA"; } }

        /// <summary>
        /// Find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SCAKEY value didn't match any SCA entities</exception>
        public SCA_Entity FindBySCAKEY(string Key)
        {
            SCA_Entity result;
            if (SCAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <param name="Value">Related SCA entity</param>
        /// <returns>True if the SCA Entity is found</returns>
        public bool TryFindBySCAKEY(string Key, out SCA_Entity Value)
        {
            return SCAKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCA by SCAKEY key field
        /// </summary>
        /// <param name="Key">SCAKEY value used to find SCA</param>
        /// <returns>Related SCA entity, or null if not found</returns>
        public SCA_Entity TryFindBySCAKEY(string Key)
        {
            SCA_Entity result;
            if (SCAKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCA_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SCAKEY":
                        mapper[i] = (e, v) => e.SCAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "FIRST_DATE":
                        mapper[i] = (e, v) => e.FIRST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DATE":
                        mapper[i] = (e, v) => e.LAST_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SCA_MEMO":
                        mapper[i] = (e, v) => e.SCA_MEMO = v;
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
