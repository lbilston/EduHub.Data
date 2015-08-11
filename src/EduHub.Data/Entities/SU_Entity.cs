﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Subjects
    /// </summary>
    public class SU_Entity : EntityBase
    {
        /// <summary>
        /// Subject code [Uppercase Alphanumeric: u5]
        /// </summary>
        public string SUKEY { get; internal set; }
        /// <summary>
        /// Subject name [Titlecase: t30]
        /// </summary>
        public string FULLNAME { get; internal set; }
        /// <summary>
        /// Subject short name for screen displays and reports [Alphanumeric: a10]
        /// </summary>
        public string SHORTNAME { get; internal set; }
        /// <summary>
        /// Faculty [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FACULTY { get; internal set; }
        /// <summary>
        /// Navigation property for [FACULTY] => [KSF_Entity].[KSFKEY]
        /// Faculty
        /// </summary>
        public KSF_Entity FACULTY_KSF { get { return FACULTY == null ? null : Context.KSF.FindByKSFKEY(FACULTY); } }
        /// <summary>
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12) [Uppercase Alphanumeric: u5]
        /// </summary>
        public string PROMOTE { get; internal set; }
        /// <summary>
        /// Navigation property for [PROMOTE] => [SU_Entity].[SUKEY]
        /// Subject that normally follows this subject in a course (eg Physics 11 is followed by Physics 12)
        /// </summary>
        public SU_Entity PROMOTE_SU { get { return PROMOTE == null ? null : Context.SU.FindBySUKEY(PROMOTE); } }
        /// <summary>
        /// Description of subject for parents [Memo: m]
        /// </summary>
        public string OVERVIEW { get; internal set; }
        /// <summary>
        /// Dummy field to enable recording of subject priority [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRIORITY { get; internal set; }
        /// <summary>
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBJECT_ACADEMIC_YEAR { get; internal set; }
        /// <summary>
        /// Navigation property for [SUBJECT_ACADEMIC_YEAR] => [KCY_Entity].[KCYKEY]
        /// (Was ACADEMIC_YEAR) Offered to students at this year level: if blank or matches one of the values in a TT record, the subject is eligible for that template
        /// </summary>
        public KCY_Entity SUBJECT_ACADEMIC_YEAR_KCY { get { return SUBJECT_ACADEMIC_YEAR == null ? null : Context.KCY.FindByKCYKEY(SUBJECT_ACADEMIC_YEAR); } }
        /// <summary>
        /// (Was SEMESTER_OFFERED) Semester/term/quarter in which offered: if 0 or matches the value in a TT record, the subject is eligible for that template [Integer (16bit signed nullable): i]
        /// </summary>
        public short? SEMESTER { get; internal set; }
        /// <summary>
        /// Ultranet. T=Term, S=Semester (default), Y=Year [Uppercase Alphanumeric: u1]
        /// </summary>
        public string DURATION { get; internal set; }
        /// <summary>
        /// Is this subject currently active (available for use in timetabling)? (U=Active, other value=Inactive) [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SUBJECT_TYPE { get; internal set; }
        /// <summary>
        /// Used to Order Subjects for BarCode Printing [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PRINT_SEQ_NO { get; internal set; }
        /// <summary>
        /// Core or elective flag [Uppercase Alphanumeric: u1]
        /// </summary>
        public string ELECTIVE { get; internal set; }
        /// <summary>
        /// VCAA code of this subject for use in VASS export [Uppercase Alphanumeric: u5]
        /// </summary>
        public string VCAA_ID { get; internal set; }
        /// <summary>
        /// Fee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string FEE_CODE { get; internal set; }
        /// <summary>
        /// Navigation property for [FEE_CODE] => [SA_Entity].[SAKEY]
        /// Fee code
        /// </summary>
        public SA_Entity FEE_CODE_SA { get { return FEE_CODE == null ? null : Context.SA.FindBySAKEY(FEE_CODE); } }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
        
        
    }
}
