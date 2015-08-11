﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// General Ledger Programs Data Set
    /// </summary>
    public sealed class KGLPROG_DataSet : SetBase<KGLPROG_Entity>
    {
        internal KGLPROG_DataSet(EduHubContext Context)
            : base(Context)
        {
            GLPROGRAM_Index = new Lazy<Dictionary<string, KGLPROG_Entity>>(() => this.ToDictionary(e => e.GLPROGRAM));
        }

        public override string SetName { get { return "KGLPROG"; } }

        private Lazy<Dictionary<string, KGLPROG_Entity>> GLPROGRAM_Index;

        public KGLPROG_Entity FindByGLPROGRAM(string Key)
        {
            KGLPROG_Entity result;
            if (GLPROGRAM_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }
        public bool TryFindByGLPROGRAM(string Key, out KGLPROG_Entity Value)
        {
            return GLPROGRAM_Index.Value.TryGetValue(Key, out Value);
        }
        public KGLPROG_Entity TryFindByGLPROGRAM(string Key)
        {
            KGLPROG_Entity result;
            if (GLPROGRAM_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        protected override Action<KGLPROG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGLPROG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
