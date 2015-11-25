﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Last Years General Ledger Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class GLPREVDataSet : SetBase<GLPREV>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "GLPREV"; } }

        internal GLPREVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, GLPREV>>(() => this.ToDictionary(i => i.CODE));
            Index_GL_TYPE = new Lazy<NullDictionary<string, IReadOnlyList<GLPREV>>>(() => this.ToGroupedNullDictionary(i => i.GL_TYPE));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="GLPREV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="GLPREV" /> fields for each CSV column header</returns>
        protected override Action<GLPREV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<GLPREV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LYROPBAL":
                        mapper[i] = (e, v) => e.LYROPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR01":
                        mapper[i] = (e, v) => e.LASTYR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR02":
                        mapper[i] = (e, v) => e.LASTYR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR03":
                        mapper[i] = (e, v) => e.LASTYR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR04":
                        mapper[i] = (e, v) => e.LASTYR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR05":
                        mapper[i] = (e, v) => e.LASTYR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR06":
                        mapper[i] = (e, v) => e.LASTYR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR07":
                        mapper[i] = (e, v) => e.LASTYR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR08":
                        mapper[i] = (e, v) => e.LASTYR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR09":
                        mapper[i] = (e, v) => e.LASTYR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR10":
                        mapper[i] = (e, v) => e.LASTYR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR11":
                        mapper[i] = (e, v) => e.LASTYR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTYR12":
                        mapper[i] = (e, v) => e.LASTYR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR01":
                        mapper[i] = (e, v) => e.CURR01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR02":
                        mapper[i] = (e, v) => e.CURR02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR03":
                        mapper[i] = (e, v) => e.CURR03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR04":
                        mapper[i] = (e, v) => e.CURR04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR05":
                        mapper[i] = (e, v) => e.CURR05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR06":
                        mapper[i] = (e, v) => e.CURR06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR07":
                        mapper[i] = (e, v) => e.CURR07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR08":
                        mapper[i] = (e, v) => e.CURR08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR09":
                        mapper[i] = (e, v) => e.CURR09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR10":
                        mapper[i] = (e, v) => e.CURR10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR11":
                        mapper[i] = (e, v) => e.CURR11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CURR12":
                        mapper[i] = (e, v) => e.CURR12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG01":
                        mapper[i] = (e, v) => e.BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG02":
                        mapper[i] = (e, v) => e.BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG03":
                        mapper[i] = (e, v) => e.BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG04":
                        mapper[i] = (e, v) => e.BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG05":
                        mapper[i] = (e, v) => e.BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG06":
                        mapper[i] = (e, v) => e.BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG07":
                        mapper[i] = (e, v) => e.BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG08":
                        mapper[i] = (e, v) => e.BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG09":
                        mapper[i] = (e, v) => e.BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG10":
                        mapper[i] = (e, v) => e.BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG11":
                        mapper[i] = (e, v) => e.BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "BUDG12":
                        mapper[i] = (e, v) => e.BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG01":
                        mapper[i] = (e, v) => e.NEXTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG02":
                        mapper[i] = (e, v) => e.NEXTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG03":
                        mapper[i] = (e, v) => e.NEXTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG04":
                        mapper[i] = (e, v) => e.NEXTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG05":
                        mapper[i] = (e, v) => e.NEXTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG06":
                        mapper[i] = (e, v) => e.NEXTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG07":
                        mapper[i] = (e, v) => e.NEXTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG08":
                        mapper[i] = (e, v) => e.NEXTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG09":
                        mapper[i] = (e, v) => e.NEXTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG10":
                        mapper[i] = (e, v) => e.NEXTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG11":
                        mapper[i] = (e, v) => e.NEXTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXTBUDG12":
                        mapper[i] = (e, v) => e.NEXTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ANNUALBUDG":
                        mapper[i] = (e, v) => e.ANNUALBUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "NEXT_ANN_BUDG":
                        mapper[i] = (e, v) => e.NEXT_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_ANN_BUDG":
                        mapper[i] = (e, v) => e.REV_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG01":
                        mapper[i] = (e, v) => e.REV_BUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG02":
                        mapper[i] = (e, v) => e.REV_BUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG03":
                        mapper[i] = (e, v) => e.REV_BUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG04":
                        mapper[i] = (e, v) => e.REV_BUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG05":
                        mapper[i] = (e, v) => e.REV_BUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG06":
                        mapper[i] = (e, v) => e.REV_BUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG07":
                        mapper[i] = (e, v) => e.REV_BUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG08":
                        mapper[i] = (e, v) => e.REV_BUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG09":
                        mapper[i] = (e, v) => e.REV_BUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG10":
                        mapper[i] = (e, v) => e.REV_BUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG11":
                        mapper[i] = (e, v) => e.REV_BUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "REV_BUDG12":
                        mapper[i] = (e, v) => e.REV_BUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG01":
                        mapper[i] = (e, v) => e.LASTBUDG01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG02":
                        mapper[i] = (e, v) => e.LASTBUDG02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG03":
                        mapper[i] = (e, v) => e.LASTBUDG03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG04":
                        mapper[i] = (e, v) => e.LASTBUDG04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG05":
                        mapper[i] = (e, v) => e.LASTBUDG05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG06":
                        mapper[i] = (e, v) => e.LASTBUDG06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG07":
                        mapper[i] = (e, v) => e.LASTBUDG07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG08":
                        mapper[i] = (e, v) => e.LASTBUDG08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG09":
                        mapper[i] = (e, v) => e.LASTBUDG09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG10":
                        mapper[i] = (e, v) => e.LASTBUDG10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG11":
                        mapper[i] = (e, v) => e.LASTBUDG11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTBUDG12":
                        mapper[i] = (e, v) => e.LASTBUDG12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LAST_ANN_BUDG":
                        mapper[i] = (e, v) => e.LAST_ANN_BUDG = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT01":
                        mapper[i] = (e, v) => e.COMMITMENT01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT02":
                        mapper[i] = (e, v) => e.COMMITMENT02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT03":
                        mapper[i] = (e, v) => e.COMMITMENT03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT04":
                        mapper[i] = (e, v) => e.COMMITMENT04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT05":
                        mapper[i] = (e, v) => e.COMMITMENT05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT06":
                        mapper[i] = (e, v) => e.COMMITMENT06 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT07":
                        mapper[i] = (e, v) => e.COMMITMENT07 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT08":
                        mapper[i] = (e, v) => e.COMMITMENT08 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT09":
                        mapper[i] = (e, v) => e.COMMITMENT09 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT10":
                        mapper[i] = (e, v) => e.COMMITMENT10 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT11":
                        mapper[i] = (e, v) => e.COMMITMENT11 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "COMMITMENT12":
                        mapper[i] = (e, v) => e.COMMITMENT12 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "HIDATE":
                        mapper[i] = (e, v) => e.HIDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GL_TYPE":
                        mapper[i] = (e, v) => e.GL_TYPE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
                        break;
                    case "USER_DEFINABLE":
                        mapper[i] = (e, v) => e.USER_DEFINABLE = v;
                        break;
                    case "FBT":
                        mapper[i] = (e, v) => e.FBT = v;
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

        #region Index Fields

        private Lazy<Dictionary<string, GLPREV>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<GLPREV>>> Index_GL_TYPE;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find GLPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLPREV</param>
        /// <returns>Related GLPREV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLPREV FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find GLPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLPREV</param>
        /// <param name="Value">Related GLPREV entity</param>
        /// <returns>True if the related GLPREV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out GLPREV Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find GLPREV by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find GLPREV</param>
        /// <returns>Related GLPREV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public GLPREV TryFindByCODE(string CODE)
        {
            GLPREV value;
            if (Index_CODE.Value.TryGetValue(CODE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find GLPREV by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GLPREV</param>
        /// <returns>List of related GLPREV entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLPREV> FindByGL_TYPE(string GL_TYPE)
        {
            return Index_GL_TYPE.Value[GL_TYPE];
        }

        /// <summary>
        /// Attempt to find GLPREV by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GLPREV</param>
        /// <param name="Value">List of related GLPREV entities</param>
        /// <returns>True if the list of related GLPREV entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGL_TYPE(string GL_TYPE, out IReadOnlyList<GLPREV> Value)
        {
            return Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find GLPREV by GL_TYPE field
        /// </summary>
        /// <param name="GL_TYPE">GL_TYPE value used to find GLPREV</param>
        /// <returns>List of related GLPREV entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<GLPREV> TryFindByGL_TYPE(string GL_TYPE)
        {
            IReadOnlyList<GLPREV> value;
            if (Index_GL_TYPE.Value.TryGetValue(GL_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
