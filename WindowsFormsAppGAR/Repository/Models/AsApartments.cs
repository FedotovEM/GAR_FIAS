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
    [Table("AS_APARTMENTS")]
    public partial class AsApartments
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
        [Column("APARTTYPE")]
        public short Aparttype { get; set; }
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

        public static AsApartments GetAttributeValue(XmlReader item)
        {
            AsApartments asApartments = new AsApartments();

            item.MoveToAttribute("ID");
            asApartments.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asApartments.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTGUID");
            asApartments.Objectguid = item.Value;
            item.MoveToAttribute("CHANGEID");
            asApartments.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("NUMBER");
            asApartments.Number = item.Value;
            item.MoveToAttribute("APARTTYPE");
            asApartments.Aparttype = short.Parse(item.Value);
            item.MoveToAttribute("OPERTYPEID");
            asApartments.Opertypeid = short.Parse(item.Value); 
           
            if (item.MoveToAttribute("PREVID"))
                asApartments.Previd = long.Parse(item.Value);
            else
                asApartments.Previd = null;

            if (item.MoveToAttribute("NEXTID"))
                asApartments.Nextid = long.Parse(item.Value);
            else
                asApartments.Nextid = null;

            item.MoveToAttribute("UPDATEDATE");
            asApartments.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asApartments.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asApartments.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTUAL");
            string IsactualValue = item.Value;
            if (IsactualValue == "1")
                asApartments.Isactual = true;
            else
                asApartments.Isactual = false;

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1")
                asApartments.Isactive = true;
            else
                asApartments.Isactive = false;

            return asApartments;
        }
    }
}
