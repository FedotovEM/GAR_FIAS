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
    [Table("AS_ROOMS_PARAMS")]
    public partial class AsRoomsParams
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

        public static AsRoomsParams GetAttributeValue(XmlReader item)
        {
            AsRoomsParams asRoomsParams = new AsRoomsParams();

            item.MoveToAttribute("ID");
            asRoomsParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asRoomsParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asRoomsParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asRoomsParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asRoomsParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asRoomsParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asRoomsParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asRoomsParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asRoomsParams.Enddate = DateTime.Parse(item.Value);

            return asRoomsParams;
        }
    }
}
