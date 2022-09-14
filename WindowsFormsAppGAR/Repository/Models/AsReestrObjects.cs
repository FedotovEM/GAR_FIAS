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

        public static AsReestrObjects GetAttributeValue(XmlReader item)
        {
            AsReestrObjects asReestrObjects = new AsReestrObjects();

            item.MoveToAttribute("OBJECTID");
            asReestrObjects.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asReestrObjects.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asReestrObjects.Changeid = long.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asReestrObjects.Isactive = true;
            else
                asReestrObjects.Isactive = false;

            item.MoveToAttribute("LEVELID");
            asReestrObjects.Levelid = short.Parse(item.Value);
            item.MoveToAttribute("CREATEDATE");
            asReestrObjects.Createdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("UPDATEDATE");
            asReestrObjects.Updatedate = DateTime.Parse(item.Value);
          
            return asReestrObjects;
        }
    }
}
