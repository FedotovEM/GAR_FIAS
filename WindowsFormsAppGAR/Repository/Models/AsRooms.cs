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
    [Table("AS_ROOMS")]
    public partial class AsRooms
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("OBJECTGUID")]
        [StringLength(36)]
        public string Objectguid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Required]
        [Column("ROOMNUMBER")]
        [StringLength(50)]
        public string Roomnumber { get; set; }
        [Column("ROOMTYPE")]
        public short Roomtype { get; set; }
        [Column("OPERTYPEID")]
        public short Opertypeid { get; set; }
        [Column("PREVID")]
        public long? Previd { get; set; }
        [Column("NEXTID")]
        public long? Nextid { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTUAL")]
        public bool Isactual { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsRooms GetAttributeValue(XmlElement item)
        {
            AsRooms asRooms = new AsRooms();

            asRooms.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asRooms.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asRooms.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asRooms.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asRooms.Roomnumber = item.Attributes.GetNamedItem("ROOMNUMBER").Value;
            asRooms.Roomtype = short.Parse(item.Attributes.GetNamedItem("ROOMTYPE").Value);
            asRooms.Opertypeid = short.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value);

            if (item.HasAttribute("PREVID"))
                asRooms.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asRooms.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asRooms.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asRooms.Nextid = null;

            asRooms.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asRooms.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asRooms.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;
            if (IsactualValue == "1")
                asRooms.Isactual = true;
            else
                asRooms.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asRooms.Isactive = true;
            else
                asRooms.Isactive = false;

            return asRooms;
        }
    }
}
