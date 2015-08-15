﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// eCASES21 Login Log Data Set
    /// </summary>
    public sealed class SEC_LLOG_DataSet : SetBase<SEC_LLOG_Entity>
    {
        private Lazy<Dictionary<int, SEC_LLOG_Entity>> LOGINLOGID_Index;

        internal SEC_LLOG_DataSet(EduHubContext Context)
            : base(Context)
        {
            LOGINLOGID_Index = new Lazy<Dictionary<int, SEC_LLOG_Entity>>(() => this.ToDictionary(e => e.LOGINLOGID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string SetName { get { return "SEC_LLOG"; } }

        /// <summary>
        /// Find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">LOGINLOGID value didn't match any SEC_LLOG entities</exception>
        public SEC_LLOG_Entity FindByLOGINLOGID(int Key)
        {
            SEC_LLOG_Entity result;
            if (LOGINLOGID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <param name="Value">Related SEC_LLOG entity</param>
        /// <returns>True if the SEC_LLOG Entity is found</returns>
        public bool TryFindByLOGINLOGID(int Key, out SEC_LLOG_Entity Value)
        {
            return LOGINLOGID_Index.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SEC_LLOG by LOGINLOGID key field
        /// </summary>
        /// <param name="Key">LOGINLOGID value used to find SEC_LLOG</param>
        /// <returns>Related SEC_LLOG entity, or null if not found</returns>
        public SEC_LLOG_Entity TryFindByLOGINLOGID(int Key)
        {
            SEC_LLOG_Entity result;
            if (LOGINLOGID_Index.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SEC_LLOG_Entity, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SEC_LLOG_Entity, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "LOGINLOGID":
                        mapper[i] = (e, v) => e.LOGINLOGID = int.Parse(v);
                        break;
                    case "SERVER":
                        mapper[i] = (e, v) => e.SERVER = v;
                        break;
                    case "VERSION":
                        mapper[i] = (e, v) => e.VERSION = v;
                        break;
                    case "USERID":
                        mapper[i] = (e, v) => e.USERID = v;
                        break;
                    case "USERNAME":
                        mapper[i] = (e, v) => e.USERNAME = v;
                        break;
                    case "BROWSER":
                        mapper[i] = (e, v) => e.BROWSER = v;
                        break;
                    case "SCREENSIZE":
                        mapper[i] = (e, v) => e.SCREENSIZE = v;
                        break;
                    case "RESULT":
                        mapper[i] = (e, v) => e.RESULT = v;
                        break;
                    case "IPADDRESS":
                        mapper[i] = (e, v) => e.IPADDRESS = v;
                        break;
                    case "SESSIONID":
                        mapper[i] = (e, v) => e.SESSIONID = v;
                        break;
                    case "LOGGEDOUT":
                        mapper[i] = (e, v) => e.LOGGEDOUT = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LOGINTIME":
                        mapper[i] = (e, v) => e.LOGINTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGOUTTIME":
                        mapper[i] = (e, v) => e.LOGOUTTIME = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LOGGEDPERIOD":
                        mapper[i] = (e, v) => e.LOGGEDPERIOD = v == null ? (short?)null : short.Parse(v);
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
