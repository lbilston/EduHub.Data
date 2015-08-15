﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Publications Data Set
    /// </summary>
    public sealed class SPU_DataSet : SetBase<SPU_Entity>
    {
        private Lazy<Dictionary<string, SPU_Entity>> SPUKEY_Index;

        internal SPU_DataSet(EduHubContext Context)
            : base(Context)
        {
            SPUKEY_Index = new Lazy<Dictionary<string, SPU_Entity>>(() => this.ToDictionary(e => e.SPUKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SPU"; } }

        /// <summary>
        /// Find SPU by SPUKEY key field
        /// </summary>
        /// <param name="Key">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">SPUKEY value didn't match any SPU entities</exception>
        public SPU_Entity FindBySPUKEY(string Key)
        {
            SPU_Entity result;
            if (SPUKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY key field
        /// </summary>
        /// <param name="Key">SPUKEY value used to find SPU</param>
        /// <param name="Value">Related SPU entity</param>
        /// <returns>True if the SPU Entity is found</returns>
        public bool TryFindBySPUKEY(string Key, out SPU_Entity Value)
        {
            return SPUKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SPU by SPUKEY key field
        /// </summary>
        /// <param name="Key">SPUKEY value used to find SPU</param>
        /// <returns>Related SPU entity, or null if not found</returns>
        public SPU_Entity TryFindBySPUKEY(string Key)
        {
            SPU_Entity result;
            if (SPUKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SPU_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SPU_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SPUKEY":
                        mapper[i] = (e, v) => e.SPUKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "TARGET":
                        mapper[i] = (e, v) => e.TARGET = v;
                        break;
                    case "LANGUAGE_INDICATOR":
                        mapper[i] = (e, v) => e.LANGUAGE_INDICATOR = v;
                        break;
                    case "MAILING_MECHANISM":
                        mapper[i] = (e, v) => e.MAILING_MECHANISM = v;
                        break;
                    case "PUBLICATION_TYPE":
                        mapper[i] = (e, v) => e.PUBLICATION_TYPE = v;
                        break;
                    case "ADDRESS_COMMENT":
                        mapper[i] = (e, v) => e.ADDRESS_COMMENT = v;
                        break;
                    case "STUDENT_SPECIFIC":
                        mapper[i] = (e, v) => e.STUDENT_SPECIFIC = v;
                        break;
                    case "MAILING_LIST":
                        mapper[i] = (e, v) => e.MAILING_LIST = v;
                        break;
                    case "ACTUAL_ELIGIBLE_MEMBERS":
                        mapper[i] = (e, v) => e.ACTUAL_ELIGIBLE_MEMBERS = v;
                        break;
                    case "HOME_LANGUAGE":
                        mapper[i] = (e, v) => e.HOME_LANGUAGE = v;
                        break;
                    case "PRIMARY_SORT":
                        mapper[i] = (e, v) => e.PRIMARY_SORT = v;
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
