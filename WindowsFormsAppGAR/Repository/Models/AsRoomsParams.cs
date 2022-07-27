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

        public static AsRoomsParams GetAttributeValue(XmlElement item)
        {
            AsRoomsParams asRoomsParams = new AsRoomsParams();

            asRoomsParams.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asRoomsParams.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asRoomsParams.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asRoomsParams.Changeidend = long.Parse(item.Attributes.GetNamedItem("CHANGEIDEND").Value);
            asRoomsParams.Typeid = int.Parse(item.Attributes.GetNamedItem("TYPEID").Value);
            asRoomsParams.Value = item.Attributes.GetNamedItem("VALUE").Value;
            asRoomsParams.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asRoomsParams.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asRoomsParams.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            return asRoomsParams;
        }
    }
}
