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
    /// Group Membership Eligibility Criteria Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGSGDataSet : EduHubDataSet<SGSG>
    {
        /// <inheritdoc />
        public override string Name { get { return "SGSG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal SGSGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_SGLINK = new Lazy<NullDictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedNullDictionary(i => i.SGLINK));
            Index_SGSGKEY = new Lazy<Dictionary<string, IReadOnlyList<SGSG>>>(() => this.ToGroupedDictionary(i => i.SGSGKEY));
            Index_TID = new Lazy<Dictionary<int, SGSG>>(() => this.ToDictionary(i => i.TID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SGSG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SGSG" /> fields for each CSV column header</returns>
        internal override Action<SGSG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SGSG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "TID":
                        mapper[i] = (e, v) => e.TID = int.Parse(v);
                        break;
                    case "SGSGKEY":
                        mapper[i] = (e, v) => e.SGSGKEY = v;
                        break;
                    case "SGLINK":
                        mapper[i] = (e, v) => e.SGLINK = v;
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
        /// Merges <see cref="SGSG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SGSG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SGSG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SGSG}"/> of entities</returns>
        internal override IEnumerable<SGSG> ApplyDeltaEntities(IEnumerable<SGSG> Entities, List<SGSG> DeltaEntities)
        {
            HashSet<int> Index_TID = new HashSet<int>(DeltaEntities.Select(i => i.TID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.SGSGKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_TID.Remove(entity.TID);
                            
                            if (entity.SGSGKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<NullDictionary<string, IReadOnlyList<SGSG>>> Index_SGLINK;
        private Lazy<Dictionary<string, IReadOnlyList<SGSG>>> Index_SGSGKEY;
        private Lazy<Dictionary<int, SGSG>> Index_TID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGLINK(string SGLINK)
        {
            return Index_SGLINK.Value[SGLINK];
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGLINK(string SGLINK, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGLINK.Value.TryGetValue(SGLINK, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGLINK field
        /// </summary>
        /// <param name="SGLINK">SGLINK value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGLINK(string SGLINK)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGLINK.Value.TryGetValue(SGLINK, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> FindBySGSGKEY(string SGSGKEY)
        {
            return Index_SGSGKEY.Value[SGSGKEY];
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <param name="Value">List of related SGSG entities</param>
        /// <returns>True if the list of related SGSG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGSGKEY(string SGSGKEY, out IReadOnlyList<SGSG> Value)
        {
            return Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by SGSGKEY field
        /// </summary>
        /// <param name="SGSGKEY">SGSGKEY value used to find SGSG</param>
        /// <returns>List of related SGSG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SGSG> TryFindBySGSGKEY(string SGSGKEY)
        {
            IReadOnlyList<SGSG> value;
            if (Index_SGSGKEY.Value.TryGetValue(SGSGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG FindByTID(int TID)
        {
            return Index_TID.Value[TID];
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <param name="Value">Related SGSG entity</param>
        /// <returns>True if the related SGSG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTID(int TID, out SGSG Value)
        {
            return Index_TID.Value.TryGetValue(TID, out Value);
        }

        /// <summary>
        /// Attempt to find SGSG by TID field
        /// </summary>
        /// <param name="TID">TID value used to find SGSG</param>
        /// <returns>Related SGSG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SGSG TryFindByTID(int TID)
        {
            SGSG value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SGSG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SGSG](
        [TID] int IDENTITY NOT NULL,
        [SGSGKEY] varchar(12) NOT NULL,
        [SGLINK] varchar(12) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SGSG_Index_TID] PRIMARY KEY NONCLUSTERED (
            [TID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SGSG_Index_SGLINK] ON [dbo].[SGSG]
    (
            [SGLINK] ASC
    );
    CREATE CLUSTERED INDEX [SGSG_Index_SGSGKEY] ON [dbo].[SGSG]
    (
            [SGSGKEY] ASC
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND name = N'Index_SGLINK')
    ALTER INDEX [Index_SGLINK] ON [dbo].[SGSG] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGSG] DISABLE;
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
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND name = N'Index_SGLINK')
    ALTER INDEX [Index_SGLINK] ON [dbo].[SGSG] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[SGSG]') AND name = N'Index_TID')
    ALTER INDEX [Index_TID] ON [dbo].[SGSG] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SGSG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SGSG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SGSG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_TID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_TID.Add(entity.TID);
            }

            builder.AppendLine("DELETE [dbo].[SGSG] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SGSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSG data set</returns>
        public override EduHubDataSetDataReader<SGSG> GetDataSetDataReader()
        {
            return new SGSGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SGSG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SGSG data set</returns>
        public override EduHubDataSetDataReader<SGSG> GetDataSetDataReader(List<SGSG> Entities)
        {
            return new SGSGDataReader(new EduHubDataSetLoadedReader<SGSG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGSGDataReader : EduHubDataSetDataReader<SGSG>
        {
            public SGSGDataReader(IEduHubDataSetReader<SGSG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // TID
                        return Current.TID;
                    case 1: // SGSGKEY
                        return Current.SGSGKEY;
                    case 2: // SGLINK
                        return Current.SGLINK;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 2: // SGLINK
                        return Current.SGLINK == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
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
                    case 1: // SGSGKEY
                        return "SGSGKEY";
                    case 2: // SGLINK
                        return "SGLINK";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
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
                    case "SGSGKEY":
                        return 1;
                    case "SGLINK":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
