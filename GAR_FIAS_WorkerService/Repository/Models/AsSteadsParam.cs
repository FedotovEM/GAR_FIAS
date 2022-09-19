using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_STEADS_PARAMS")]
    public partial class AsSteadsParam
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("CHANGEIDEND")]
        public long Changeidend { get; set; }
        [Column("TYPEID")]
        public int Typeid { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(36)]
        public string Value { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }

        public static AsSteadsParam GetAttributeValue(XmlReader item)
        {
            AsSteadsParam asSteadsParams = new AsSteadsParam();

            item.MoveToAttribute("ID");
            asSteadsParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asSteadsParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asSteadsParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asSteadsParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asSteadsParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asSteadsParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asSteadsParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asSteadsParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asSteadsParams.Enddate = DateTime.Parse(item.Value);

            return asSteadsParams;
        }
    }
}
