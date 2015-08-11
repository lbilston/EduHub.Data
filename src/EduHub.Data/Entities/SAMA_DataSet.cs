﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Association Member Attendances Data Set
    /// </summary>
    public sealed class SAMA_DataSet : SetBase<SAMA_Entity>
    {
        internal SAMA_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "SAMA"; } }


        
        protected override Action<SAMA_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SAMA_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SAMAKEY":
                        mapper[i] = (e, v) => e.SAMAKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "SCAM_TID":
                        mapper[i] = (e, v) => e.SCAM_TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ATTENDED":
                        mapper[i] = (e, v) => e.ATTENDED = v;
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
