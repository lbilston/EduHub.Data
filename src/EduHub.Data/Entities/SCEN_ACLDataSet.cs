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
    /// Archived Census Class Sizes Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ACLDataSet : EduHubDataSet<SCEN_ACL>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_ACL"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_ACLDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ACL>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ACL" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ACL" /> fields for each CSV column header</returns>
        internal override Action<SCEN_ACL, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ACL, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAMPUSNUMBER":
                        mapper[i] = (e, v) => e.CAMPUSNUMBER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "CLASSTYPE":
                        mapper[i] = (e, v) => e.CLASSTYPE = v;
                        break;
                    case "FTETEACHERS":
                        mapper[i] = (e, v) => e.FTETEACHERS = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "PREP":
                        mapper[i] = (e, v) => e.PREP = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR01":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR01 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR02":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR02 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR03":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR03 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR04":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR04 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR05":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR05 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR06":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR06 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR07":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR07 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR08":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR08 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR09":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR09 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR10":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR10 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR11":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR11 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SCHOOL_YEAR12":
                        mapper[i] = (e, v) => e.SCHOOL_YEAR12 = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PRIMARYUG":
                        mapper[i] = (e, v) => e.PRIMARYUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SENIORUG":
                        mapper[i] = (e, v) => e.SENIORUG = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_ACL" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_ACL" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_ACL" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_ACL}"/> of entities</returns>
        internal override IEnumerable<SCEN_ACL> ApplyDeltaEntities(IEnumerable<SCEN_ACL> Entities, List<SCEN_ACL> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SCEN_ACL>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <param name="Value">Related SCEN_ACL entity</param>
        /// <returns>True if the related SCEN_ACL entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ACL Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ACL by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ACL</param>
        /// <returns>Related SCEN_ACL entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ACL TryFindByID(int ID)
        {
            SCEN_ACL value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_ACL table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ACL]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ACL](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] int NULL,
        [CAMPUSNUMBER] smallint NULL,
        [CLASSCODE] varchar(5) NULL,
        [CLASSTYPE] varchar(3) NULL,
        [FTETEACHERS] float NULL,
        [PREP] smallint NULL,
        [SCHOOL_YEAR01] smallint NULL,
        [SCHOOL_YEAR02] smallint NULL,
        [SCHOOL_YEAR03] smallint NULL,
        [SCHOOL_YEAR04] smallint NULL,
        [SCHOOL_YEAR05] smallint NULL,
        [SCHOOL_YEAR06] smallint NULL,
        [SCHOOL_YEAR07] smallint NULL,
        [SCHOOL_YEAR08] smallint NULL,
        [SCHOOL_YEAR09] smallint NULL,
        [SCHOOL_YEAR10] smallint NULL,
        [SCHOOL_YEAR11] smallint NULL,
        [SCHOOL_YEAR12] smallint NULL,
        [PRIMARYUG] smallint NULL,
        [SENIORUG] smallint NULL,
        [CREATED] datetime NULL,
        [CREATEUSER] varchar(128) NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ACL_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ACLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ACLDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_ACL"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_ACL"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_ACL> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_ACL] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ACL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ACL data set</returns>
        public override EduHubDataSetDataReader<SCEN_ACL> GetDataSetDataReader()
        {
            return new SCEN_ACLDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ACL data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ACL data set</returns>
        public override EduHubDataSetDataReader<SCEN_ACL> GetDataSetDataReader(List<SCEN_ACL> Entities)
        {
            return new SCEN_ACLDataReader(new EduHubDataSetLoadedReader<SCEN_ACL>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ACLDataReader : EduHubDataSetDataReader<SCEN_ACL>
        {
            public SCEN_ACLDataReader(IEduHubDataSetReader<SCEN_ACL> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 25; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // ID_RETURN
                        return Current.ID_RETURN;
                    case 2: // CAMPUSNUMBER
                        return Current.CAMPUSNUMBER;
                    case 3: // CLASSCODE
                        return Current.CLASSCODE;
                    case 4: // CLASSTYPE
                        return Current.CLASSTYPE;
                    case 5: // FTETEACHERS
                        return Current.FTETEACHERS;
                    case 6: // PREP
                        return Current.PREP;
                    case 7: // SCHOOL_YEAR01
                        return Current.SCHOOL_YEAR01;
                    case 8: // SCHOOL_YEAR02
                        return Current.SCHOOL_YEAR02;
                    case 9: // SCHOOL_YEAR03
                        return Current.SCHOOL_YEAR03;
                    case 10: // SCHOOL_YEAR04
                        return Current.SCHOOL_YEAR04;
                    case 11: // SCHOOL_YEAR05
                        return Current.SCHOOL_YEAR05;
                    case 12: // SCHOOL_YEAR06
                        return Current.SCHOOL_YEAR06;
                    case 13: // SCHOOL_YEAR07
                        return Current.SCHOOL_YEAR07;
                    case 14: // SCHOOL_YEAR08
                        return Current.SCHOOL_YEAR08;
                    case 15: // SCHOOL_YEAR09
                        return Current.SCHOOL_YEAR09;
                    case 16: // SCHOOL_YEAR10
                        return Current.SCHOOL_YEAR10;
                    case 17: // SCHOOL_YEAR11
                        return Current.SCHOOL_YEAR11;
                    case 18: // SCHOOL_YEAR12
                        return Current.SCHOOL_YEAR12;
                    case 19: // PRIMARYUG
                        return Current.PRIMARYUG;
                    case 20: // SENIORUG
                        return Current.SENIORUG;
                    case 21: // CREATED
                        return Current.CREATED;
                    case 22: // CREATEUSER
                        return Current.CREATEUSER;
                    case 23: // LUPDATEUSER
                        return Current.LUPDATEUSER;
                    case 24: // LUPDATED
                        return Current.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ID_RETURN
                        return Current.ID_RETURN == null;
                    case 2: // CAMPUSNUMBER
                        return Current.CAMPUSNUMBER == null;
                    case 3: // CLASSCODE
                        return Current.CLASSCODE == null;
                    case 4: // CLASSTYPE
                        return Current.CLASSTYPE == null;
                    case 5: // FTETEACHERS
                        return Current.FTETEACHERS == null;
                    case 6: // PREP
                        return Current.PREP == null;
                    case 7: // SCHOOL_YEAR01
                        return Current.SCHOOL_YEAR01 == null;
                    case 8: // SCHOOL_YEAR02
                        return Current.SCHOOL_YEAR02 == null;
                    case 9: // SCHOOL_YEAR03
                        return Current.SCHOOL_YEAR03 == null;
                    case 10: // SCHOOL_YEAR04
                        return Current.SCHOOL_YEAR04 == null;
                    case 11: // SCHOOL_YEAR05
                        return Current.SCHOOL_YEAR05 == null;
                    case 12: // SCHOOL_YEAR06
                        return Current.SCHOOL_YEAR06 == null;
                    case 13: // SCHOOL_YEAR07
                        return Current.SCHOOL_YEAR07 == null;
                    case 14: // SCHOOL_YEAR08
                        return Current.SCHOOL_YEAR08 == null;
                    case 15: // SCHOOL_YEAR09
                        return Current.SCHOOL_YEAR09 == null;
                    case 16: // SCHOOL_YEAR10
                        return Current.SCHOOL_YEAR10 == null;
                    case 17: // SCHOOL_YEAR11
                        return Current.SCHOOL_YEAR11 == null;
                    case 18: // SCHOOL_YEAR12
                        return Current.SCHOOL_YEAR12 == null;
                    case 19: // PRIMARYUG
                        return Current.PRIMARYUG == null;
                    case 20: // SENIORUG
                        return Current.SENIORUG == null;
                    case 21: // CREATED
                        return Current.CREATED == null;
                    case 22: // CREATEUSER
                        return Current.CREATEUSER == null;
                    case 23: // LUPDATEUSER
                        return Current.LUPDATEUSER == null;
                    case 24: // LUPDATED
                        return Current.LUPDATED == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // CAMPUSNUMBER
                        return "CAMPUSNUMBER";
                    case 3: // CLASSCODE
                        return "CLASSCODE";
                    case 4: // CLASSTYPE
                        return "CLASSTYPE";
                    case 5: // FTETEACHERS
                        return "FTETEACHERS";
                    case 6: // PREP
                        return "PREP";
                    case 7: // SCHOOL_YEAR01
                        return "SCHOOL_YEAR01";
                    case 8: // SCHOOL_YEAR02
                        return "SCHOOL_YEAR02";
                    case 9: // SCHOOL_YEAR03
                        return "SCHOOL_YEAR03";
                    case 10: // SCHOOL_YEAR04
                        return "SCHOOL_YEAR04";
                    case 11: // SCHOOL_YEAR05
                        return "SCHOOL_YEAR05";
                    case 12: // SCHOOL_YEAR06
                        return "SCHOOL_YEAR06";
                    case 13: // SCHOOL_YEAR07
                        return "SCHOOL_YEAR07";
                    case 14: // SCHOOL_YEAR08
                        return "SCHOOL_YEAR08";
                    case 15: // SCHOOL_YEAR09
                        return "SCHOOL_YEAR09";
                    case 16: // SCHOOL_YEAR10
                        return "SCHOOL_YEAR10";
                    case 17: // SCHOOL_YEAR11
                        return "SCHOOL_YEAR11";
                    case 18: // SCHOOL_YEAR12
                        return "SCHOOL_YEAR12";
                    case 19: // PRIMARYUG
                        return "PRIMARYUG";
                    case 20: // SENIORUG
                        return "SENIORUG";
                    case 21: // CREATED
                        return "CREATED";
                    case 22: // CREATEUSER
                        return "CREATEUSER";
                    case 23: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 24: // LUPDATED
                        return "LUPDATED";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "ID_RETURN":
                        return 1;
                    case "CAMPUSNUMBER":
                        return 2;
                    case "CLASSCODE":
                        return 3;
                    case "CLASSTYPE":
                        return 4;
                    case "FTETEACHERS":
                        return 5;
                    case "PREP":
                        return 6;
                    case "SCHOOL_YEAR01":
                        return 7;
                    case "SCHOOL_YEAR02":
                        return 8;
                    case "SCHOOL_YEAR03":
                        return 9;
                    case "SCHOOL_YEAR04":
                        return 10;
                    case "SCHOOL_YEAR05":
                        return 11;
                    case "SCHOOL_YEAR06":
                        return 12;
                    case "SCHOOL_YEAR07":
                        return 13;
                    case "SCHOOL_YEAR08":
                        return 14;
                    case "SCHOOL_YEAR09":
                        return 15;
                    case "SCHOOL_YEAR10":
                        return 16;
                    case "SCHOOL_YEAR11":
                        return 17;
                    case "SCHOOL_YEAR12":
                        return 18;
                    case "PRIMARYUG":
                        return 19;
                    case "SENIORUG":
                        return 20;
                    case "CREATED":
                        return 21;
                    case "CREATEUSER":
                        return 22;
                    case "LUPDATEUSER":
                        return 23;
                    case "LUPDATED":
                        return 24;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
