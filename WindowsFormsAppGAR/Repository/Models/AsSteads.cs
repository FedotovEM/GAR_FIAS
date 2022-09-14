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
    [Table("AS_STEADS")]
    public partial class AsSteads
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
        [StringLength(250)]
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

        public static AsSteads GetAttributeValue(XmlReader item)
        {
            AsSteads asSteads = new AsSteads();
            item.MoveToAttribute("ID");
            asSteads.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asSteads.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asSteads.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asSteads.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("NUMBER");
            asSteads.Number = item.Value;
            item.MoveToAttribute("OPERTYPEID");
            asSteads.Opertypeid = short.Parse(item.Value);

            if (item.MoveToAttribute("PREVID"))
                asSteads.Previd = long.Parse(item.Value);
            else
                asSteads.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asSteads.Nextid = long.Parse(item.Value);
            else
                asSteads.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asSteads.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asSteads.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asSteads.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");
            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asSteads.Isactual = true;
            else
                asSteads.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asSteads.Isactive = true;
            else
                asSteads.Isactive = false;

            return asSteads;
        }
    }
}
