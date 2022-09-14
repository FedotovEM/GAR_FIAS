using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_STEADS_PARAMS")]
    public partial class AsSteadsParams
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

        public static AsSteadsParams GetAttributeValue(XmlReader item)
        {
            AsSteadsParams asSteadsParams = new AsSteadsParams();

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
