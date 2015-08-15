﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Payroll Transactions
    /// </summary>
    public class PEF_Entity : EntityBase
    {
#region Navigation Property Cache
        private PE_Entity _CODE_PE;
        private PI_Entity _PAYITEM_PI;
        private PC_Entity _TRCENTRE_PC;
        private PS_Entity _PAY_STEP_PS;
        private KGLSUB_Entity _SUBPROGRAM_KGLSUB;
        private KGLINIT_Entity _INITIATIVE_KGLINIT;
#endregion

#region Field Properties
        /// <summary>
        ///  [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Employee code [Uppercase Alphanumeric: u10]
        /// </summary>
        public string CODE { get; internal set; }
        /// <summary>
        /// Pay item code [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAYITEM { get; internal set; }
        /// <summary>
        /// Cost centre [Uppercase Alphanumeric: u10]
        /// </summary>
        public string TRCENTRE { get; internal set; }
        /// <summary>
        /// E = Employee pay [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRTYPE { get; internal set; }
        /// <summary>
        /// Batch number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRBATCH { get; internal set; }
        /// <summary>
        /// Payroll group [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRPAYCODE { get; internal set; }
        /// <summary>
        /// Payroll period number [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPAYPERD { get; internal set; }
        /// <summary>
        /// Transaction period (not used) [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRPERD { get; internal set; }
        /// <summary>
        /// Transaction date [Date Time nullable: d]
        /// </summary>
        public DateTime? TRDATE { get; internal set; }
        /// <summary>
        /// Reference [Alphanumeric: a10]
        /// </summary>
        public string TRREF { get; internal set; }
        /// <summary>
        /// Pay rate [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRCOST { get; internal set; }
        /// <summary>
        /// Hours [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRQTY { get; internal set; }
        /// <summary>
        /// Dollar value (always positive) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRAMT { get; internal set; }
        /// <summary>
        /// Addition or Deduction. This controls the arithmetic of TRAMT [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TRPITYPE { get; internal set; }
        /// <summary>
        /// Hrs, Kms, Day, Prd, etc [Alphanumeric: a3]
        /// </summary>
        public string TRUNIT { get; internal set; }
        /// <summary>
        /// Detail [Alphanumeric: a30]
        /// </summary>
        public string TRDET { get; internal set; }
        /// <summary>
        /// Next pay date for employee [Date Time nullable: d]
        /// </summary>
        public DateTime? TRNEXTPAYDATE { get; internal set; }
        /// <summary>
        /// Next pay period [Integer (32bit signed nullable): l]
        /// </summary>
        public int? TRNEXTPAYPERD { get; internal set; }
        /// <summary>
        /// No. of pay spans [Integer (16bit signed nullable): i]
        /// </summary>
        public short? TRPAYSPAN { get; internal set; }
        /// <summary>
        /// No. of tax spans [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? TRTAXSPAN { get; internal set; }
        /// <summary>
        /// Next pay date for this payroll group [Date Time nullable: d]
        /// </summary>
        public DateTime? PNNEXTPAYDATE { get; internal set; }
        /// <summary>
        /// Super fund key (SGL or Personal) [Uppercase Alphanumeric: u10]
        /// </summary>
        public string SUPER_FUND { get; internal set; }
        /// <summary>
        /// Super fund member number [Uppercase Alphanumeric: u20]
        /// </summary>
        public string SUPER_MEMBER { get; internal set; }
        /// <summary>
        /// Field for format only [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? WORKED_HOURS { get; internal set; }
        /// <summary>
        /// Pay Rate Step number [Integer (16bit signed nullable): i]
        /// </summary>
        public short? PAY_STEP { get; internal set; }
        /// <summary>
        /// Not used (required for a financial table) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRNETT { get; internal set; }
        /// <summary>
        /// Not used (required for a financial table) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? GST_AMOUNT { get; internal set; }
        /// <summary>
        /// Not used (required for a financial table) [Currency (128bit scaled integer nullable): c]
        /// </summary>
        public decimal? TRGROSS { get; internal set; }
        /// <summary>
        /// "A" Addition or "D" Deduction [Uppercase Alphanumeric: u1]
        /// </summary>
        public string PAYSIGNTYPE { get; internal set; }
        /// <summary>
        /// Indicates which record is tax record [Uppercase Alphanumeric: u1]
        /// </summary>
        public string SYSTEM_TAX { get; internal set; }
        /// <summary>
        /// Line number in the batch [Integer (32bit signed nullable): l]
        /// </summary>
        public int? LINE_NO { get; internal set; }
        /// <summary>
        /// Determines through posts 0 = Don't show T/P 1 = Show T/P [Integer (32bit signed nullable): l]
        /// </summary>
        public int? FLAG { get; internal set; }
        /// <summary>
        /// R or T for Redundancy, invalidity or approved early retirement [Uppercase Alphanumeric: u1]
        /// </summary>
        public string TERMINATION_TYPE { get; internal set; }
        /// <summary>
        /// For every transaction there is a subprogram [Uppercase Alphanumeric: u4]
        /// </summary>
        public string SUBPROGRAM { get; internal set; }
        /// <summary>
        /// A subprogram always belongs to a program [Uppercase Alphanumeric: u3]
        /// </summary>
        public string GLPROGRAM { get; internal set; }
        /// <summary>
        /// Transaction might belong to an Initiative [Uppercase Alphanumeric: u3]
        /// </summary>
        public string INITIATIVE { get; internal set; }
        /// <summary>
        /// Holiday pay split precentage, Normal or LPA.  Used for leave accruals [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? SPLIT_PERCENT { get; internal set; }
        /// <summary>
        /// Alter hours, used in PE31001 to assist with LPA/Annual split calc [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ALTER_TRQTY { get; internal set; }
        /// <summary>
        /// Record annulaised loading percetage used in loading calculation [Floating Point Number (precision 15 nullable): r]
        /// </summary>
        public double? ANNUALISED_LOADING { get; internal set; }
        /// <summary>
        /// Last write date [Date Time nullable: d]
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time [Integer (16bit signed nullable): i]
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator [Uppercase Alphanumeric: u128]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CODE] => [PE_Entity].[PEKEY]
        /// Employee code
        /// </summary>
        public PE_Entity CODE_PE {
            get
            {
                if (CODE != null)
                {
                    if (_CODE_PE == null)
                    {
                        _CODE_PE = Context.PE.FindByPEKEY(CODE);
                    }
                    return _CODE_PE;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PAYITEM] => [PI_Entity].[PIKEY]
        /// Pay item code
        /// </summary>
        public PI_Entity PAYITEM_PI {
            get
            {
                if (PAYITEM.HasValue)
                {
                    if (_PAYITEM_PI == null)
                    {
                        _PAYITEM_PI = Context.PI.FindByPIKEY(PAYITEM.Value);
                    }
                    return _PAYITEM_PI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TRCENTRE] => [PC_Entity].[PCKEY]
        /// Cost centre
        /// </summary>
        public PC_Entity TRCENTRE_PC {
            get
            {
                if (TRCENTRE != null)
                {
                    if (_TRCENTRE_PC == null)
                    {
                        _TRCENTRE_PC = Context.PC.FindByPCKEY(TRCENTRE);
                    }
                    return _TRCENTRE_PC;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PAY_STEP] => [PS_Entity].[PSKEY]
        /// Pay Rate Step number
        /// </summary>
        public PS_Entity PAY_STEP_PS {
            get
            {
                if (PAY_STEP.HasValue)
                {
                    if (_PAY_STEP_PS == null)
                    {
                        _PAY_STEP_PS = Context.PS.FindByPSKEY(PAY_STEP.Value);
                    }
                    return _PAY_STEP_PS;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [SUBPROGRAM] => [KGLSUB_Entity].[SUBPROGRAM]
        /// For every transaction there is a subprogram
        /// </summary>
        public KGLSUB_Entity SUBPROGRAM_KGLSUB {
            get
            {
                if (SUBPROGRAM != null)
                {
                    if (_SUBPROGRAM_KGLSUB == null)
                    {
                        _SUBPROGRAM_KGLSUB = Context.KGLSUB.FindBySUBPROGRAM(SUBPROGRAM);
                    }
                    return _SUBPROGRAM_KGLSUB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [INITIATIVE] => [KGLINIT_Entity].[INITIATIVE]
        /// Transaction might belong to an Initiative
        /// </summary>
        public KGLINIT_Entity INITIATIVE_KGLINIT {
            get
            {
                if (INITIATIVE != null)
                {
                    if (_INITIATIVE_KGLINIT == null)
                    {
                        _INITIATIVE_KGLINIT = Context.KGLINIT.FindByINITIATIVE(INITIATIVE);
                    }
                    return _INITIATIVE_KGLINIT;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}
