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
    /// Occupations Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGODataSet : EduHubDataSet<KGO>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGO"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGODataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KGOKEY = new Lazy<Dictionary<string, KGO>>(() => this.ToDictionary(i => i.KGOKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGO" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGO" /> fields for each CSV column header</returns>
        internal override Action<KGO, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGO, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KGOKEY":
                        mapper[i] = (e, v) => e.KGOKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
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
        /// Merges <see cref="KGO" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGO" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGO" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGO}"/> of entities</returns>
        internal override IEnumerable<KGO> ApplyDeltaEntities(IEnumerable<KGO> Entities, List<KGO> DeltaEntities)
        {
            HashSet<string> Index_KGOKEY = new HashSet<string>(DeltaEntities.Select(i => i.KGOKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KGOKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KGOKEY.Remove(entity.KGOKEY);
                            
                            if (entity.KGOKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGO>> Index_KGOKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGO by KGOKEY field
        /// </summary>
        /// <param name="KGOKEY">KGOKEY value used to find KGO</param>
        /// <returns>Related KGO entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGO FindByKGOKEY(string KGOKEY)
        {
            return Index_KGOKEY.Value[KGOKEY];
        }

        /// <summary>
        /// Attempt to find KGO by KGOKEY field
        /// </summary>
        /// <param name="KGOKEY">KGOKEY value used to find KGO</param>
        /// <param name="Value">Related KGO entity</param>
        /// <returns>True if the related KGO entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKGOKEY(string KGOKEY, out KGO Value)
        {
            return Index_KGOKEY.Value.TryGetValue(KGOKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KGO by KGOKEY field
        /// </summary>
        /// <param name="KGOKEY">KGOKEY value used to find KGO</param>
        /// <returns>Related KGO entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGO TryFindByKGOKEY(string KGOKEY)
        {
            KGO value;
            if (Index_KGOKEY.Value.TryGetValue(KGOKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGO table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGO]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGO](
        [KGOKEY] varchar(10) NOT NULL,
        [TITLE] varchar(30) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGO_Index_KGOKEY] PRIMARY KEY CLUSTERED (
            [KGOKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGODataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGODataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGO"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGO"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGO> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KGOKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KGOKEY.Add(entity.KGOKEY);
            }

            builder.AppendLine("DELETE [dbo].[KGO] WHERE");


            // Index_KGOKEY
            builder.Append("[KGOKEY] IN (");
            for (int index = 0; index < Index_KGOKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KGOKEY
                var parameterKGOKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKGOKEY);
                command.Parameters.Add(parameterKGOKEY, SqlDbType.VarChar, 10).Value = Index_KGOKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGO data set</returns>
        public override EduHubDataSetDataReader<KGO> GetDataSetDataReader()
        {
            return new KGODataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGO data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGO data set</returns>
        public override EduHubDataSetDataReader<KGO> GetDataSetDataReader(List<KGO> Entities)
        {
            return new KGODataReader(new EduHubDataSetLoadedReader<KGO>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGODataReader : EduHubDataSetDataReader<KGO>
        {
            public KGODataReader(IEduHubDataSetReader<KGO> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 5; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KGOKEY
                        return Current.KGOKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // LW_DATE
                        return Current.LW_DATE;
                    case 3: // LW_TIME
                        return Current.LW_TIME;
                    case 4: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // LW_DATE
                        return Current.LW_DATE == null;
                    case 3: // LW_TIME
                        return Current.LW_TIME == null;
                    case 4: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KGOKEY
                        return "KGOKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // LW_DATE
                        return "LW_DATE";
                    case 3: // LW_TIME
                        return "LW_TIME";
                    case 4: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KGOKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "LW_DATE":
                        return 2;
                    case "LW_TIME":
                        return 3;
                    case "LW_USER":
                        return 4;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
