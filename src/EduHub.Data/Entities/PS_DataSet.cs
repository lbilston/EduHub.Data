﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Pay Steps or Pay Class Data Set
    /// </summary>
    public sealed class PS_DataSet : SetBase<PS_Entity>
    {
        internal PS_DataSet(EduHubContext Context)
            : base(Context)
        {
            PSKEY_Index = new Lazy<Dictionary<short, PS_Entity>>(() => this.ToDictionary(e => e.PSKEY));
        }

        public override string SetName { get { return "PS"; } }

        private Lazy<Dictionary<short, PS_Entity>> PSKEY_Index;

        public PS_Entity FindByPSKEY(short Key)
        {
            PS_Entity result;
            if (PSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByPSKEY(short Key, out PS_Entity Value)
        {
            return PSKEY_Index.Value.TryGetValue(Key, out Value);
        }
        public PS_Entity TryFindByPSKEY(short Key)
        {
            PS_Entity result;
            if (PSKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<PS_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<PS_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "PSKEY":
                        mapper[i] = (e, v) => e.PSKEY = short.Parse(v);
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "PAY_TYPE":
                        mapper[i] = (e, v) => e.PAY_TYPE = v;
                        break;
                    case "EFFECTIVE_DATE":
                        mapper[i] = (e, v) => e.EFFECTIVE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ANNUAL_RATE":
                        mapper[i] = (e, v) => e.ANNUAL_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MONTHLY_RATE":
                        mapper[i] = (e, v) => e.MONTHLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FORTNIGHTLY_RATE":
                        mapper[i] = (e, v) => e.FORTNIGHTLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "WEEKLY_RATE":
                        mapper[i] = (e, v) => e.WEEKLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HOURLY_RATE":
                        mapper[i] = (e, v) => e.HOURLY_RATE = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_WEEKLY_HOURS":
                        mapper[i] = (e, v) => e.STD_WEEKLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STD_MONTHLY_HOURS":
                        mapper[i] = (e, v) => e.STD_MONTHLY_HOURS = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
