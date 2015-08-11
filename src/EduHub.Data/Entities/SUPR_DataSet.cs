﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subject Prerequisites Data Set
    /// </summary>
    public sealed class SUPR_DataSet : SetBase<SUPR_Entity>
    {
        internal SUPR_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SUPR"; } }


        
        protected override Action<SUPR_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SUPR_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SUPRKEY":
                        mapper[i] = (e, v) => e.SUPRKEY = v;
                        break;
                    case "PREREQUISITE":
                        mapper[i] = (e, v) => e.PREREQUISITE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
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
