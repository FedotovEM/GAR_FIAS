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
    [Table("AS_CARPLACES")]
    public partial class AsCarplaces
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
        [Column("NUMBER")]
        [StringLength(50)]
        public string Number { get; set; }
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

        public static AsCarplaces GetAttributeValue(XmlReader item)
        {
            AsCarplaces asCarplaces = new AsCarplaces();

            item.MoveToAttribute("ID");
            asCarplaces.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asCarplaces.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asCarplaces.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asCarplaces.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("NUMBER");
            asCarplaces.Number = item.Value;
            item.MoveToAttribute("OPERTYPEID");
            asCarplaces.Opertypeid = short.Parse(item.Value);

            if (item.MoveToAttribute("PREVID"))
                asCarplaces.Previd = long.Parse(item.Value);
            else
                asCarplaces.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asCarplaces.Nextid = long.Parse(item.Value);
            else
                asCarplaces.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asCarplaces.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asCarplaces.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asCarplaces.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");
            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asCarplaces.Isactual = true;
            else
                asCarplaces.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asCarplaces.Isactive = true;
            else
                asCarplaces.Isactive = false;

            return asCarplaces;
        }
    }
}
