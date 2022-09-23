using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_APARTMENT_TYPES")]
    public partial class AsApartmentType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("SHORTNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Desk { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsApartmentType GetAttributeValue(XmlReader item)
        {
            AsApartmentType asApartmentType = new AsApartmentType();

            item.MoveToAttribute("ID");
            asApartmentType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asApartmentType.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asApartmentType.Shortname = item.Value;
            else
                asApartmentType.Shortname = null;

            if (item.MoveToAttribute("DESC"))
                asApartmentType.Desk = item.Value;
            else
                asApartmentType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asApartmentType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asApartmentType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asApartmentType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asApartmentType.Isactive = true;
            else
                asApartmentType.Isactive = false;

            return asApartmentType;
        }
    }
}
