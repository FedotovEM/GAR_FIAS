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
    [Table("AS_REESTR_OBJECTS")]
    public partial class AsReestrObjects
    {
        [Key]
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("OBJECTGUID")]
        [StringLength(36)]
        public string Objectguid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }
        [Column("LEVELID")]
        public short Levelid { get; set; }
        [Column("CREATEDATE", TypeName = "date")]
        public DateTime Createdate { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }

        public static AsReestrObjects GetAttributeValue(XmlElement item)
        {
            AsReestrObjects asReestrObjects = new AsReestrObjects();

            asReestrObjects.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asReestrObjects.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asReestrObjects.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asReestrObjects.Isactive = true;
            else
                asReestrObjects.Isactive = false;

            asReestrObjects.Levelid = short.Parse(item.Attributes.GetNamedItem("LEVELID").Value);
            asReestrObjects.Createdate = DateTime.Parse(item.Attributes.GetNamedItem("CREATEDATE").Value);
            asReestrObjects.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
          
            return asReestrObjects;
        }
    }
}
