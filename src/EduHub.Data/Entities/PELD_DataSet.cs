﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Employee Leave Details Data Set
    /// </summary>
    public sealed class PELD_DataSet : SetBase<PELD_Entity>
    {
        internal PELD_DataSet(EduHubContext Context)
            : base(Context)
        {
        }

        public override string SetName { get { return "PELD"; } }


        
        protected override Action<PELD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PELD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PLTKEY":
                        mapper[i] = (e, v) => e.PLTKEY = v;
                        break;
                    case "PEKEY":
                        mapper[i] = (e, v) => e.PEKEY = v;
                        break;
                    case "LEAVE_CODE":
                        mapper[i] = (e, v) => e.LEAVE_CODE = v;
                        break;
                    case "LEAVE_STARTDATE":
                        mapper[i] = (e, v) => e.LEAVE_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_CALC_DATE":
                        mapper[i] = (e, v) => e.LAST_CALC_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_ANNIV_DATE":
                        mapper[i] = (e, v) => e.LAST_ANNIV_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNIVERSARY_DATE":
                        mapper[i] = (e, v) => e.ANNIVERSARY_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LEAVE_ENT_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_ENT_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "LEAVE_PRORATA_HOURS":
                        mapper[i] = (e, v) => e.LEAVE_PRORATA_HOURS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PERIOD_LENGTH_STEP":
                        mapper[i] = (e, v) => e.PERIOD_LENGTH_STEP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "WORKED":
                        mapper[i] = (e, v) => e.WORKED = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "STANDARD":
                        mapper[i] = (e, v) => e.STANDARD = v == null ? (double?)null : double.Parse(v);
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
