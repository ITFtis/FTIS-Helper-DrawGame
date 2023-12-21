using Dou.Misc.Attr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FtisHelperDrawGame.DB.Model
{
    public partial class F22cmmDep
    {
        [Key]
        [Column(Order = 0)]
        [ColumnDef(Display = "�����N�X(�s)")]
        [StringLength(2)]
        public string DCode { get; set; }

        [Required]
        [Column(Order = 1)]
        [ColumnDef(Display = "�����W��")]
        [StringLength(20)]
        public string DName { get; set; }

        [Required]
        [Column(Order = 2)]
        [ColumnDef(Display = "����²��", ColSize = 3)]
        [StringLength(20)]
        public string Dnickname { get; set; }

        [ColumnDef(Display = "�����W��(�^)", ColSize = 3)]
        [StringLength(50)]
        public string En_DName { get; set; }

        [ColumnDef(Display = "���ɤH1")]
        [StringLength(6)]
        public string DCkNo1 { get; set; }

        [ColumnDef(Display = "���ɤH2")]
        [StringLength(6)]
        public string DCkNo2 { get; set; }

        [ColumnDef(Display = "���ɤH3")]
        [StringLength(6)]
        public string DCkNo3 { get; set; }

        [ColumnDef(Display = "�޲z�v")]
        [StringLength(6)]
        public string DAdmino { get; set; }

        [ColumnDef(Display = "�̰��D��")]
        [StringLength(6)]
        public string DCkTopNo { get; set; }

        [Required]
        [Column(Order = 3)]
        [ColumnDef(Display = "�ҥλP�_")]
        [StringLength(1)]
        public string IsUsed { get; set; }

        [Required]
        [Column(Order = 4)]
        [ColumnDef(Display = "�����N�X(��)")]
        [StringLength(2)]
        public string DCode_ { get; set; }

        public List<F22cmmEmpData> EmpDatas { get; set; }   
    }
}
