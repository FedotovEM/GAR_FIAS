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
    [Table("AS_HOUSES")]
    public partial class AsHouses
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
        [Column("HOUSENUM")]
        [StringLength(50)]
        public string Housenum { get; set; }
        [Column("ADDNUM1")]
        [StringLength(50)]
        public string Addnum1 { get; set; }
        [Column("ADDNUM2")]
        [StringLength(50)]
        public string Addnum2 { get; set; }
        [Column("HOUSETYPE")]
        public byte? Housetype { get; set; }
        [Column("ADDTYPE1")]
        public byte? Addtype1 { get; set; }
        [Column("ADDTYPE2")]
        public byte? Addtype2 { get; set; }
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

        public static AsHouses GetAttributeValue(XmlReader item)
        {
            AsHouses asHouses = new AsHouses();

            item.MoveToAttribute("ID");
            asHouses.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asHouses.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asHouses.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asHouses.Changeid = long.Parse(item.Value);

            if (item.MoveToAttribute("HOUSENUM"))
                asHouses.Housenum = item.Value;
            else
                asHouses.Housenum = null;

            if (item.MoveToAttribute("ADDNUM1"))
                asHouses.Addnum1 = item.Value;
            else
                asHouses.Addnum1 = null;
            if (item.MoveToAttribute("ADDNUM2"))
                asHouses.Addnum2 = item.Value;
            else
                asHouses.Addnum2 = null;

            if (item.MoveToAttribute("HOUSETYPE"))
                asHouses.Housetype = byte.Parse(item.Value);
            else
                asHouses.Housetype = null;

            if (item.MoveToAttribute("ADDTYPE1"))
                asHouses.Addtype1 = byte.Parse(item.Value);
            else
                asHouses.Addtype1 = null;

            if (item.MoveToAttribute("ADDTYPE2"))
                asHouses.Addtype2 = byte.Parse(item.Value);
            else
                asHouses.Addtype2 = null;

            item.MoveToAttribute("OPERTYPEID");
            asHouses.Opertypeid = short.Parse(item.Value);

            if (item.MoveToAttribute("PREVID"))
                asHouses.Previd = long.Parse(item.Value);
            else
                asHouses.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asHouses.Nextid = long.Parse(item.Value);
            else
                asHouses.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asHouses.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asHouses.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asHouses.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");
            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asHouses.Isactual = true;
            else
                asHouses.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asHouses.Isactive = true;
            else
                asHouses.Isactive = false;

            return asHouses;
        }
    }
}
