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

        public static AsRooms GetAttributeValue(XmlReader item)
        {
            AsRooms asRooms = new AsRooms();

            item.MoveToAttribute("ID");
            asRooms.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asRooms.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asRooms.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asRooms.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("ROOMNUMBER");
            asRooms.Roomnumber = item.Value;
            item.MoveToAttribute("ROOMTYPE");
            asRooms.Roomtype = short.Parse(item.Value);
            item.MoveToAttribute("OPERTYPEID");
            asRooms.Opertypeid = short.Parse(item.Value);

            if (item.MoveToAttribute("PREVID"))
                asRooms.Previd = long.Parse(item.Value);
            else
                asRooms.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asRooms.Nextid = long.Parse(item.Value);
            else
                asRooms.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asRooms.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asRooms.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asRooms.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");
            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asRooms.Isactual = true;
            else
                asRooms.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asRooms.Isactive = true;
            else
                asRooms.Isactive = false;

            return asRooms;
        }
    }
}
