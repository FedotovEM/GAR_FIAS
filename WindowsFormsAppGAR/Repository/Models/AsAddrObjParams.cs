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
    [Table("AS_ADDR_OBJ_PARAMS")]
    public partial class AsAddrObjParams
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

        public static AsAddrObjParams GetAttributeValue(XmlElement item)
        {
            AsAddrObjParams asAddrObjParams = new AsAddrObjParams();

            asAddrObjParams.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asAddrObjParams.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asAddrObjParams.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asAddrObjParams.Changeidend = long.Parse(item.Attributes.GetNamedItem("CHANGEIDEND").Value);
            asAddrObjParams.Typeid = int.Parse(item.Attributes.GetNamedItem("TYPEID").Value);
            asAddrObjParams.Value = item.Attributes.GetNamedItem("VALUE").Value;
            asAddrObjParams.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asAddrObjParams.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asAddrObjParams.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            return asAddrObjParams;
        }
    }
}
