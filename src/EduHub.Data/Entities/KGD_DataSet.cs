﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Year 9-12 Exit Destinations Data Set
    /// </summary>
    public sealed class KGD_DataSet : SetBase<KGD_Entity>
    {
        private Lazy<Dictionary<string, KGD_Entity>> KGDKEY_Index;

        internal KGD_DataSet(EduHubContext Context)
            : base(Context)
        {
            KGDKEY_Index = new Lazy<Dictionary<string, KGD_Entity>>(() => this.ToDictionary(e => e.KGDKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "KGD"; } }

        /// <summary>
        /// Find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KGDKEY value didn't match any KGD entities</exception>
        public KGD_Entity FindByKGDKEY(string Key)
        {
            KGD_Entity result;
            if (KGDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <param name="Value">Related KGD entity</param>
        /// <returns>True if the KGD Entity is found</returns>
        public bool TryFindByKGDKEY(string Key, out KGD_Entity Value)
        {
            return KGDKEY_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KGD by KGDKEY key field
        /// </summary>
        /// <param name="Key">KGDKEY value used to find KGD</param>
        /// <returns>Related KGD entity, or null if not found</returns>
        public KGD_Entity TryFindByKGDKEY(string Key)
        {
            KGD_Entity result;
            if (KGDKEY_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KGD_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KGD_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGDKEY":
                        mapper[i] = (e, v) => e.KGDKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "CATEGORY":
                        mapper[i] = (e, v) => e.CATEGORY = v;
                        break;
                    case "OPEN_CLOSED":
                        mapper[i] = (e, v) => e.OPEN_CLOSED = v;
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
