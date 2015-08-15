﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Report Usage Metadata Data Set
    /// </summary>
    public sealed class SCEN_RPT_DataSet : SetBase<SCEN_RPT_Entity>
    {
        private Lazy<Dictionary<int, SCEN_RPT_Entity>> ID_Index;

        internal SCEN_RPT_DataSet(EduHubContext Context)
            : base(Context)
        {
            ID_Index = new Lazy<Dictionary<int, SCEN_RPT_Entity>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SCEN_RPT"; } }

        /// <summary>
        /// Find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_RPT entities</exception>
        public SCEN_RPT_Entity FindByID(int Key)
        {
            SCEN_RPT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <param name="Value">Related SCEN_RPT entity</param>
        /// <returns>True if the SCEN_RPT Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_RPT_Entity Value)
        {
            return ID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_RPT by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_RPT</param>
        /// <returns>Related SCEN_RPT entity, or null if not found</returns>
        public SCEN_RPT_Entity TryFindByID(int Key)
        {
            SCEN_RPT_Entity result;
            if (ID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_RPT_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_RPT_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "PROG":
                        mapper[i] = (e, v) => e.PROG = v;
                        break;
                    case "PERIOD":
                        mapper[i] = (e, v) => e.PERIOD = v;
                        break;
                    case "REQUIREDPRINCIPALFIELD":
                        mapper[i] = (e, v) => e.REQUIREDPRINCIPALFIELD = v;
                        break;
                    case "ISPRIMARY":
                        mapper[i] = (e, v) => e.ISPRIMARY = v;
                        break;
                    case "ISPRIMARYSECONDARY":
                        mapper[i] = (e, v) => e.ISPRIMARYSECONDARY = v;
                        break;
                    case "ISSECONDARY":
                        mapper[i] = (e, v) => e.ISSECONDARY = v;
                        break;
                    case "ISLANGUAGE":
                        mapper[i] = (e, v) => e.ISLANGUAGE = v;
                        break;
                    case "ISSPECIAL":
                        mapper[i] = (e, v) => e.ISSPECIAL = v;
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
