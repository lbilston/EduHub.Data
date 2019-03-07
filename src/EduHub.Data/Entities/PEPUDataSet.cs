﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Super (SGL and Employee) YTD Transactions Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class PEPUDataSet : EduHubDataSet<PEPU>
    {
        /// <inheritdoc />
        public override string Name { get { return "PEPU"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal PEPUDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_CODE = new Lazy<Dictionary<string, IReadOnlyList<PEPU>>>(() => this.ToGroupedDictionary(i => i.CODE));
            Index_INITIATIVE = new Lazy<NullDictionary<string, IReadOnlyList<PEPU>>>(() => this.ToGroupedNullDictionary(i => i.INITIATIVE));
            Index_PAYITEM = new Lazy<NullDictionary<short?, IReadOnlyList<PEPU>>>(() => this.ToGroupedNullDictionary(i => i.PAYITEM));
            Index_SUBPROGRAM = new Lazy<NullDictionary<string, IReadOnlyList<PEPU>>>(() => this.ToGroupedNullDictionary(i => i.SUBPROGRAM));
            Index_SUPER_FUND = new Lazy<NullDictionary<string, IReadOnlyList<PEPU>>>(() => this.ToGroupedNullDictionary(i => i.SUPER_FUND));
            Index_TID = new Lazy<Dictionary<int, PEPU>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="PEPU" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="PEPU" /> fields for each CSV column header</returns>
        internal override Action<PEPU, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<PEPU, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "CODE":
                        mapper[i] = (e, v) => e.CODE = v;
                        break;
                    case "PAYITEM":
                        mapper[i] = (e, v) => e.PAYITEM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TRBATCH":
                        mapper[i] = (e, v) => e.TRBATCH = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRPERD":
                        mapper[i] = (e, v) => e.TRPERD = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRDATE":
                        mapper[i] = (e, v) => e.TRDATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "TRREF":
                        mapper[i] = (e, v) => e.TRREF = v;
                        break;
                    case "TRQTY":
                        mapper[i] = (e, v) => e.TRQTY = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRDET":
                        mapper[i] = (e, v) => e.TRDET = v;
                        break;
                    case "TRTYPE":
                        mapper[i] = (e, v) => e.TRTYPE = v;
                        break;
                    case "TRPAYAMT":
                        mapper[i] = (e, v) => e.TRPAYAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "TRSUPER_PC":
                        mapper[i] = (e, v) => e.TRSUPER_PC = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "TRSUPER_AMT":
                        mapper[i] = (e, v) => e.TRSUPER_AMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "SUPER_FUND":
                        mapper[i] = (e, v) => e.SUPER_FUND = v;
                        break;
                    case "SUPER_MEMBER":
                        mapper[i] = (e, v) => e.SUPER_MEMBER = v;
                        break;
                    case "SUBPROGRAM":
                        mapper[i] = (e, v) => e.SUBPROGRAM = v;
                        break;
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "INITIATIVE":
                        mapper[i] = (e, v) => e.INITIATIVE = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
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

        /// <summary>
        /// Merges <see cref="PEPU" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="PEPU" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="PEPU" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{PEPU}"/> of entities</returns>
        internal override IEnumerable<PEPU> ApplyDeltaEntities(IEnumerable<PEPU> Entities, List<PEPU> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CODE;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.CODE.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<string, IReadOnlyList<PEPU>>> Index_CODE;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPU>>> Index_INITIATIVE;
        private Lazy<NullDictionary<short?, IReadOnlyList<PEPU>>> Index_PAYITEM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPU>>> Index_SUBPROGRAM;
        private Lazy<NullDictionary<string, IReadOnlyList<PEPU>>> Index_SUPER_FUND;
        private Lazy<Dictionary<int, PEPU>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find PEPU by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPU</param>
        /// <returns>List of related PEPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> FindByCODE(string CODE)
        {
            return Index_CODE.Value[CODE];
        }

        /// <summary>
        /// Attempt to find PEPU by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPU</param>
        /// <param name="Value">List of related PEPU entities</param>
        /// <returns>True if the list of related PEPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCODE(string CODE, out IReadOnlyList<PEPU> Value)
        {
            return Index_CODE.Value.TryGetValue(CODE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by CODE field
        /// </summary>
        /// <param name="CODE">CODE value used to find PEPU</param>
        /// <returns>List of related PEPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> TryFindByCODE(string CODE)
        {
            IReadOnlyList<PEPU> value;
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
        /// Find PEPU by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPU</param>
        /// <returns>List of related PEPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> FindByINITIATIVE(string INITIATIVE)
        {
            return Index_INITIATIVE.Value[INITIATIVE];
        }

        /// <summary>
        /// Attempt to find PEPU by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPU</param>
        /// <param name="Value">List of related PEPU entities</param>
        /// <returns>True if the list of related PEPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByINITIATIVE(string INITIATIVE, out IReadOnlyList<PEPU> Value)
        {
            return Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by INITIATIVE field
        /// </summary>
        /// <param name="INITIATIVE">INITIATIVE value used to find PEPU</param>
        /// <returns>List of related PEPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> TryFindByINITIATIVE(string INITIATIVE)
        {
            IReadOnlyList<PEPU> value;
            if (Index_INITIATIVE.Value.TryGetValue(INITIATIVE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPU by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPU</param>
        /// <returns>List of related PEPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> FindByPAYITEM(short? PAYITEM)
        {
            return Index_PAYITEM.Value[PAYITEM];
        }

        /// <summary>
        /// Attempt to find PEPU by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPU</param>
        /// <param name="Value">List of related PEPU entities</param>
        /// <returns>True if the list of related PEPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPAYITEM(short? PAYITEM, out IReadOnlyList<PEPU> Value)
        {
            return Index_PAYITEM.Value.TryGetValue(PAYITEM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by PAYITEM field
        /// </summary>
        /// <param name="PAYITEM">PAYITEM value used to find PEPU</param>
        /// <returns>List of related PEPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> TryFindByPAYITEM(short? PAYITEM)
        {
            IReadOnlyList<PEPU> value;
            if (Index_PAYITEM.Value.TryGetValue(PAYITEM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPU by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPU</param>
        /// <returns>List of related PEPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> FindBySUBPROGRAM(string SUBPROGRAM)
        {
            return Index_SUBPROGRAM.Value[SUBPROGRAM];
        }

        /// <summary>
        /// Attempt to find PEPU by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPU</param>
        /// <param name="Value">List of related PEPU entities</param>
        /// <returns>True if the list of related PEPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUBPROGRAM(string SUBPROGRAM, out IReadOnlyList<PEPU> Value)
        {
            return Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by SUBPROGRAM field
        /// </summary>
        /// <param name="SUBPROGRAM">SUBPROGRAM value used to find PEPU</param>
        /// <returns>List of related PEPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> TryFindBySUBPROGRAM(string SUBPROGRAM)
        {
            IReadOnlyList<PEPU> value;
            if (Index_SUBPROGRAM.Value.TryGetValue(SUBPROGRAM, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPU by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPU</param>
        /// <returns>List of related PEPU entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> FindBySUPER_FUND(string SUPER_FUND)
        {
            return Index_SUPER_FUND.Value[SUPER_FUND];
        }

        /// <summary>
        /// Attempt to find PEPU by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPU</param>
        /// <param name="Value">List of related PEPU entities</param>
        /// <returns>True if the list of related PEPU entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySUPER_FUND(string SUPER_FUND, out IReadOnlyList<PEPU> Value)
        {
            return Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by SUPER_FUND field
        /// </summary>
        /// <param name="SUPER_FUND">SUPER_FUND value used to find PEPU</param>
        /// <returns>List of related PEPU entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<PEPU> TryFindBySUPER_FUND(string SUPER_FUND)
        {
            IReadOnlyList<PEPU> value;
            if (Index_SUPER_FUND.Value.TryGetValue(SUPER_FUND, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find PEPU by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPU</param>
        /// <returns>Related PEPU entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPU FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find PEPU by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPU</param>
        /// <param name="Value">Related PEPU entity</param>
        /// <returns>True if the related PEPU entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out PEPU Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find PEPU by TID field
        /// </summary>
        /// <param name="TID">TID value used to find PEPU</param>
        /// <returns>Related PEPU entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public PEPU TryFindByTID(int TID)
        {
            PEPU value;
            if (Index_TID.Value.TryGetValue(TID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a PEPU table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[PEPU](
        [TID] int IDENTITY NOT NULL,
        [CODE] varchar(10) NOT NULL,
        [PAYITEM] smallint NULL,
        [TRBATCH] int NULL,
        [TRPERD] int NULL,
        [TRDATE] datetime NULL,
        [TRREF] varchar(10) NULL,
        [TRQTY] float NULL,
        [TRDET] varchar(30) NULL,
        [TRTYPE] varchar(1) NULL,
        [TRPAYAMT] money NULL,
        [TRSUPER_PC] float NULL,
        [TRSUPER_AMT] money NULL,
        [SUPER_FUND] varchar(10) NULL,
        [SUPER_MEMBER] varchar(20) NULL,
        [SUBPROGRAM] varchar(4) NULL,
        [GLPROGRAM] varchar(3) NULL,
        [INITIATIVE] varchar(3) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [PEPU_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE CLUSTERED INDEX [PEPU_Index_CODE] ON [dbo].[PEPU]
    (
            [CODE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPU_Index_INITIATIVE] ON [dbo].[PEPU]
    (
            [INITIATIVE] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPU_Index_PAYITEM] ON [dbo].[PEPU]
    (
            [PAYITEM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPU_Index_SUBPROGRAM] ON [dbo].[PEPU]
    (
            [SUBPROGRAM] ASC
    );
    CREATE NONCLUSTERED INDEX [PEPU_Index_SUPER_FUND] ON [dbo].[PEPU]
    (
            [SUPER_FUND] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PEPU] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_PAYITEM')
    ALTER INDEX [Index_PAYITEM] ON [dbo].[PEPU] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PEPU] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_SUPER_FUND')
    ALTER INDEX [Index_SUPER_FUND] ON [dbo].[PEPU] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PEPU] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_INITIATIVE')
    ALTER INDEX [Index_INITIATIVE] ON [dbo].[PEPU] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_PAYITEM')
    ALTER INDEX [Index_PAYITEM] ON [dbo].[PEPU] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_SUBPROGRAM')
    ALTER INDEX [Index_SUBPROGRAM] ON [dbo].[PEPU] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_SUPER_FUND')
    ALTER INDEX [Index_SUPER_FUND] ON [dbo].[PEPU] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[PEPU]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[PEPU] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="PEPU"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="PEPU"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<PEPU> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[PEPU] WHERE");


            // Index_TID
            builder.Append("[TID] IN (");
            for (int index = 0; index < Index_TID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // TID
                var parameterTID = $"@p{parameterIndex++}";
                builder.Append(parameterTID);
                command.Parameters.Add(parameterTID, SqlDbType.Int).Value = Index_TID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPU data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPU data set</returns>
        public override EduHubDataSetDataReader<PEPU> GetDataSetDataReader()
        {
            return new PEPUDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the PEPU data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the PEPU data set</returns>
        public override EduHubDataSetDataReader<PEPU> GetDataSetDataReader(List<PEPU> Entities)
        {
            return new PEPUDataReader(new EduHubDataSetLoadedReader<PEPU>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class PEPUDataReader : EduHubDataSetDataReader<PEPU>
        {
            public PEPUDataReader(IEduHubDataSetReader<PEPU> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 21; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // CODE
                        return Current.CODE;
                    case 2: // PAYITEM
                        return Current.PAYITEM;
                    case 3: // TRBATCH
                        return Current.TRBATCH;
                    case 4: // TRPERD
                        return Current.TRPERD;
                    case 5: // TRDATE
                        return Current.TRDATE;
                    case 6: // TRREF
                        return Current.TRREF;
                    case 7: // TRQTY
                        return Current.TRQTY;
                    case 8: // TRDET
                        return Current.TRDET;
                    case 9: // TRTYPE
                        return Current.TRTYPE;
                    case 10: // TRPAYAMT
                        return Current.TRPAYAMT;
                    case 11: // TRSUPER_PC
                        return Current.TRSUPER_PC;
                    case 12: // TRSUPER_AMT
                        return Current.TRSUPER_AMT;
                    case 13: // SUPER_FUND
                        return Current.SUPER_FUND;
                    case 14: // SUPER_MEMBER
                        return Current.SUPER_MEMBER;
                    case 15: // SUBPROGRAM
                        return Current.SUBPROGRAM;
                    case 16: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 17: // INITIATIVE
                        return Current.INITIATIVE;
                    case 18: // LW_DATE
                        return Current.LW_DATE;
                    case 19: // LW_TIME
                        return Current.LW_TIME;
                    case 20: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // PAYITEM
                        return Current.PAYITEM == null;
                    case 3: // TRBATCH
                        return Current.TRBATCH == null;
                    case 4: // TRPERD
                        return Current.TRPERD == null;
                    case 5: // TRDATE
                        return Current.TRDATE == null;
                    case 6: // TRREF
                        return Current.TRREF == null;
                    case 7: // TRQTY
                        return Current.TRQTY == null;
                    case 8: // TRDET
                        return Current.TRDET == null;
                    case 9: // TRTYPE
                        return Current.TRTYPE == null;
                    case 10: // TRPAYAMT
                        return Current.TRPAYAMT == null;
                    case 11: // TRSUPER_PC
                        return Current.TRSUPER_PC == null;
                    case 12: // TRSUPER_AMT
                        return Current.TRSUPER_AMT == null;
                    case 13: // SUPER_FUND
                        return Current.SUPER_FUND == null;
                    case 14: // SUPER_MEMBER
                        return Current.SUPER_MEMBER == null;
                    case 15: // SUBPROGRAM
                        return Current.SUBPROGRAM == null;
                    case 16: // GLPROGRAM
                        return Current.GLPROGRAM == null;
                    case 17: // INITIATIVE
                        return Current.INITIATIVE == null;
                    case 18: // LW_DATE
                        return Current.LW_DATE == null;
                    case 19: // LW_TIME
                        return Current.LW_TIME == null;
                    case 20: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // TID
                        return "TID";
                    case 1: // CODE
                        return "CODE";
                    case 2: // PAYITEM
                        return "PAYITEM";
                    case 3: // TRBATCH
                        return "TRBATCH";
                    case 4: // TRPERD
                        return "TRPERD";
                    case 5: // TRDATE
                        return "TRDATE";
                    case 6: // TRREF
                        return "TRREF";
                    case 7: // TRQTY
                        return "TRQTY";
                    case 8: // TRDET
                        return "TRDET";
                    case 9: // TRTYPE
                        return "TRTYPE";
                    case 10: // TRPAYAMT
                        return "TRPAYAMT";
                    case 11: // TRSUPER_PC
                        return "TRSUPER_PC";
                    case 12: // TRSUPER_AMT
                        return "TRSUPER_AMT";
                    case 13: // SUPER_FUND
                        return "SUPER_FUND";
                    case 14: // SUPER_MEMBER
                        return "SUPER_MEMBER";
                    case 15: // SUBPROGRAM
                        return "SUBPROGRAM";
                    case 16: // GLPROGRAM
                        return "GLPROGRAM";
                    case 17: // INITIATIVE
                        return "INITIATIVE";
                    case 18: // LW_DATE
                        return "LW_DATE";
                    case 19: // LW_TIME
                        return "LW_TIME";
                    case 20: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "TID":
                        return 0;
                    case "CODE":
                        return 1;
                    case "PAYITEM":
                        return 2;
                    case "TRBATCH":
                        return 3;
                    case "TRPERD":
                        return 4;
                    case "TRDATE":
                        return 5;
                    case "TRREF":
                        return 6;
                    case "TRQTY":
                        return 7;
                    case "TRDET":
                        return 8;
                    case "TRTYPE":
                        return 9;
                    case "TRPAYAMT":
                        return 10;
                    case "TRSUPER_PC":
                        return 11;
                    case "TRSUPER_AMT":
                        return 12;
                    case "SUPER_FUND":
                        return 13;
                    case "SUPER_MEMBER":
                        return 14;
                    case "SUBPROGRAM":
                        return 15;
                    case "GLPROGRAM":
                        return 16;
                    case "INITIATIVE":
                        return 17;
                    case "LW_DATE":
                        return 18;
                    case "LW_TIME":
                        return 19;
                    case "LW_USER":
                        return 20;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
